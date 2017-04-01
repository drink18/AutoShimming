using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ZedGraph;
using FFTWSharp;
using System.Numerics;
using System.Runtime.InteropServices;
using MRILibrary;
using System.Collections;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using MathNet.Numerics.LinearAlgebra.Double;



namespace AutoShimmming
{
    public delegate void getFiles(string fileNameString);
    //public delegate void getFiles(object sender, string fileNameString);
    public struct LineShape
    {
        public double max;
        public int maxPos;
        public double lineWidth;
        public double lineWidthAt;
    }



    public delegate void MRIDataReadyEventHandler(object sender, MRIDataReadyEventArgs e);

    public partial class mainForm : Form
    {
        string _fcfgDir;
        public static string initFileName = @"C:\mri_20160903\dll\hw_cfg\init.ini";
        //private event MRIDataReadyEventHandler mriDataReadyEventHandler;
        public static event MRIDataReadyEventHandler OnMRIDataReady;
        //{
        //    add
        //    {
        //        this.mriDataReadyEventHandler += value;
        //    }
        //    remove
        //    {
        //        this.mriDataReadyEventHandler -= value;
        //    }
        //}

        

        #region 字段与属性
            BackgroundWorker bgwConnect;
            BackgroundWorker bgwAcquiringData;
            //#region DataReady
            //bool dataReady;

            //public bool DataReady
            //{
            //    get { return dataReady; }
            //    set {
            //        if (dataReady != value)
            //        {
            //            dataReady = value;
            //            this.ProcessData(DataFileList);
            //        }
            //    }
            //}
            //#endregion
            #region Connect Status
            ConnectStatus _connect;

            public ConnectStatus Connect
            {
                get { return _connect; }
                set
                {
                    if (this._connect != value)
                    {
                        _connect = value;
                        WhenConnectStatusChanged();
                    }


                }
            }

            #endregion
            #region fcfg Parameters
        string[] _fcfgPara;
        public string[] FcfgPara
        {
            get { return _fcfgPara; }
        }
        #endregion
            #region Scan Parameters
            string[] _parPara;
            public string[] ParPara
            {
                get { return _parPara; }
            }
            #endregion
            #region ConfigFileName
            string _configFileName;

            public string ConfigFileName
            {
                get { return _configFileName; }
                //set { _configFileName = value; }
            }
            #endregion
            #region Parameter File Name
            string _parFileName;
            public string ParFileName
            {
                get { return _parFileName; }
            }
            #endregion
            #region ShimmingFileName
            string _shimmingFileName;

            public string ShimmingFileName
            {
                get { return _shimmingFileName; }
                //set { _shimmingFileName = value; }
            }
            #endregion
            #region FrequencyFileName
            string _frequencyFileName;

            public string FrequencyFileName
            {
                get { return _frequencyFileName; }
                //set { _frequencyFileName = value; }
            }
            #endregion
            #region FilterFolder
            string _filterFolder;

            public string FilterFolder
            {
                get { return _filterFolder; }
                set { _filterFolder = value; }
            }
            #endregion
            #region FilterFileName
            string _filterFileName;

            public string FilterFileName
            {
                get { return _filterFileName; }
                set { _filterFileName = value; }
            }
            #endregion
            #region DataFileList
            static string[] _dataFileList;

            public static string[] DataFileList
            {
                get { return _dataFileList; }
                set { _dataFileList = value; }
            }
            #endregion
            #region MyRegion
            string[] _staticDataFileList;
            #endregion
            #region ShimmingXRang
            Int32 _shimmingXRang;

            public Int32 ShimmingXRang
            {
                get { return _shimmingXRang; }
                //set { _shimmingXRang = value; }
            }
            #endregion
            #region ShimmingYRang
            Int32 _shimmingYRang;

            public Int32 ShimmingYRang
            {
                get { return _shimmingYRang; }
                //set { _shimmingYRang = value; }
            }
            #endregion
            #region ShimmingZRang
            Int32 _shimmingZRang;

            public Int32 ShimmingZRang
            {
                get { return _shimmingZRang; }
                //set { _shimmingZRang = value; }
            }
            #endregion
            #region FreqOffsetRange
            double _FreqOffsetRange;

            public double FreqOffsetRange
            {
                get { return _FreqOffsetRange; }
                //set { _FreqOffsetRange = value; }
            }
            #endregion
            #region TR
            double _TR;

            public double TR
            {
                get { return _TR; }
                set { _TR = value; }
            }


            #endregion
            #region TE
            double _TE;

            public double TE
            {
                get { return _TE; }
                set { _TE = value; }
            }


            #endregion
            #region SampleBandWidth in Hz
            static double _sampleBandWidth;

            public static double SampleBandWidth
            {
                get { return _sampleBandWidth; }
                set { _sampleBandWidth = value; }
            }

            #endregion
            #region SamplePeriod
            double _samplePeriod;

            public double SamplePeriod
            {
                get { return _samplePeriod; }
                set { _samplePeriod = value; }
            }
            #endregion
            #region NoScans
            Int32 _noScans;

            public Int32 NoScans
            {
                get { return _noScans; }
                set { _noScans = value; }
            }
            #endregion
            #region TX Att
            double _TxAtt;

