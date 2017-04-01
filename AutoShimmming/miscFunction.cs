using AutoShimmming;
using System;
using ZedGraph;
using FFTWSharp;
using System.Drawing;
using System.Numerics;
using System.Linq;
using MRILibrary;
using System.Collections;
using System.IO;
using System.ComponentModel;
using System.Windows.Forms;

namespace AutoShimmming
{


    public struct LineShape
    {
        public double max;
        public int maxPos;
        public double lineWidth;
        public double lineWidthAt;
    }

    public delegate void getFiles(string fileNameString);

    public partial class mainForm
    {
        
        //BackgroundWorker 

        public static Func<string, Int32> ConnectToSprectrum = NMR.Init;

        static string InitializationFileName = @"C:\mri_20160903\dll\hw_cfg\init.ini";

        void updateDisplay(double[] dataReal, double[] dataImag, double[] spectrumAbs, double freqSampling)
        {
            dataFormat df;
            int dataLength = dataReal.Length;
            double[] t = new double[dataLength];
            //double[] spectrum;
            //double[] spectrum_abs;
            //double[] spectrum_abs_sort;
            //double[] f_sort;
            double[] f;
            if (dataImag == null)
            {
                df = dataFormat.Real;
            }
            else
            {
                df = dataFormat.Comp;
            }
            if (df == dataFormat.Real)
            {
                f = new double[dataLength / 2];
                for (int i = 0; i < f.Length; i++)
                {
                    f[i] = i * freqSampling / dataLength;
                }
            }
            else
            {
                f = new double[dataLength];
                for (int i = 0; i < f.Length; i++)
                {
                    f[i] = i * freqSampling / dataLength - freqSampling / 2;
                }
            }
            for (int i = 0; i < dataLength; i++)
            {
                t[i] = i / freqSampling;
            }

            tdPane.CurveList.Clear();
            LineItem tdCurve;

            if (dataImag == null)
            {
                tdCurve = tdPane.AddCurve("", t, dataReal, Color.FromArgb(0, 255, 0));
                tdCurve.Symbol.Size = 1;
                tdCurve.Symbol.Type = SymbolType.Circle;
            }
            else
            {
                tdCurve = tdPane.AddCurve("", t, dataReal, Color.FromArgb(0, 255, 0));
                tdCurve.Symbol.Size = 1;
                tdCurve.Symbol.Type = SymbolType.Circle;
                tdCurve = tdPane.AddCurve("", t, dataImag, Color.FromArgb(255, 0, 0));
                tdCurve.Symbol.Size = 1;
                tdCurve.Symbol.Type = SymbolType.Circle;
            }
            tdCurve.Symbol.Size = 1;
            tdCurve.Symbol.Type = SymbolType.Circle;
            tdPane.XAxis.Scale.Min = 0;
            tdPane.XAxis.Scale.Max = t[dataLength - 1];

            sdPane.CurveList.Clear();
            LineItem sdCurve;
            if (dataImag == null)
            {
                sdCurve = sdPane.AddCurve("", f, spectrumAbs, Color.FromArgb(0, 255, 0));
            }
            else
            {
                if (rbtDB.Checked)
                    for (int i = 0; i < spectrumAbs.Length; i++)
                    {
                        spectrumAbs[i] = 20f * Math.Log10(spectrumAbs[i]);
                    }
                sdCurve = sdPane.AddCurve("", f, spectrumAbs, Color.FromArgb(0, 255, 0));
            }
            //tbxMaxAmplitude.Text = spectrumAbs.Max().ToString("e2");
            sdCurve.Symbol.Size = 2;
            sdCurve.Symbol.Type = SymbolType.Circle;
            sdPane.XAxis.Scale.Min = f[0]; ;
            sdPane.XAxis.Scale.Max = f[spectrumAbs.Length - 1];
            sdPane.YAxis.Scale.MaxAuto = true;
            sdPane.YAxis.Scale.MinAuto = true;
            sdPane.AxisChange();
            tdPane.AxisChange();
            Refresh();
        }

        /// <summary>
        /// 函数connectScope用于连接谱仪
        /// </summary>
        private void connectScope()
        {
            if (Connect == ConnectStatus.NotConnected)
            {
                Connect = ConnectStatus.Connecting;
                //btnConnect.Enabled = false;
                statusStrip.Items[0].Text = "Connecting...";
                ConnectToSprectrum.BeginInvoke(initFileName, CallbackConect, null);
            }

        }

