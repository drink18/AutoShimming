using AutoShimmming;
using System;
using ZedGraph;
using FFTWSharp;
using System.Drawing;
using System.Numerics;
using System.Linq;

namespace AutoShimmming
{
    public struct LineShape
    {
        public double max;
        public int maxPos;
        public double lineWidth;
        public double lineWidthAt;
    }


    public partial class mainForm
    {
        public void updateDisplay(double[] dataReal, double[] dataImag, double freqSampling)
        {
            dataFormat df;
            int dataLength = dataReal.Length;
            double[] t = new double[dataLength];
            double[] spectrum;
            double[] spectrum_abs;
            double[] spectrum_abs_sort;
            double[] f_sort;
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
                f = new double[dataLength / 2];
                spectrum = new double[dataLength];
                spectrum = fft1d_real(dataReal, fftw_direction.Forward);
                spectrum_abs = new double[dataLength / 2];
                for (int i = 0; i < spectrum_abs.Length; i++)
                {
                    spectrum_abs[i] = Math.Sqrt(spectrum[2 * i] * spectrum[2 * i] + spectrum[2 * i + 1] * spectrum[2 * i + 1]);
                    if (rbtDB.Checked)
                    {
                        spectrum_abs[i] = 20f * Math.Log10(spectrum_abs[i]);
                    }
                }
                sdCurve = sdPane.AddCurve("", f, spectrum_abs, Color.FromArgb(0, 255, 0));
            }
            else
            {

                spectrum = new double[2 * dataLength];
                spectrum = fft1d_comp(dataReal, dataImag, fftw_direction.Forward);
                spectrum_abs = new double[dataLength];
                spectrum_abs_sort = new double[dataLength];
                f_sort = new double[dataLength];
                for (int i = 0; i < spectrum_abs.Length; i++)
                {
                    spectrum_abs[i] = Math.Sqrt(spectrum[2 * i] * spectrum[2 * i] + spectrum[2 * i + 1] * spectrum[2 * i + 1]);
                    if (rbtDB.Checked)
                    {
                        spectrum_abs[i] = 20f * Math.Log10(spectrum_abs[i]);
                    }
                }
                double[] tmp = new double[spectrum_abs.Length];
                for (int i = 0; i < spectrum_abs.Length; i++)
                {
                    tmp[i] = spectrum_abs[(i + spectrum_abs.Length / 2) % spectrum_abs.Length];
                }
                spectrum_abs = tmp;
                sdCurve = sdPane.AddCurve("", f, spectrum_abs, Color.FromArgb(0, 255, 0));
            }
            tbxMaxAmplitude.Text = spectrum_abs.Max().ToString("e2");
            sdCurve.Symbol.Size = 2;
            sdCurve.Symbol.Type = SymbolType.Circle;
            sdPane.XAxis.Scale.Min = f[0]; ;
            sdPane.XAxis.Scale.Max = f[spectrum_abs.Length - 1];
            sdPane.YAxis.Scale.MaxAuto = true;
            sdPane.YAxis.Scale.MinAuto = true;
            sdPane.AxisChange();
            tdPane.AxisChange();
            Refresh();
        }

        public LineShape getLineShape(double[] data,double[] freq, double lineWidthAtPercent)
        {
            double _max = 0;
            Int32 _maxPos = 0;
            Int32 _lineWidthAtLeftMinus1=0;
            Int32 _lineWidthAtRightPlus1=0;
            double _lineWidthAtLeft, _lineWidthAtRight;
            double _lineWidthAt;
            double _lineWidth;
            LineShape ls=new LineShape();
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > _max)
                {
                    _max = data[i];
                    _maxPos = i;
                }
            }
            _lineWidthAt = lineWidthAtPercent * _max;
            for (int i=_maxPos; i>0; i--)
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
            _lineWidthAtRight=(double)_lineWidthAtRightPlus1-
                (_lineWidthAt - data[_lineWidthAtRightPlus1]) /
                (data[_lineWidthAtRightPlus1 +1] - data[_lineWidthAtRightPlus1]);
            _lineWidth = _lineWidthAtRight - _lineWidthAtLeft;
            ls.max=_max;
            ls.maxPos=_maxPos;
            ls.lineWidth = _lineWidth;
            ls.lineWidthAt = _lineWidthAt;
            return ls;
        }
        
    }
}