            public double TxAtt
            {
                get { return _TxAtt; }
            }
            #endregion
            #region RX Gain
            double _RxGain;

            public double RxGain
            {
                get { return _RxGain; }
                set { _RxGain = value; }
            }

            #endregion
            #region Seq Name
            string _seqName;

            public string SeqName
            {
                get { return _seqName; }
            }

            #endregion
            #region System Frequence
            double _F0;

            public double F0
            {
                get { return _F0; }
            }

            #endregion
            #region Freq Offset
            double _freqOffset;

            public double FreqOffset
            {
                get { return _freqOffset; }
                set { _freqOffset = value; }
            }


            #endregion
            #region Grad X Offset
            float _gradXOffset;

            public float GradXOffset
            {
                get { return _gradXOffset; }
            }
            #endregion
            #region Grad Y Offset
            float _gradYOffset;

            public float GradYOffset
            {
                get { return _gradYOffset; }
            }
            #endregion
            #region Grad Z Offset
            float _gradZOffset;

            public float GradZOffset
            {
                get { return _gradZOffset; }
            }
            #endregion
            #region ShimMaster
            MasterPane shimMaster;

            public MasterPane ShimMaster
            {
                get { return shimMaster; }
                set { shimMaster = value; }
            }
            #endregion
            #region TdPane
            GraphPane tdPane;

            public GraphPane TdPane
            {
                get { return tdPane; }
                set { tdPane = value; }
            }
            #endregion
            #region SdPane
            GraphPane sdPane;

            public GraphPane SdPane
            {
                get { return sdPane; }
                set { sdPane = value; }
            }
            #endregion
            #region mriData
            public MRIData mriData;

            //public MRIData mriData
            //{
            //    get { return _mriData; }
            //    set { _mriData = value; }
            //}
            #endregion
            #region SeqFileName
            string _seqFileName;
            public string SeqFileName
            {
                get { return _seqFileName; }

            }
            #endregion
            #region FCodeFileName
            string _fcodeFileName;

            public string FCodeFileName
            {
                get { return _fcodeFileName; }
            }
            #endregion
        /// <summary>
        /// 保存磁共振原始数据的文件夹名称
        /// </summary>
            #region DataFolder
            string _dataFolder;

            public string DataFolder
            {
                get { return _dataFolder; }
                //set { _dataFolder = value; }
            }
            #endregion
        #endregion



        public event connectStatusChanged OnConnectStatusChanged;

        public void WhenConnectStatusChanged()
        {
            if (OnConnectStatusChanged != null)
            {
                OnConnectStatusChanged(this, null);
            }
        }

        
/// <summary>
/// 主界面构造函数
/// </summary>
        public mainForm()
        {
            InitializeComponent();
            this.OnConnectStatusChanged += new connectStatusChanged(mainForm_OnConnectStatusChanged);
            //OnMRIDataReady += new MRIDataReadyEventHandler(mainForm_OnMRIDataReady);
            CheckForIllegalCrossThreadCalls = false;
            _frequencyFileName = @"C:\mri_20160903\dll\hw_cfg\fre.hw";
            _shimmingFileName = @"C:\mri_20160903\dll\hw_cfg\shimming.txt";
            FilterFolder = @"C:\mri_20160903\dll\hw_cfg\filter";
            _shimmingXRang = 5000;
            _shimmingYRang = 5000;
            _shimmingZRang = 5000;
            _FreqOffsetRange = 10000;
            _dataFolder = @"D:\tmpRaw";
            Connect = ConnectStatus.NotConnected;
            
            initComp();

            
            updateUI();
            UpdateShimmingParameters();
            initBgw();
            SetZoomPanMode();
            NMR.RegisterImageP(fetchRawData);
            NMR.SetVerboseLevel(1);
            //btnConnect.Enabled = false;
            Int32 tmp;
            tmp = NMR.SetOutputFile(_dataFolder);
            NMR.SetOutputPrefix("test");
            //connectScope();
            //Connect = ConnectStatus.Connecting;
            //Connect = ConnectStatus.NotConnected;
            //statusStrip.Items[0].Text = "Connecting...";
            //NMR nmr = new NMR();

        }

        private static void mainForm_OnMRIDataReady(object sender, MRIDataReadyEventArgs e)
        {
            //throw new NotImplementedException();
            //MessageBox.Show(e.FileNameList[0].ToString());
            //ProcessData(e.FileNameList);

        }


        private void initBgw()
        {
            this.bgwConnect = new BackgroundWorker();
            bgwConnect.DoWork +=
                new DoWorkEventHandler(bgwConnect_DoWork);
            bgwConnect.RunWorkerCompleted +=
                new RunWorkerCompletedEventHandler(
            bgwConnect_RunWorkerCompleted);
            //bgwConnect.ProgressChanged +=
            //    new ProgressChangedEventHandler(
            //bgwConnect_ProgressChanged);
            this.bgwAcquiringData = new BackgroundWorker();
            bgwAcquiringData.DoWork += new DoWorkEventHandler(bgwAcquiringData_DoWork);
            bgwAcquiringData.RunWorkerCompleted += 
                new RunWorkerCompletedEventHandler(bgwAcquiringData_RunWorkerCompleted);
        }

        private void bgwAcquiringData_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //ProcessData();
        }