        /// <summary>
        /// 函数getLineShape用于计算回波的谱线参数
        /// 输入参数data存放谱线的绝对值；lineWidthAtPercent为0到1之间的数，表示要计算的谱线宽度在最大值
        /// 的百分比，0.5表示计算最大值50%处的谱线宽度。
        /// 输出结构的max表示谱线峰值，maxPos表示峰值点位置，lineWidth表示线宽，lineWidthAt计算线宽处
        /// 相对于峰值的百分比。这里峰值点位置、线宽均以频谱点数计，应用时需换算为实际频率
        /// </summary>
        /// <param name="data"></param>
        /// <param name="lineWidthAtPercent"></param>
        /// <returns></returns>
        public LineShape getLineShape(double[] data, double lineWidthAtPercent)
        {
            double _max = 0;
            Int32 _maxPos = 0;
            Int32 _lineWidthAtLeftMinus1 = 0;
            Int32 _lineWidthAtRightPlus1 = 0;
            double _lineWidthAtLeft, _lineWidthAtRight;
            double _lineWidthAt;
            double _lineWidth;
            LineShape ls = new LineShape();
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > _max)
                {
                    _max = data[i];
                    _maxPos = i;
                }
            }
            _lineWidthAt = lineWidthAtPercent * _max;
            for (int i = _maxPos; i > 0; i--)
            {
                if (data[i] < _lineWidthAt)
                {
                    _lineWidthAtLeftMinus1 = i;
                    break;
                }
            }
            for (int i = _maxPos; i < data.Length; i++)
            {
                if (data[i] < _lineWidthAt)
                {
                    _lineWidthAtRightPlus1 = i;
                    break;
                }
            }
            _lineWidthAtLeft = (double)_lineWidthAtLeftMinus1 +
                (_lineWidthAt - data[_lineWidthAtLeftMinus1]) /
                (data[_lineWidthAtLeftMinus1 + 1] - data[_lineWidthAtLeftMinus1]);
            _lineWidthAtRight = (double)_lineWidthAtRightPlus1 -
                (_lineWidthAt - data[_lineWidthAtRightPlus1]) /
                (data[_lineWidthAtRightPlus1 - 1] - data[_lineWidthAtRightPlus1]);
            _lineWidth = _lineWidthAtRight - _lineWidthAtLeft;
            ls.max = _max;
            ls.maxPos = _maxPos;
            ls.lineWidth = _lineWidth;
            ls.lineWidthAt = _lineWidthAt;
            return ls;
        }

        void SetZoomPanMode()
        {
            if (rbtFreeZoom.Checked == true)
            {
                zgc.IsEnableVZoom = true;
                zgc.IsEnableHZoom = true;
            }
            else if (rbtHzoom.Checked == true)
            {
                zgc.IsEnableVZoom = false;
                zgc.IsEnableHZoom = true;
            }
            else if (rbtVZoom.Checked == true)
            {
                zgc.IsEnableVZoom = true;
                zgc.IsEnableHZoom = false;
            }
            if (rbtFreePan.Checked == true)
            {
                zgc.IsEnableHPan = true;
                zgc.IsEnableVPan = true;
            }
            else if (rbtHPan.Checked == true)
            {
                zgc.IsEnableHPan = true;
                zgc.IsEnableVPan = false;
            }
            else if (rbtVPan.Checked == true)
            {
                zgc.IsEnableHPan = false;
                zgc.IsEnableVPan = true;
            }
        }

        getFiles fetchRawData = delegate(string rawDataFileName)
        {
            ArrayList lst;
            string[] fileNameList;
            string[] fileNameList2;
            fileNameList = rawDataFileName.Split(':');
            lst = new ArrayList(fileNameList);
            lst.RemoveAt(lst.Count - 1);
            fileNameList2 = new string[lst.Count / 2];
            for (int i = 0; i < lst.Count / 2; i++)
            {
                fileNameList2[i] = lst[2 * i] + ":" + lst[2 * i + 1];
            }
            MRIData data = new MRIData(fileNameList2);
            //updateDisplay(data.getAViewReal(), data.getAViewImag(), data.getAViewAbs(), _sampleBandWidth);
        };

        void updateUI()
        {
            if (!string.IsNullOrEmpty(_seqFileName))
            {
                tbxSequenceName.Text = _seqFileName;
            }
            if (!double.IsNaN(_sampleBandWidth))
            {
                tbxSampleBandWidth.Text = _sampleBandWidth.ToString();
            }
            if (!double.IsNaN(_TR))
            {
                tbxTR.Text = _TR.ToString();
            }
            if (!double.IsNaN(_TE))
            {
                tbxTE.Text = _TE.ToString();
            }
            if (!double.IsNaN(_F0))
            {
                tbxSysFreq.Text = _F0.ToString();
            }
            if (!double.IsNaN(_RxGain))
            {
                tbxRxGain.Text = _RxGain.ToString();
            }
            if (!double.IsNaN(_freqOffset))
            {
                trbFreqOffset.Value = (Int32)_freqOffset;
            }
            if (!double.IsNaN(_noScans))
            {
                tbxNoScans.Text = _noScans.ToString();
            }
            statusStrip.Items[0].Text = "Not connect.";
        }

        /// <summary>
        /// 解析序列扫描参数，输入参数为参数文件名*.par
        /// </summary>
        /// <param name="parFileName"></param>
        private void parsingParameterFile(string parFileName)
        {
            string line;
            ArrayList lines = new ArrayList();
            StreamReader parFile = new StreamReader(parFileName);
            while ((line = parFile.ReadLine()) != null)
            {
                line = line.Trim();
                if (line[0] != '#')
                {
                    lines.Add(line);
                }
            }
            foreach (string item in lines)
            {
                string tmp;
                int tmpInt;
                if (item.StartsWith(":double	samplePeriod,"))
                {
                    tmp = item.Substring(":double	samplePeriod,".Length);
                    tmpInt = tmp.IndexOf(':');
                    tmp = tmp.Substring(0, tmpInt);
                    SamplePeriod = double.Parse(tmp);
                    SampleBandWidth = 1e6 / SamplePeriod;
                }
                if (item.StartsWith(":double	TR,"))
                {
                    tmp = item.Substring(":double	TR,".Length);
                    tmpInt = tmp.IndexOf(':');
                    tmp = tmp.Substring(0, tmpInt);
                    TR = double.Parse(tmp);
                }
                if (item.StartsWith(":double	TE,"))
                {
                    tmp = item.Substring(":double	TE,".Length);
                    tmpInt = tmp.IndexOf(':');
                    tmp = tmp.Substring(0, tmpInt);
                    TE = double.Parse(tmp);
                }
                if (item.StartsWith(":double	rxGain,"))
                {
                    tmp = item.Substring(":double	rxGain,".Length);
                    tmpInt = tmp.IndexOf(':');
                    tmp = tmp.Substring(0, tmpInt);
                    RxGain = double.Parse(tmp);
                }
                if (item.StartsWith(":double	rx_freq_offset_data,"))
                {
                    tmp = item.Substring(":double	rx_freq_offset_data,".Length);
                    tmpInt = tmp.IndexOf(':');
                    tmp = tmp.Substring(0, tmpInt);
                    FreqOffset = double.Parse(tmp);
                }
                if (item.StartsWith(":double	noScans,"))
                {
                    tmp = item.Substring(":double	noScans,".Length);
                    tmpInt = tmp.IndexOf(':');
                    tmp = tmp.Substring(0, tmpInt);
                    NoScans = (Int32)Double.Parse(tmp);
                }
            }
        }

        public string ExtractSequenceParameter(string parameterString,string preString)
        {
            if (parameterString.StartsWith(preString))
            {
                Int32 markPos = parameterString.IndexOf(":", 1);
                return parameterString.Remove(markPos).Substring(preString.Length);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 根据指定的采样周期搜索相应的椭圆函数滤波器文件，该文件设置接收滤波器
        /// </summary>
        /// <param name="_samplePeriod"></param>
        /// <returns>
        /// 返回值为滤波器文件名
        /// </returns>
        private string searchFilter(double _samplePeriod)
        {
            //throw new NotImplementedException();
            if (Double.IsNaN(_samplePeriod))
            {
                MessageBox.Show("未指定采样周期！");
                return null;
            }
            //double _sampleBandWidth;
            string line;
            StreamReader filterFileRD = new StreamReader(_filterFolder + "\\FilterLUT.csv");
            while ((line = filterFileRD.ReadLine()) != null)
            {
                Int32 commaPos = line.IndexOf(',');
                string tmpStr = _samplePeriod.ToString();
                string tmpStr2 = line.Remove(commaPos);
                if (tmpStr == tmpStr2)
                {
                    string tmpStr3 = line.Replace(tmpStr + ",", "");
                    return _filterFolder + "\\" + "ellipse_" + tmpStr3 + ".dat";
                }
            }
            return null;
        }

    }



}