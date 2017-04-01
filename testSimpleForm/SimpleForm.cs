using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MRILibrary;


namespace AutoShimmming
{
    public delegate void getFiles(string fileNameString);

    public partial class SimpleForm : Form
    {
        string _initFileName;
        string _fcfgFileName;
        string _fcfgFolder;
        string _dataFolder;
        string _filterFolder;
        byte[] _dllVersion;
        string _parFileName;
        //string _fcfgDir;
        string _filterFileName;

        double _TR;
        Int32 _noScans;
        double _samplePeriod;

        public SimpleForm()
        {
            InitializeComponent();
            _initFileName = @"C:\mri_20160903\dll\hw_cfg\init.ini";
            _fcfgFileName = @"D:\seq\application_sequences\building\1pulse.fcfg";
            _fcfgFolder = @"D:\seq\application_sequences\building";
            _filterFolder = @"C:\mri_20160903\dll\hw_cfg\filter";
            _dataFolder = @"D:\tmpRaw";

            tbxInitFileName.Text = _initFileName;
            tbxFcfgFileName.Text = _fcfgFileName;
            tbxDataFolder.Text = _dataFolder;
            tbxFilterFolder.Text = _filterFolder;
            _dllVersion = new byte[16];
            IntPtr ptr;

            try
            {
                ptr = NMR.GetDLLVersion();
                Marshal.Copy(ptr, _dllVersion, 0, 16);

            }
            finally
            {
                //Marshal.FreeHGlobal(ptr);
            }
            tbxDllVersion.Text = System.Text.Encoding.Default.GetString(_dllVersion);
            parsingSeqPara(_fcfgFileName);
            _filterFileName=searchFilter(_samplePeriod);
            tbxFilterFileName.Text = _filterFileName;
            NMR.SetOutputFile(_dataFolder);
            NMR.RegisterImageP(fetchRawData);
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
            StreamReader filterFileRD = new StreamReader(_filterFolder+"\\FilterLUT.csv");
            while ((line = filterFileRD.ReadLine()) != null)
            {
                Int32 commaPos = line.IndexOf(',');
                string tmpStr=_samplePeriod.ToString();
                string tmpStr2 = line.Remove(commaPos);
                if (tmpStr == tmpStr2)
                {
                    string tmpStr3 = line.Replace(tmpStr+",","");
                    return _filterFolder+"\\"+"ellipse_" + tmpStr3 + ".dat";
                }
            }
            return null;
        }

        private void ConnectToScope()
        {
            //throw new NotImplementedException();
            statusStrip.Items[0].Text = "Connecting...";
            NMR.SetVerboseLevel(1);
            if (NMR.Init(_initFileName) == 0)
            {
                statusStrip.Items[0].Text = "Connected!";
            }
            else
            {
                statusStrip.Items[0].Text = "Connect Failed!";
            }
            NMR.ConfigFile(_initFileName);
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            ConnectToScope();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            NMR.SetConfigure(_fcfgFileName);
            NMR.SetFilter(_filterFileName);
            if (NMR.Run()==0)
            {
                //wait for end
                while(NMR.ScanCompleted() != 2)
                    Thread.Sleep(300);
                MessageBox.Show("Scan done");
            }
        }
        private void parsingSeqPara(string fcfgName)
        {
            string[] _fcfgPara;
            string[] _parPara;
            
            try
            {
                FileStream fcfgFile = new FileStream(fcfgName, FileMode.Open, FileAccess.Read);

                byte[] fcfgByte = new byte[fcfgFile.Length];
                fcfgFile.Seek(0, SeekOrigin.Begin);
                fcfgFile.Read(fcfgByte, 0, (Int32)fcfgFile.Length);
                string fcfgString = Encoding.ASCII.GetString(fcfgByte);
                _fcfgPara = fcfgString.Split('\n');

                foreach (var item in _fcfgPara)
                {
                    if (item.StartsWith("par="))
                        _parFileName = item.Substring("par=".Length);
                }
                _parFileName = _parFileName.Remove(_parFileName.Length - 1);
                _parFileName = _fcfgFolder + "\\" + _parFileName.Replace("/", "\\");

                try
                {
                    FileStream parFile = new FileStream(_parFileName, FileMode.Open, FileAccess.Read);
                    byte[] parByte = new byte[parFile.Length];
                    parFile.Seek(0, SeekOrigin.Begin);
                    parFile.Read(parByte, 0, (Int32)parFile.Length);
                    string parString = Encoding.ASCII.GetString(parByte);
                    _parPara = parString.Split('\n');
                    int mark;
                    foreach (var item in _parPara)
                    {
                        if (item.StartsWith(":double\tTR,"))
                        {

                            mark = item.IndexOf(":", 1);
                            string tmpStr;
                            tmpStr = item.Remove(mark);
                            tmpStr = tmpStr.Substring(":double\tTR,".Length);
                            _TR = Double.Parse(item.Remove(mark).Substring(":double\tTR,".Length));
                            //break;
                        }
                        //if (item.StartsWith(":double\tTE,"))
                        //{
                        //    mark = item.IndexOf(":", 1);
                        //    _TE = float.Parse(item.Remove(mark).Substring(":double\tTE,".Length)) / 1000f;
                        //    break;
                        //}
                        //if (item.StartsWith(":double\trxGain,"))
                        //{
                        //    mark = item.IndexOf(":", 1);
                        //    _RxGain = float.Parse(item.Remove(mark).Substring(":double\trxGain,".Length));
                        //    break;
                        //}
                        if (item.StartsWith(":double\tnoScans,"))
                        {
                            mark = item.IndexOf(":", 1);
                            
                            _noScans = (Int32)double.Parse(item.Remove(mark).Substring(":double\tnoScans,".Length));
                            //break;
                        }
                        if (item.StartsWith(":double\tsamplePeriod,"))
                        {
                            mark = item.IndexOf(":", 1);
                            _samplePeriod = Double.Parse(item.Remove(mark).Substring(":double\tsamplePeriod,".Length));
                            //break;
                        }
                    }
                }
                catch (Exception ex)
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
            }
            tbxTR.Text = _TR.ToString();
            tbxNoSamples.Text = _noScans.ToString();
            tbxSampleBandWidth.Text = (1000000f / _samplePeriod).ToString();
        }

        getFiles fetchRawData = delegate(string rawDataFileName)
        {

            //MessageBox.Show(rawDataFileName);
            ArrayList lst;
            string[] fileNameList;
            string[] fileNameList2;
            fileNameList = rawDataFileName.Split(':');
            lst = new ArrayList(fileNameList);
            
            lst.RemoveAt(lst.Count-1);
            fileNameList2=new string[lst.Count/2];
            for (int i = 0; i < lst.Count/2; i++)
            {
                fileNameList2[i] = lst[2*i] + ":" + lst[2*i + 1];
            }
            string tmp = string.Join(";", fileNameList);
            MessageBox.Show(tmp);
            MRIData data = new MRIData(fileNameList);
        };

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            NMR.CloseSys();
        }

        private void SimpleForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            NMR.CloseSys();
        }
    }
}