        private void bgwAcquiringData_DoWork(object sender, DoWorkEventArgs e)
        {
            ////MessageBox.Show("acquiring data...");
            //int tmp;
            //tmp=NMR.Run();
            //if (tmp == 1)
            //{
            //    MessageBox.Show("Acquiring Data Failed!");
            //}
            //while (NMR.ScanCompleted() != 2)
            //{
            //    Thread.Sleep(100);
            //}
            ////if (tmp == 1)
            ////{
            ////    MessageBox.Show("Acquiring Data Failed!");
            ////}
        }

        private void bgwConnect_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
            }
            else
            {
                if ((int)e.Result == 0)
                {
                    Connect = ConnectStatus.Connected;
                }
                else
                {
                    Connect = ConnectStatus.NotConnected;
                }
            }
        }

        private void bgwConnect_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            int tmp;
            tmp=NMR.Init(initFileName);
            if (tmp == 0)
            {
                NMR.SetConfigure(initFileName);
                
            }
            //MessageBox.Show("connect= "+tmp.ToString());
            e.Result = tmp;
        }

        private void mainForm_OnConnectStatusChanged(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            //MessageBox.Show("connect Statue changed");
            if (Connect == ConnectStatus.NotConnected)
            {
                statusStrip.Items[0].Text = "Disconneted.";
                btnConnect.Enabled = true;
                btnDisconnect.Enabled = false;
                btnLoadSeq.Enabled = false;
                btnRun.Enabled = true;
                btnNextIteration.Enabled = false;
            }
            else if (Connect == ConnectStatus.Connecting)
            {
                statusStrip.Items[0].Text = "Conneting...";
                btnConnect.Enabled = false;
                btnDisconnect.Enabled = false;
                btnLoadSeq.Enabled = false;
                btnRun.Enabled = false;
                btnNextIteration.Enabled = false;
            }
            else
            {
                statusStrip.Items[0].Text = "Connected.";
                btnConnect.Enabled = false;
                btnDisconnect.Enabled = true;
                btnLoadSeq.Enabled = true;
                btnRun.Enabled = true;
                btnNextIteration.Enabled = true;
            }
        }

        private void UpdateShimmingParameters()
        {
            //throw new NotImplementedException();
            string line;
            StreamReader frequencyRd = new StreamReader(_frequencyFileName);
            line = frequencyRd.ReadLine();
            _F0 = double.Parse(line.Trim());
            frequencyRd.Dispose();

            StreamReader shimParaRd = new StreamReader(_shimmingFileName);

            while ((line = shimParaRd.ReadLine()) != null)
            {
                if (line.StartsWith("X="))
                {
                    trbShimmingX.Value = Int32.Parse(line.Replace("X=", "").Trim());
                    nudGradX.Value = trbShimmingX.Value;
                }
                if (line.StartsWith("Y="))
                {
                    trbShimmingY.Value = Int32.Parse(line.Replace("Y=", "").Trim());
                    nudGradY.Value = trbShimmingY.Value;
                }
                if (line.StartsWith("Z="))
                {
                    trbShimmingZ.Value = Int32.Parse(line.Replace("Z=", "").Trim());
                    nudGradZ.Value = trbShimmingZ.Value;
                }
            }
            shimParaRd.Dispose();

        }

        private void CallbackConect(IAsyncResult iar)
        {
            //throw new NotImplementedException();
            AsyncResult ar = (AsyncResult)iar;
            Func<string, int> func = (Func<string, int>)ar.AsyncDelegate;
            Int32 result = func.EndInvoke(iar);
            if (result == 1)
            {
                Connect = ConnectStatus.NotConnected;
                btnConnect.Enabled = true;
                statusStrip.Items[0].Text = "Connected failed!";
            }
            else
            {
                Connect = ConnectStatus.Connected;
                btnConnect.Enabled = false;
                statusStrip.Items[0].Text = "Connected done!";
                if (NMR.ConfigFile(initFileName) == null)
                {
                    MessageBox.Show("Set Config File Failed!");
                };
            }
        }

        private void initComp()
        {
            shimMaster = zgc.MasterPane;
            zgc.IsEnableHZoom = true;
            zgc.IsEnableVZoom = false;
            //zgc.PanButtons = MouseButtons.Right;
            //zgc.PanModifierKeys = Keys.None;
            zgc.IsEnableVPan = false;
            shimMaster.Title.Text = "Auto Shimming";
            shimMaster.Title.FontSpec.Size = 6;
            shimMaster.Title.IsVisible = true;
            shimMaster.PaneList.Clear();
            shimMaster.Margin.All = 5;
            shimMaster.InnerPaneGap = 5;
            tdPane = new GraphPane(new Rectangle(40, 40, 500, 250), "Time Domain",
                "Time", "My Y Axis");
            tdPane.Title.FontSpec.Size = 12;
            tdPane.XAxis.MajorGrid.IsVisible = true;
            tdPane.XAxis.MajorGrid.Color = Color.Wheat;
            tdPane.XAxis.MajorGrid.DashOff = 0;
            tdPane.YAxis.MajorGrid.IsVisible = true;
            tdPane.YAxis.MajorGrid.Color = Color.Wheat;
            tdPane.YAxis.MajorGrid.DashOff = 0;
            tdPane.XAxis.Title.FontSpec.Size = 12;
            tdPane.YAxis.Title.FontSpec.Size = 12;
            sdPane = new GraphPane(new Rectangle(40, 40, 500, 250), "Spectrum Domain",
                "Frequency", "My Y Axis");
            sdPane.Title.FontSpec.Size = 12;
            sdPane.XAxis.MajorGrid.IsVisible = true;
            sdPane.XAxis.MajorGrid.Color = Color.Wheat;
            sdPane.XAxis.MajorGrid.DashOff = 0;
            sdPane.YAxis.MajorGrid.IsVisible = true;
            sdPane.YAxis.MajorGrid.Color = Color.Wheat;
            sdPane.YAxis.MajorGrid.DashOff = 0;
            sdPane.XAxis.Title.FontSpec.Size = 12;
            sdPane.YAxis.Title.FontSpec.Size = 12;
            shimMaster.Add(tdPane);
            shimMaster.Add(sdPane);
            Graphics g = zgc.CreateGraphics();
            shimMaster.SetLayout(g, PaneLayout.SingleColumn);
            g.Dispose();
            tdPane.Chart.Fill.Type = FillType.Solid;
            tdPane.Chart.Fill.Color = Color.Black;
            sdPane.Chart.Fill.Type = FillType.Solid;
            sdPane.Chart.Fill.Color = Color.Black;

            trbFreqOffset.Maximum = (Int32)_FreqOffsetRange;
            trbFreqOffset.Minimum = (Int32)(-_FreqOffsetRange);
            trbShimmingX.Maximum = _shimmingXRang;
            trbShimmingX.Minimum = -_shimmingXRang;
            trbShimmingY.Maximum = _shimmingYRang;
            trbShimmingY.Minimum = -_shimmingYRang;
            trbShimmingZ.Maximum = _shimmingZRang;
            trbShimmingZ.Minimum = -_shimmingZRang;
            nudGradX.Maximum = _shimmingXRang;
            nudGradX.Minimum = -_shimmingXRang;
            nudGradX.Increment = decimal.Parse(tbxIterationStepSize.Text);
            nudGradY.Maximum = _shimmingYRang;
            nudGradY.Minimum = -_shimmingYRang;
            nudGradY.Increment = decimal.Parse(tbxIterationStepSize.Text);
            nudGradZ.Maximum = _shimmingZRang;
            nudGradZ.Minimum = -_shimmingZRang;
            nudGradZ.Increment = decimal.Parse(tbxIterationStepSize.Text);
            nudFreqOffset.Maximum = (Int32)_FreqOffsetRange;
            nudFreqOffset.Minimum= -(Int32)_FreqOffsetRange;
            //tbxDataFolder.Text = _dataFolder;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void tbtOpenSeq_Click(object sender, EventArgs e)
        {
            //OpenFileDialog fcfgFd = new OpenFileDialog();
            //fcfgFd.Filter = "(*.fcfg)|*.fcfg";
            //if (fcfgFd.ShowDialog() == DialogResult.OK)
            //{
            //    _configFileName = fcfgFd.FileName;
            //    tbxSequenceName.Text = fcfgFd.FileName.Substring(0, fcfgFd.FileName.LastIndexOf("."));
            //    _fcfgDir = Path.GetDirectoryName(fcfgFd.FileName);
            //    parsingSeqPara(fcfgFd.FileName);
            //}
        }

        public float[] fft1f_real(float[] data_in, fftw_direction direction)
        {
            int fftLength = data_in.Length;
            float[] data_in_cplx = new float[fftLength * 2];
            float[] data_out_cplx = new float[fftLength * 2];
            IntPtr pin, pout;
            IntPtr fplan;
            for (int i = 0; i < fftLength; i++)
            {
                data_in_cplx[2 * i] = data_in[i];
                data_in_cplx[2 * i + 1] = 0;
            }
            pin = fftwf.malloc(fftLength * 8);
            pout = fftwf.malloc(fftLength * 8);
            Marshal.Copy(data_in_cplx, 0, pin, 2 * fftLength);
            fplan = fftwf.dft_1d(fftLength, pin, pout, direction, fftw_flags.Estimate);
            fftwf.execute(fplan);
            Marshal.Copy(pout, data_out_cplx, 0, 2 * fftLength);
            fftwf.destroy_plan(fplan);
            fftwf.free(pin);
            fftwf.free(pout);
            return data_out_cplx;
        }

        public double[] fft1d_real(double[] data_in, fftw_direction direction)
        {
            int fftLength = data_in.Length;
            double[] data_in_cplx = new double[fftLength * 2];
            double[] data_out_cplx = new double[fftLength * 2];
            IntPtr pin, pout;
            IntPtr fplan;
            for (int i = 0; i < fftLength; i++)
            {
                data_in_cplx[2 * i] = data_in[i];
                data_in_cplx[2 * i + 1] = 0;
            }
            pin = fftw.malloc(fftLength * 2 * 8);
            pout = fftw.malloc(fftLength * 2 * 8);
            Marshal.Copy(data_in_cplx, 0, pin, 2 * fftLength);
            fplan = fftw.dft_1d(fftLength, pin, pout, direction, fftw_flags.Estimate);
            fftw.execute(fplan);
            Marshal.Copy(pout, data_out_cplx, 0, 2 * fftLength);
            fftw.destroy_plan(fplan);
            fftw.free(pin);
            fftw.free(pout);
            return data_out_cplx;
        }

        public double[] fft1d_comp(double[] data_in_real, double[] data_in_imag,
            fftw_direction direction)
        {
            int fftLength = data_in_real.Length;
            double[] data_in_cplx = new double[fftLength * 2];
            double[] data_out_cplx = new double[fftLength * 2];
            IntPtr pin, pout;
            IntPtr fplan;
            for (int i = 0; i < fftLength; i++)
            {
                data_in_cplx[2 * i] = data_in_real[i];
                data_in_cplx[2 * i + 1] = data_in_imag[i];
            }
            pin = fftw.malloc(fftLength * 2 * 8);
            pout = fftw.malloc(fftLength * 2 * 8);
            Marshal.Copy(data_in_cplx, 0, pin, 2 * fftLength);
            fplan = fftw.dft_1d(fftLength, pin, pout, direction, fftw_flags.Estimate);
            fftw.execute(fplan);
            Marshal.Copy(pout, data_out_cplx, 0, 2 * fftLength);
            fftw.destroy_plan(fplan);
            fftw.free(pin);
            fftw.free(pout);
            return data_out_cplx;
        }

        private void parsingSeqPara(string fcfgName)
        {
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
                _parFileName = _fcfgDir + "\\" + _parFileName.Replace("/", "\\");

                try
                {
                    FileStream parFile = new FileStream(_parFileName, FileMode.Open, FileAccess.Read);
                    byte[] parByte = new byte[parFile.Length];
                    parFile.Seek(0, SeekOrigin.Begin);
                    parFile.Read(parByte, 0, (Int32)parFile.Length);
                    string parString = Encoding.ASCII.GetString(parByte);
                    _parPara = parString.Split('\n');
                    foreach (var item in _parPara)
                    {
                        string tmpStr;
                        tmpStr = ExtractSequenceParameter(item, ":double\tTR,");
                        if (tmpStr != null)
                        {
                            TR = double.Parse(tmpStr);
                            break;
                        }
                        tmpStr = ExtractSequenceParameter(item, ":double\tTE,");
                        if (tmpStr != null)
                        {
                            TE = double.Parse(tmpStr);
                            break;
                        }
                        tmpStr = ExtractSequenceParameter(item, ":double\trxGain,");
                        if (tmpStr != null)
                        {
                            RxGain = double.Parse(tmpStr);
                            break;
                        }
                        tmpStr = ExtractSequenceParameter(item, ":double\tnoScans,");
                        if (tmpStr != null)
                        {
                            NoScans = Int32.Parse(tmpStr);
                            break;
                        }
                        tmpStr = ExtractSequenceParameter(item, ":double\ttx_freq_offset_data,");
                        if (tmpStr != null)
                        {
                            NoScans = Int32.Parse(tmpStr);
                            break;
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
            tbxTE.Text = _TE.ToString();
            tbxRxGain.Text = _RxGain.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTestData_Click(object sender, EventArgs e)
        {
            float freqSampling = 50e6f;
            float freqSignal1 = 12e6f;
            float freqSignal2 = 11e6f;
            int len_signal = 1024;
            double[] signal = new double[len_signal];
            double[] t = new double[len_signal];
            for (int i = 0; i < len_signal; i++)
            {
                signal[i] = Math.Sin(2 * Math.PI * i * freqSignal1 / freqSampling)
                    + Math.Sin(2 * Math.PI * i * freqSignal2 / freqSampling);
                t[i] = i / freqSampling;
            }

            //updateDisplay(signal, null, freqSampling);

        }

        //public void DataChanged(object sender, DataChangeEventArgs args)
        //{
        //    int slice = args.Slice;
        //    int scan = args.Scan;
        //    int echo = args.Echo;
        //    int average = args.Average;
        //    LineShape lineShape;
        //    updateDisplay(mriData.getAViewReal(),
        //        mriData.getAViewImag(),
        //        mriData.getAViewSpectrumAbs(),
        //        mriData.SampleFreq);
        //    lineShape = getLineShape(mriData.getAViewSpectrumAbs(), 0.5);
        //    tbxMaxAmplitude.Text = lineShape.max.ToString("e2");
        //    double FreqMax = (lineShape.maxPos - mriData.NoSamples / 2) * mriData.SampleFreq / mriData.NoSamples;
        //    tbxMaxAt.Text = FreqMax.ToString("f2");
        //}

        private void btnOpenData_Click(object sender, EventArgs e)
        {
            double[] fittingResult=new double[3];
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = tbxDataFolder.Text;
            ofd.Filter = "MRI Raw Data|*.raw";
            LineShape lineShape;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string[] fnames = new string[1];
                fnames[0] = ofd.FileName;
                ProcessData(fnames);
                //MRIData mriData = new MRIData(fnames);
                //tbxF0.Text = mriData.SysFreq.ToString();
                //tbxSampleFreq.Text = mriData.SampleFreq.ToString();
                //updateDisplay(mriData.getAViewReal(),
                //    mriData.getAViewImag(),
                //    mriData.getAViewSpectrumAbs(),
                //    mriData.SampleFreq);
                //lineShape = getLineShape(mriData.getAViewSpectrumAbs(), 0.5);
                //tbxMaxAmplitude.Text = lineShape.max.ToString("e2");
                //double FreqMax = (lineShape.maxPos - mriData.NoSamples / 2) * mriData.SampleFreq / mriData.NoSamples;
                //tbxMaxAt.Text = FreqMax.ToString("f2");
                //tbxLineWidth.Text = (lineShape.lineWidth * mriData.SampleFreq / mriData.NoSamples).ToString("f2");
                //tbxLineWidthAt.Text = lineShape.lineWidthAt.ToString("e2");
                //fittingResult = DoGaussianFitting(mriData.getAViewSpectrumAbs(),1.05);
                //tbxFittingLineWidth.Text = Math.Sqrt(fittingResult[2]).ToString("f2");
            }
        }

        void saveDataToFile(string fileName, double[] data)
        {
            StreamWriter sw = new StreamWriter(fileName);
            foreach (var item in data)
            {
                sw.Write(item.ToString() + "\r\n");
            }
            sw.Dispose();
        }

        private void btnLoadSeq_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgSeqFile = new OpenFileDialog();
            dlgSeqFile.InitialDirectory = @"D:\seq\application_sequences";
            dlgSeqFile.Filter = "Seq File|*.fcfg";
            if (dlgSeqFile.ShowDialog() == DialogResult.OK)
            {
                _seqFileName = dlgSeqFile.SafeFileName;
                _configFileName = dlgSeqFile.FileName;
                string line;
                ArrayList lines = new ArrayList();
                StreamReader seqFile = new StreamReader(dlgSeqFile.FileName);
                while ((line = seqFile.ReadLine()) != null)
                {
                    line = line.Trim();
                    if (line[0] != '#')
                    {
                        lines.Add(line);
                    }
                }
                Console.WriteLine("Path=" + dlgSeqFile.InitialDirectory);
                foreach (string item in lines)
                {
                    if (item.StartsWith("par="))
                    {
                        _parFileName = item.TrimStart('p', 'a', 'r', '=').Replace('/', '\\');
                        Console.WriteLine("Parameter File Name= " + _parFileName);
                    }
                    else if (item.StartsWith("fpga="))
                    {
                        _fcodeFileName = item.TrimStart('f', 'p', 'g', 'a', '=');
                        Console.WriteLine("FPGA Code File= " + _fcodeFileName);
                    }
                }
                parsingParameterFile(dlgSeqFile.InitialDirectory + "\\" + ParFileName);

    ///设置接收滤波器
    ///
                FilterFileName = searchFilter(SamplePeriod);
                updateUI();
            }
        }

        private void toolZoomPanReset_Click(object sender, EventArgs e)
        {
            if (sdPane.ZoomStack.IsEmpty == false)
            {
                sdPane.ZoomStack[0].ApplyState(sdPane);
            }
            if (tdPane.ZoomStack.IsEmpty == false)
            {
                tdPane.ZoomStack[0].ApplyState(tdPane);
            }
            sdPane.AxisChange();
            zgc.Invalidate();

        }

        private void zgc_ZoomEvent(ZedGraphControl sender, ZoomState oldState, ZoomState newState)
        {
            //int cnt = sdPane.ZoomStack.Count;
            //MessageBox.Show( sdPane.XAxis.Scale.Max.ToString());
            //MessageBox.Show(cnt.ToString());

        }

        private void rbtHzoom_CheckedChanged(object sender, EventArgs e)
        {
            SetZoomPanMode();
        }

        private void rbtVZoom_CheckedChanged(object sender, EventArgs e)
        {
            SetZoomPanMode();
        }

        private void rbtFreeZoom_CheckedChanged(object sender, EventArgs e)
        {
            SetZoomPanMode();
        }

        private void rbtHPan_CheckedChanged(object sender, EventArgs e)
        {
            SetZoomPanMode();
        }

        private void rbtVPan_CheckedChanged(object sender, EventArgs e)
        {
            SetZoomPanMode();
        }

        private void rbtFreePan_CheckedChanged(object sender, EventArgs e)
        {
            SetZoomPanMode();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            LineShape lineShape;
            NMR.SetConfigure(_configFileName);
            NMR.SetFilter(FilterFileName);
            float rxFreq = float.Parse(tbxSysFreq.Text)
                + ((float)trbFreqOffset.Value) / 1e6f;
            NMR.SetRxCenterFre(boxType.M, boardType.RX1, Channel.C1, rxFreq, true);
            float shimX = (float)nudGradX.Value;
            float shimY = (float)nudGradY.Value;
            float shimZ = (float)nudGradZ.Value;
            NMR.SetChannelValue(shimChannel.CHANNEL_X, shimX);
            NMR.SetChannelValue(shimChannel.CHANNEL_Y, shimY);
            NMR.SetChannelValue(shimChannel.CHANNEL_Z, shimZ);

            //bgwAcquiringData.RunWorkerAsync();
            //DataReady = false;
            NMR.Run();
            while (NMR.ScanCompleted() != 2)
            {
                Thread.Sleep(100);
            }
            //mriData = new MRIData(DataFileList);
            //ProcessData(DataFileList);
           
            
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            Connect = ConnectStatus.Connecting;
            bgwConnect.RunWorkerAsync();
        }

        private void btnDataFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlgDataPath = new FolderBrowserDialog();
            if (_dataFolder != null)
            {
                dlgDataPath.SelectedPath = Path.GetDirectoryName(_dataFolder);
            }
            if (dlgDataPath.ShowDialog() == DialogResult.OK)
            {
                _dataFolder = dlgDataPath.SelectedPath;
            }
            tbxDataFolder.Text = _dataFolder;
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            NMR.CloseSys();
            Connect = ConnectStatus.NotConnected;
            btnConnect.Enabled = true;
            btnDisconnect.Enabled = false;
        }

        private void trbFreqOffset_ValueChanged(object sender, EventArgs e)
        {
            nudFreqOffset.Value = trbFreqOffset.Value;
        }

        private void nudFreqOffset_ValueChanged(object sender, EventArgs e)
        {
            trbFreqOffset.Value = (int)nudFreqOffset.Value;
        }

        private void trbShimmingX_ValueChanged(object sender, EventArgs e)
        {
            nudGradX.Value = trbShimmingX.Value;
        }

        private void trbShimmingY_ValueChanged(object sender, EventArgs e)
        {
            nudGradY.Value = trbShimmingY.Value;
        }

        private void trbShimmingZ_ValueChanged(object sender, EventArgs e)
        {
            nudGradZ.Value = trbShimmingZ.Value;
        }

        private void nudGradX_ValueChanged(object sender, EventArgs e)
        {
            trbShimmingX.Value =(int) nudGradX.Value;
        }

        private void nudGradY_ValueChanged(object sender, EventArgs e)
        {
            trbShimmingY.Value = (int)nudGradY.Value;
        }

        private void nudGradZ_ValueChanged(object sender, EventArgs e)
        {
            trbShimmingZ.Value = (int)nudGradZ.Value;
        }

        private void nudGradX_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void nudGradX_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            
        }

        private void nudGradX_Click(object sender, EventArgs e)
        {
            
        }

        private void tbxIterationStepSize_TextChanged(object sender, EventArgs e)
        {
            nudGradX.Increment = decimal.Parse(((TextBox)sender).Text);
            nudGradY.Increment = decimal.Parse(((TextBox)sender).Text);
            nudGradZ.Increment = decimal.Parse(((TextBox)sender).Text);
        }


        //public static Func<string, Int32> ConnectToSprectrum = NMR.Init;

        

        public  void updateDisplay(double[] dataReal, double[] dataImag, double[] spectrumAbs, double freqSampling)
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
            //mainForm frm = new mainForm();
            tdPane.CurveList.Clear();
            LineItem tdCurve;

            if (dataImag == null)
            {
                tdCurve = tdPane.AddCurve("", t, dataReal, Color.FromArgb(0, 255, 0));
                tdCurve.Symbol.Size = 5;
                tdCurve.Symbol.Type = SymbolType.Circle;
            }
            else
            {
                tdCurve = tdPane.AddCurve("", t, dataReal, Color.FromArgb(0, 255, 0));
                tdCurve.Symbol.Size = 5;
                tdCurve.Symbol.Type = SymbolType.Circle;
                tdCurve = tdPane.AddCurve("", t, dataImag, Color.FromArgb(255, 0, 0));
                tdCurve.Symbol.Size = 5;
                tdCurve.Symbol.Type = SymbolType.Circle;
            }
            //tdCurve.Symbol.Size = 3;
            //tdCurve.Symbol.Type = SymbolType.Circle;
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
            //if (Connect == ConnectStatus.NotConnected)
            //{
            //    Connect = ConnectStatus.Connecting;
            //    btnConnect.Enabled = false;
            //    statusStrip.Items[0].Text = "Connecting...";
            //    //int tmp;
            //    //MessageBox.Show("Before init");
            //    //tmp=NMR.Init(initFileName);
            //    //MessageBox.Show("Init=" + tmp.ToString());
            //    int tmp;
            //    ConnectToSprectrum.BeginInvoke(initFileName, CallbackConect, null);
            //    if (tmp == 1)
            //    {
            //        statusStrip.Items[0].Text = "NotConnect.";
            //        Connect = ConnectStatus.NotConnected;
            //    }
            //    else
            //    {
            //        statusStrip.Items[0].Text = "Connected.";
            //        Connect = ConnectStatus.Connected;
            //    }
            //    //MessageBox.Show(tmp.ToString());
            //    //ConnectToSprectrum.BeginInvoke(initFileName, CallbackConect, null);
            //    //int tmp;
            //    tmp = ConnectToSprectrum.EndInvoke(null);

            //}

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
        public  LineShape getLineShape(double[] data, double lineWidthAtPercent)
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

        /// <summary>
        /// NMR接口的回调函数,raw文件存储完成后由NMR调用,返回值是表示文件名的字符串
        /// </summary>
        /// 
        #region fetchRawData
        getFiles fetchRawData = delegate(string rawDataFileName)
        {
            //MessageBox.Show(rawDataFileName);
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
            
            DataFileList = fileNameList2;
            mainForm frm = new mainForm();
            frm.ProcessData(DataFileList);
           
        };

        private static void fetchData(string[] s)
        {
            //mainForm mform=new mainForm();
            //MRIDataReadyEventArgs e=new MRIDataReadyEventArgs(s);
            ////e.FileNameList = s;
            //if(OnMRIDataReady!=null)
            //{
            //    mainForm_OnMRIDataReady(mform, e);
            //}
        }

        
        #endregion
        public void frm_MRIDataReady(object sender, MRIDataReadyEventArgs e)
        {
            //mainForm frm = new mainForm();
            //frm.ProcessData(e.FileNameList);
        }

        public  void ProcessData(string[] _dataFileList)
        {
            LineShape lineShape;
            //mainForm frm = new mainForm();
            mriData = new MRIData(_dataFileList);
            //MessageBox.Show(frm.mriData.GetHashCode().ToString());
            double[] dataReal = new double[mriData.DataNumber];
            double[] dataImag = new double[mriData.DataNumber];
            double[] dataSpectrumAbs = new double[mriData.DataNumber];
            dataReal = mriData.getAViewReal();
            dataImag = mriData.getAViewImag();
            dataSpectrumAbs = mriData.getAViewSpectrumAbs();
            //mainForm frm = new mainForm();
            updateDisplay(dataReal, dataImag, dataSpectrumAbs, mriData.SampleFreq);
            lineShape = getLineShape(dataSpectrumAbs, 0.5);

            tbxMaxAmplitude.Text = lineShape.max.ToString("e2");
            double FreqMax = (lineShape.maxPos - mriData.NoSamples / 2) * mriData.SampleFreq / mriData.NoSamples;
            tbxMaxAt.Text = FreqMax.ToString("f2");
            tbxLineWidth.Text = (lineShape.lineWidth * mriData.SampleFreq / mriData.NoSamples).ToString("f2");
            tbxLineWidthAt.Text = lineShape.lineWidthAt.ToString("e2");
            tdPane.AxisChange();
            Refresh();
        }

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
            tbxDataFolder.Text = _dataFolder;
            //statusStrip.Items[0].Text = "Not connect.";
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

        /// <summary>
        /// 提取序列参数。第一个参数是.par文件中的一行，第二个参数是待提取参数的特征字符串
        /// 返回值是提取的参数值，格式为字符串
        /// </summary>
        /// <param name="parameterString"></param>
        /// <param name="preString"></param>
        /// <returns></returns>
        public string ExtractSequenceParameter(string parameterString, string preString)
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

        /// <summary>
        /// 对采集的数据进行高斯拟合
        /// 输入参数fittingData为Double型数组，threshold为Double型的阈值
        /// 该函数仅对大于数据平均值乘以阈值的数据进行处理。threshold通常取1.05
        /// 返回值为Double型数组，依次对应高斯函数的a、b、c
        /// </summary>
        /// <param name="fittingData"></param>
        /// <param name="threshold"></param>
        /// <returns></returns>
        private double[] DoGaussianFitting(double[] fittingData, double threshold)
        {
            int len = fittingData.Length;
            double mean = fittingData.Average();
            double maxi = fittingData.Max();
            int iFirst = 0;
            int iLast = 0; ;

            for (int i = 0; i < fittingData.Length; i++)
            {
                if (fittingData[i] > threshold * mean)
                {
                    iFirst = i;
                    break;
                }
            }
            for (int i = fittingData.Length - 1; i > 0; i--)
            {
                if (fittingData[i] > 1.05 * mean)
                {
                    iLast = i;
                    break;
                }
            }
            double[] subData = new double[iLast - iFirst + 1];
            //double[] Y = new double[iLast - iFirst + 1];
            for (int i = 0; i < subData.Length; i++)
            {
                subData[i] = fittingData[iFirst + i];
            }
            var X = new DenseMatrix(subData.Length, 3);
            var Y = new DenseMatrix(subData.Length, 1);
            //mb.Dense(subData.Length,3);
            for (int i = 0; i < subData.Length; i++)
            {
                X[i, 0] = 1;
                X[i, 1] = iFirst + i;
                X[i, 2] = X[i, 1] * X[i, 1];
                Y[i, 0] = Math.Log(subData[i]);
            }
            var XX = X.Transpose() * X;
            var XXInv = XX.Inverse();
            var B = XXInv * X.Transpose() * Y;
            double a = Math.Exp(B[0, 0] - B[1, 0] * B[1, 0] / B[2, 0] / 4);
            double b = -B[1, 0] / B[2, 0] / 2;
            double c = -1 / B[2, 0];
            double[] coef = { a, b, c };

            return coef;
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            ProcessData(DataFileList);
        }

        private bool zgc_MouseMoveEvent(ZedGraphControl sender, MouseEventArgs e)
        {
            //if(sender.==true)

            //MessageBox.Show(e.Location.ToString());
            return false;
        }

    }

    public class MRIDataReadyEventArgs : EventArgs
    {
        public MRIDataReadyEventArgs(string[] s)
        {
            _fileNameList = s;
        }
        private string[] _fileNameList;
        public string[] FileNameList
        {
            get { return _fileNameList; }
            //set { _fileNameList = value; }
        }
    }

}

