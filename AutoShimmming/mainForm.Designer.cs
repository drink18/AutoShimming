namespace AutoShimmming
{
    partial class mainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.tbxIterationStepSize = new System.Windows.Forms.TextBox();
            this.lblIerationStepSize = new System.Windows.Forms.Label();
            this.btnNextIteration = new System.Windows.Forms.Button();
            this.tbxNoScans = new System.Windows.Forms.TextBox();
            this.lblNoScans = new System.Windows.Forms.Label();
            this.tbxDataFolder = new System.Windows.Forms.TextBox();
            this.btnDataFolder = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.tbxSampleBandWidth = new System.Windows.Forms.TextBox();
            this.lblSampleBandWidth = new System.Windows.Forms.Label();
            this.btnOpenData = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnLoadSeq = new System.Windows.Forms.Button();
            this.tbxSysFreq = new System.Windows.Forms.TextBox();
            this.lblsysFreq = new System.Windows.Forms.Label();
            this.nudGradZ = new System.Windows.Forms.NumericUpDown();
            this.nudGradY = new System.Windows.Forms.NumericUpDown();
            this.nudGradX = new System.Windows.Forms.NumericUpDown();
            this.nudFreqOffset = new System.Windows.Forms.NumericUpDown();
            this.lblGradZOffset = new System.Windows.Forms.Label();
            this.lblGradYOffset = new System.Windows.Forms.Label();
            this.lblGradXOffset = new System.Windows.Forms.Label();
            this.lblFreqOffsetTrb = new System.Windows.Forms.Label();
            this.trbShimmingZ = new System.Windows.Forms.TrackBar();
            this.trbShimmingY = new System.Windows.Forms.TrackBar();
            this.trbShimmingX = new System.Windows.Forms.TrackBar();
            this.trbFreqOffset = new System.Windows.Forms.TrackBar();
            this.tbxRxGain = new System.Windows.Forms.TextBox();
            this.lblRxGain = new System.Windows.Forms.Label();
            this.tbxTxAtt = new System.Windows.Forms.TextBox();
            this.lblTxAtt = new System.Windows.Forms.Label();
            this.tbxTE = new System.Windows.Forms.TextBox();
            this.lblTE = new System.Windows.Forms.Label();
            this.tbxTR = new System.Windows.Forms.TextBox();
            this.lblTR = new System.Windows.Forms.Label();
            this.tbxSequenceName = new System.Windows.Forms.TextBox();
            this.lblSequenceName = new System.Windows.Forms.Label();
            this.zgc = new ZedGraph.ZedGraphControl();
            this.tbxFittingLineWidth = new System.Windows.Forms.TextBox();
            this.lblFittingLineWidth = new System.Windows.Forms.Label();
            this.gbxPanMode = new System.Windows.Forms.GroupBox();
            this.rbtFreePan = new System.Windows.Forms.RadioButton();
            this.rbtVPan = new System.Windows.Forms.RadioButton();
            this.rbtHPan = new System.Windows.Forms.RadioButton();
            this.gbxZoom = new System.Windows.Forms.GroupBox();
            this.rbtFreeZoom = new System.Windows.Forms.RadioButton();
            this.rbtVZoom = new System.Windows.Forms.RadioButton();
            this.rbtHzoom = new System.Windows.Forms.RadioButton();
            this.cbxMaxMark = new System.Windows.Forms.CheckBox();
            this.tbxSampleFreq = new System.Windows.Forms.TextBox();
            this.lblSampleFrequency = new System.Windows.Forms.Label();
            this.tbxLineWidthAt = new System.Windows.Forms.TextBox();
            this.lblLineWidthAt = new System.Windows.Forms.Label();
            this.tbxMaxAt = new System.Windows.Forms.TextBox();
            this.lblMaxAt = new System.Windows.Forms.Label();
            this.gbxTdFormat = new System.Windows.Forms.GroupBox();
            this.rbtTdPhase = new System.Windows.Forms.RadioButton();
            this.rbtTdAbs = new System.Windows.Forms.RadioButton();
            this.rbtTdRealImag = new System.Windows.Forms.RadioButton();
            this.gbxSdFormat = new System.Windows.Forms.GroupBox();
            this.rbtDB = new System.Windows.Forms.RadioButton();
            this.rbtAbs = new System.Windows.Forms.RadioButton();
            this.tbxMaxAmplitude = new System.Windows.Forms.TextBox();
            this.lblMaxAmplitude = new System.Windows.Forms.Label();
            this.tbxLineWidth = new System.Windows.Forms.TextBox();
            this.lblLineWidth = new System.Windows.Forms.Label();
            this.tbxFreqOffset = new System.Windows.Forms.TextBox();
            this.lblFreqOffset = new System.Windows.Forms.Label();
            this.tbxF0 = new System.Windows.Forms.TextBox();
            this.lblF0 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbOpenData = new System.Windows.Forms.ToolStripButton();
            this.tsbResetZoom = new System.Windows.Forms.ToolStripButton();
            this.tsbHardwareInfo = new System.Windows.Forms.ToolStripButton();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGradZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGradY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGradX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFreqOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbShimmingZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbShimmingY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbShimmingX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbFreqOffset)).BeginInit();
            this.gbxPanMode.SuspendLayout();
            this.gbxZoom.SuspendLayout();
            this.gbxTdFormat.SuspendLayout();
            this.gbxSdFormat.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip.Location = new System.Drawing.Point(0, 899);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1826, 25);
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(117, 20);
            this.toolStripStatusLabel1.Text = "ConnectStatue";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 48);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tbxFittingLineWidth);
            this.splitContainer1.Panel2.Controls.Add(this.lblFittingLineWidth);
            this.splitContainer1.Panel2.Controls.Add(this.gbxPanMode);
            this.splitContainer1.Panel2.Controls.Add(this.gbxZoom);
            this.splitContainer1.Panel2.Controls.Add(this.cbxMaxMark);
            this.splitContainer1.Panel2.Controls.Add(this.tbxSampleFreq);
            this.splitContainer1.Panel2.Controls.Add(this.lblSampleFrequency);
            this.splitContainer1.Panel2.Controls.Add(this.tbxLineWidthAt);
            this.splitContainer1.Panel2.Controls.Add(this.lblLineWidthAt);
            this.splitContainer1.Panel2.Controls.Add(this.tbxMaxAt);
            this.splitContainer1.Panel2.Controls.Add(this.lblMaxAt);
            this.splitContainer1.Panel2.Controls.Add(this.gbxTdFormat);
            this.splitContainer1.Panel2.Controls.Add(this.gbxSdFormat);
            this.splitContainer1.Panel2.Controls.Add(this.tbxMaxAmplitude);
            this.splitContainer1.Panel2.Controls.Add(this.lblMaxAmplitude);
            this.splitContainer1.Panel2.Controls.Add(this.tbxLineWidth);
            this.splitContainer1.Panel2.Controls.Add(this.lblLineWidth);
            this.splitContainer1.Panel2.Controls.Add(this.tbxFreqOffset);
            this.splitContainer1.Panel2.Controls.Add(this.lblFreqOffset);
            this.splitContainer1.Panel2.Controls.Add(this.tbxF0);
            this.splitContainer1.Panel2.Controls.Add(this.lblF0);
            this.splitContainer1.Size = new System.Drawing.Size(1826, 851);
            this.splitContainer1.SplitterDistance = 726;
            this.splitContainer1.TabIndex = 4;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.btnDisplay);
            this.splitContainer2.Panel1.Controls.Add(this.tbxIterationStepSize);
            this.splitContainer2.Panel1.Controls.Add(this.lblIerationStepSize);
            this.splitContainer2.Panel1.Controls.Add(this.btnNextIteration);
            this.splitContainer2.Panel1.Controls.Add(this.tbxNoScans);
            this.splitContainer2.Panel1.Controls.Add(this.lblNoScans);
            this.splitContainer2.Panel1.Controls.Add(this.tbxDataFolder);
            this.splitContainer2.Panel1.Controls.Add(this.btnDataFolder);
            this.splitContainer2.Panel1.Controls.Add(this.btnDisconnect);
            this.splitContainer2.Panel1.Controls.Add(this.btnConnect);
            this.splitContainer2.Panel1.Controls.Add(this.tbxSampleBandWidth);
            this.splitContainer2.Panel1.Controls.Add(this.lblSampleBandWidth);
            this.splitContainer2.Panel1.Controls.Add(this.btnOpenData);
            this.splitContainer2.Panel1.Controls.Add(this.btnExit);
            this.splitContainer2.Panel1.Controls.Add(this.btnRun);
            this.splitContainer2.Panel1.Controls.Add(this.btnLoadSeq);
            this.splitContainer2.Panel1.Controls.Add(this.tbxSysFreq);
            this.splitContainer2.Panel1.Controls.Add(this.lblsysFreq);
            this.splitContainer2.Panel1.Controls.Add(this.nudGradZ);
            this.splitContainer2.Panel1.Controls.Add(this.nudGradY);
            this.splitContainer2.Panel1.Controls.Add(this.nudGradX);
            this.splitContainer2.Panel1.Controls.Add(this.nudFreqOffset);
            this.splitContainer2.Panel1.Controls.Add(this.lblGradZOffset);
            this.splitContainer2.Panel1.Controls.Add(this.lblGradYOffset);
            this.splitContainer2.Panel1.Controls.Add(this.lblGradXOffset);
            this.splitContainer2.Panel1.Controls.Add(this.lblFreqOffsetTrb);
            this.splitContainer2.Panel1.Controls.Add(this.trbShimmingZ);
            this.splitContainer2.Panel1.Controls.Add(this.trbShimmingY);
            this.splitContainer2.Panel1.Controls.Add(this.trbShimmingX);
            this.splitContainer2.Panel1.Controls.Add(this.trbFreqOffset);
            this.splitContainer2.Panel1.Controls.Add(this.tbxRxGain);
            this.splitContainer2.Panel1.Controls.Add(this.lblRxGain);
            this.splitContainer2.Panel1.Controls.Add(this.tbxTxAtt);
            this.splitContainer2.Panel1.Controls.Add(this.lblTxAtt);
            this.splitContainer2.Panel1.Controls.Add(this.tbxTE);
            this.splitContainer2.Panel1.Controls.Add(this.lblTE);
            this.splitContainer2.Panel1.Controls.Add(this.tbxTR);
            this.splitContainer2.Panel1.Controls.Add(this.lblTR);
            this.splitContainer2.Panel1.Controls.Add(this.tbxSequenceName);
            this.splitContainer2.Panel1.Controls.Add(this.lblSequenceName);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.zgc);
            this.splitContainer2.Size = new System.Drawing.Size(1822, 722);
            this.splitContainer2.SplitterDistance = 695;
            this.splitContainer2.TabIndex = 0;
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(436, 574);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(103, 23);
            this.btnDisplay.TabIndex = 40;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // tbxIterationStepSize
            // 
            this.tbxIterationStepSize.Location = new System.Drawing.Point(188, 473);
            this.tbxIterationStepSize.Name = "tbxIterationStepSize";
            this.tbxIterationStepSize.Size = new System.Drawing.Size(58, 25);
            this.tbxIterationStepSize.TabIndex = 39;
            this.tbxIterationStepSize.Text = "10";
            this.tbxIterationStepSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbxIterationStepSize.TextChanged += new System.EventHandler(this.tbxIterationStepSize_TextChanged);
            // 
            // lblIerationStepSize
            // 
            this.lblIerationStepSize.AutoSize = true;
            this.lblIerationStepSize.Location = new System.Drawing.Point(15, 476);
            this.lblIerationStepSize.Name = "lblIerationStepSize";
            this.lblIerationStepSize.Size = new System.Drawing.Size(167, 15);
            this.lblIerationStepSize.TabIndex = 38;
            this.lblIerationStepSize.Text = "Iteration Step Size:";
            // 
            // btnNextIteration
            // 
            this.btnNextIteration.Location = new System.Drawing.Point(253, 574);
            this.btnNextIteration.Name = "btnNextIteration";
            this.btnNextIteration.Size = new System.Drawing.Size(139, 23);
            this.btnNextIteration.TabIndex = 37;
            this.btnNextIteration.Text = "Next Iteration";
            this.btnNextIteration.UseVisualStyleBackColor = true;
            // 
            // tbxNoScans
            // 
            this.tbxNoScans.Location = new System.Drawing.Point(349, 140);
            this.tbxNoScans.Name = "tbxNoScans";
            this.tbxNoScans.Size = new System.Drawing.Size(100, 25);
            this.tbxNoScans.TabIndex = 36;
            // 
            // lblNoScans
            // 
            this.lblNoScans.AutoSize = true;
            this.lblNoScans.Location = new System.Drawing.Point(247, 143);
            this.lblNoScans.Name = "lblNoScans";
            this.lblNoScans.Size = new System.Drawing.Size(71, 15);
            this.lblNoScans.TabIndex = 35;
            this.lblNoScans.Text = "noScans:";
            // 
            // tbxDataFolder
            // 
            this.tbxDataFolder.Location = new System.Drawing.Point(139, 36);
            this.tbxDataFolder.Name = "tbxDataFolder";
            this.tbxDataFolder.ReadOnly = true;
            this.tbxDataFolder.Size = new System.Drawing.Size(542, 25);
            this.tbxDataFolder.TabIndex = 34;
            // 
            // btnDataFolder
            // 
            this.btnDataFolder.Location = new System.Drawing.Point(10, 34);
            this.btnDataFolder.Name = "btnDataFolder";
            this.btnDataFolder.Size = new System.Drawing.Size(122, 23);
            this.btnDataFolder.TabIndex = 33;
            this.btnDataFolder.Text = "Data Folder:";
            this.btnDataFolder.UseVisualStyleBackColor = true;
            this.btnDataFolder.Click += new System.EventHandler(this.btnDataFolder_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(436, 630);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(103, 23);
            this.btnDisconnect.TabIndex = 32;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(326, 630);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(93, 23);
            this.btnConnect.TabIndex = 31;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // tbxSampleBandWidth
            // 
            this.tbxSampleBandWidth.Location = new System.Drawing.Point(439, 103);
            this.tbxSampleBandWidth.Name = "tbxSampleBandWidth";
            this.tbxSampleBandWidth.Size = new System.Drawing.Size(100, 25);
            this.tbxSampleBandWidth.TabIndex = 30;
            // 
            // lblSampleBandWidth
            // 
            this.lblSampleBandWidth.AutoSize = true;
            this.lblSampleBandWidth.Location = new System.Drawing.Point(250, 106);
            this.lblSampleBandWidth.Name = "lblSampleBandWidth";
            this.lblSampleBandWidth.Size = new System.Drawing.Size(183, 15);
            this.lblSampleBandWidth.TabIndex = 29;
            this.lblSampleBandWidth.Text = "Sample Bandwidth (Hz):";
            // 
            // btnOpenData
            // 
            this.btnOpenData.Location = new System.Drawing.Point(563, 574);
            this.btnOpenData.Name = "btnOpenData";
            this.btnOpenData.Size = new System.Drawing.Size(94, 23);
            this.btnOpenData.TabIndex = 28;
            this.btnOpenData.Text = "Open Data";
            this.btnOpenData.UseVisualStyleBackColor = true;
            this.btnOpenData.Click += new System.EventHandler(this.btnOpenData_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(563, 630);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 23);
            this.btnExit.TabIndex = 26;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(139, 574);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(99, 23);
            this.btnRun.TabIndex = 25;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnLoadSeq
            // 
            this.btnLoadSeq.Location = new System.Drawing.Point(30, 574);
            this.btnLoadSeq.Name = "btnLoadSeq";
            this.btnLoadSeq.Size = new System.Drawing.Size(93, 23);
            this.btnLoadSeq.TabIndex = 24;
            this.btnLoadSeq.Text = "Load seq";
            this.btnLoadSeq.UseVisualStyleBackColor = true;
            this.btnLoadSeq.Click += new System.EventHandler(this.btnLoadSeq_Click);
            // 
            // tbxSysFreq
            // 
            this.tbxSysFreq.Location = new System.Drawing.Point(317, 68);
            this.tbxSysFreq.Name = "tbxSysFreq";
            this.tbxSysFreq.Size = new System.Drawing.Size(75, 25);
            this.tbxSysFreq.TabIndex = 23;
            // 
            // lblsysFreq
            // 
            this.lblsysFreq.AutoSize = true;
            this.lblsysFreq.Location = new System.Drawing.Point(240, 71);
            this.lblsysFreq.Name = "lblsysFreq";
            this.lblsysFreq.Size = new System.Drawing.Size(79, 15);
            this.lblsysFreq.TabIndex = 22;
            this.lblsysFreq.Text = "F0 (MHz):";
            this.lblsysFreq.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // nudGradZ
            // 
            this.nudGradZ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudGradZ.Location = new System.Drawing.Point(617, 398);
            this.nudGradZ.Name = "nudGradZ";
            this.nudGradZ.Size = new System.Drawing.Size(75, 25);
            this.nudGradZ.TabIndex = 21;
            this.nudGradZ.ValueChanged += new System.EventHandler(this.nudGradZ_ValueChanged);
            // 
            // nudGradY
            // 
            this.nudGradY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudGradY.Location = new System.Drawing.Point(618, 344);
            this.nudGradY.Name = "nudGradY";
            this.nudGradY.Size = new System.Drawing.Size(75, 25);
            this.nudGradY.TabIndex = 20;
            this.nudGradY.ValueChanged += new System.EventHandler(this.nudGradY_ValueChanged);
            // 
            // nudGradX
            // 
            this.nudGradX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudGradX.Location = new System.Drawing.Point(617, 292);
            this.nudGradX.Name = "nudGradX";
            this.nudGradX.Size = new System.Drawing.Size(75, 25);
            this.nudGradX.TabIndex = 19;
            this.nudGradX.ValueChanged += new System.EventHandler(this.nudGradX_ValueChanged);
            this.nudGradX.Click += new System.EventHandler(this.nudGradX_Click);
            this.nudGradX.MouseClick += new System.Windows.Forms.MouseEventHandler(this.nudGradX_MouseClick);
            this.nudGradX.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.nudGradX_PreviewKeyDown);
            // 
            // nudFreqOffset
            // 
            this.nudFreqOffset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudFreqOffset.Location = new System.Drawing.Point(618, 246);
            this.nudFreqOffset.Name = "nudFreqOffset";
            this.nudFreqOffset.Size = new System.Drawing.Size(75, 25);
            this.nudFreqOffset.TabIndex = 18;
            this.nudFreqOffset.ValueChanged += new System.EventHandler(this.nudFreqOffset_ValueChanged);
            // 
            // lblGradZOffset
            // 
            this.lblGradZOffset.AutoSize = true;
            this.lblGradZOffset.Location = new System.Drawing.Point(90, 403);
            this.lblGradZOffset.Name = "lblGradZOffset";
            this.lblGradZOffset.Size = new System.Drawing.Size(63, 15);
            this.lblGradZOffset.TabIndex = 17;
            this.lblGradZOffset.Text = "Grad Z:";
            // 
            // lblGradYOffset
            // 
            this.lblGradYOffset.AutoSize = true;
            this.lblGradYOffset.Location = new System.Drawing.Point(90, 349);
            this.lblGradYOffset.Name = "lblGradYOffset";
            this.lblGradYOffset.Size = new System.Drawing.Size(63, 15);
            this.lblGradYOffset.TabIndex = 16;
            this.lblGradYOffset.Text = "Grad Y:";
            // 
            // lblGradXOffset
            // 
            this.lblGradXOffset.AutoSize = true;
            this.lblGradXOffset.Location = new System.Drawing.Point(90, 297);
            this.lblGradXOffset.Name = "lblGradXOffset";
            this.lblGradXOffset.Size = new System.Drawing.Size(63, 15);
            this.lblGradXOffset.TabIndex = 15;
            this.lblGradXOffset.Text = "Grad X:";
            this.lblGradXOffset.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblFreqOffsetTrb
            // 
            this.lblFreqOffsetTrb.AutoSize = true;
            this.lblFreqOffsetTrb.Location = new System.Drawing.Point(10, 251);
            this.lblFreqOffsetTrb.Name = "lblFreqOffsetTrb";
            this.lblFreqOffsetTrb.Size = new System.Drawing.Size(143, 15);
            this.lblFreqOffsetTrb.TabIndex = 14;
            this.lblFreqOffsetTrb.Text = "Freq Offset (Hz):";
            // 
            // trbShimmingZ
            // 
            this.trbShimmingZ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trbShimmingZ.Location = new System.Drawing.Point(161, 382);
            this.trbShimmingZ.Maximum = 100;
            this.trbShimmingZ.Minimum = -100;
            this.trbShimmingZ.Name = "trbShimmingZ";
            this.trbShimmingZ.Size = new System.Drawing.Size(450, 56);
            this.trbShimmingZ.TabIndex = 13;
            this.trbShimmingZ.ValueChanged += new System.EventHandler(this.trbShimmingZ_ValueChanged);
            // 
            // trbShimmingY
            // 
            this.trbShimmingY.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trbShimmingY.Location = new System.Drawing.Point(161, 328);
            this.trbShimmingY.Maximum = 100;
            this.trbShimmingY.Minimum = -100;
            this.trbShimmingY.Name = "trbShimmingY";
            this.trbShimmingY.Size = new System.Drawing.Size(450, 56);
            this.trbShimmingY.TabIndex = 12;
            this.trbShimmingY.ValueChanged += new System.EventHandler(this.trbShimmingY_ValueChanged);
            // 
            // trbShimmingX
            // 
            this.trbShimmingX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trbShimmingX.Location = new System.Drawing.Point(161, 276);
            this.trbShimmingX.Maximum = 100;
            this.trbShimmingX.Minimum = -100;
            this.trbShimmingX.Name = "trbShimmingX";
            this.trbShimmingX.Size = new System.Drawing.Size(450, 56);
            this.trbShimmingX.TabIndex = 11;
            this.trbShimmingX.ValueChanged += new System.EventHandler(this.trbShimmingX_ValueChanged);
            // 
            // trbFreqOffset
            // 
            this.trbFreqOffset.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trbFreqOffset.Location = new System.Drawing.Point(161, 230);
            this.trbFreqOffset.Maximum = 100;
            this.trbFreqOffset.Minimum = -100;
            this.trbFreqOffset.Name = "trbFreqOffset";
            this.trbFreqOffset.Size = new System.Drawing.Size(450, 56);
            this.trbFreqOffset.TabIndex = 10;
            this.trbFreqOffset.ValueChanged += new System.EventHandler(this.trbFreqOffset_ValueChanged);
            // 
            // tbxRxGain
            // 
            this.tbxRxGain.Location = new System.Drawing.Point(129, 168);
            this.tbxRxGain.Name = "tbxRxGain";
            this.tbxRxGain.Size = new System.Drawing.Size(100, 25);
            this.tbxRxGain.TabIndex = 9;
            // 
            // lblRxGain
            // 
            this.lblRxGain.AutoSize = true;
            this.lblRxGain.Location = new System.Drawing.Point(12, 171);
            this.lblRxGain.Name = "lblRxGain";
            this.lblRxGain.Size = new System.Drawing.Size(111, 15);
            this.lblRxGain.TabIndex = 8;
            this.lblRxGain.Text = "RX Gain (dB):";
            // 
            // tbxTxAtt
            // 
            this.tbxTxAtt.Location = new System.Drawing.Point(129, 137);
            this.tbxTxAtt.Name = "tbxTxAtt";
            this.tbxTxAtt.Size = new System.Drawing.Size(100, 25);
            this.tbxTxAtt.TabIndex = 7;
            // 
            // lblTxAtt
            // 
            this.lblTxAtt.AutoSize = true;
            this.lblTxAtt.Location = new System.Drawing.Point(12, 140);
            this.lblTxAtt.Name = "lblTxAtt";
            this.lblTxAtt.Size = new System.Drawing.Size(103, 15);
            this.lblTxAtt.TabIndex = 6;
            this.lblTxAtt.Text = "TX Att (dB):";
            // 
            // tbxTE
            // 
            this.tbxTE.Location = new System.Drawing.Point(129, 103);
            this.tbxTE.Name = "tbxTE";
            this.tbxTE.Size = new System.Drawing.Size(100, 25);
            this.tbxTE.TabIndex = 5;
            // 
            // lblTE
            // 
            this.lblTE.AutoSize = true;
            this.lblTE.Location = new System.Drawing.Point(27, 106);
            this.lblTE.Name = "lblTE";
            this.lblTE.Size = new System.Drawing.Size(71, 15);
            this.lblTE.TabIndex = 4;
            this.lblTE.Text = "TE (ms):";
            // 
            // tbxTR
            // 
            this.tbxTR.Location = new System.Drawing.Point(129, 68);
            this.tbxTR.Name = "tbxTR";
            this.tbxTR.Size = new System.Drawing.Size(100, 25);
            this.tbxTR.TabIndex = 3;
            // 
            // lblTR
            // 
            this.lblTR.AutoSize = true;
            this.lblTR.Location = new System.Drawing.Point(27, 71);
            this.lblTR.Name = "lblTR";
            this.lblTR.Size = new System.Drawing.Size(71, 15);
            this.lblTR.TabIndex = 2;
            this.lblTR.Text = "TR (ms):";
            // 
            // tbxSequenceName
            // 
            this.tbxSequenceName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxSequenceName.Location = new System.Drawing.Point(129, 3);
            this.tbxSequenceName.Name = "tbxSequenceName";
            this.tbxSequenceName.Size = new System.Drawing.Size(552, 25);
            this.tbxSequenceName.TabIndex = 1;
            // 
            // lblSequenceName
            // 
            this.lblSequenceName.AutoSize = true;
            this.lblSequenceName.Location = new System.Drawing.Point(28, 7);
            this.lblSequenceName.Name = "lblSequenceName";
            this.lblSequenceName.Size = new System.Drawing.Size(87, 15);
            this.lblSequenceName.TabIndex = 0;
            this.lblSequenceName.Text = "Seq. Name:";
            // 
            // zgc
            // 
            this.zgc.BackColor = System.Drawing.Color.Black;
            this.zgc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zgc.Location = new System.Drawing.Point(0, 0);
            this.zgc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.zgc.Name = "zgc";
            this.zgc.ScrollGrace = 0D;
            this.zgc.ScrollMaxX = 0D;
            this.zgc.ScrollMaxY = 0D;
            this.zgc.ScrollMaxY2 = 0D;
            this.zgc.ScrollMinX = 0D;
            this.zgc.ScrollMinY = 0D;
            this.zgc.ScrollMinY2 = 0D;
            this.zgc.Size = new System.Drawing.Size(1123, 722);
            this.zgc.TabIndex = 0;
            this.zgc.ZoomEvent += new ZedGraph.ZedGraphControl.ZoomEventHandler(this.zgc_ZoomEvent);
            this.zgc.MouseMoveEvent += new ZedGraph.ZedGraphControl.ZedMouseEventHandler(this.zgc_MouseMoveEvent);
            // 
            // tbxFittingLineWidth
            // 
            this.tbxFittingLineWidth.Location = new System.Drawing.Point(604, 47);
            this.tbxFittingLineWidth.Name = "tbxFittingLineWidth";
            this.tbxFittingLineWidth.Size = new System.Drawing.Size(100, 25);
            this.tbxFittingLineWidth.TabIndex = 20;
            // 
            // lblFittingLineWidth
            // 
            this.lblFittingLineWidth.AutoSize = true;
            this.lblFittingLineWidth.Location = new System.Drawing.Point(399, 52);
            this.lblFittingLineWidth.Name = "lblFittingLineWidth";
            this.lblFittingLineWidth.Size = new System.Drawing.Size(199, 15);
            this.lblFittingLineWidth.TabIndex = 19;
            this.lblFittingLineWidth.Text = "Fitting Line Width (Hz):";
            // 
            // gbxPanMode
            // 
            this.gbxPanMode.Controls.Add(this.rbtFreePan);
            this.gbxPanMode.Controls.Add(this.rbtVPan);
            this.gbxPanMode.Controls.Add(this.rbtHPan);
            this.gbxPanMode.Location = new System.Drawing.Point(1391, 3);
            this.gbxPanMode.Name = "gbxPanMode";
            this.gbxPanMode.Size = new System.Drawing.Size(119, 86);
            this.gbxPanMode.TabIndex = 18;
            this.gbxPanMode.TabStop = false;
            this.gbxPanMode.Text = "Pan Mode:";
            // 
            // rbtFreePan
            // 
            this.rbtFreePan.AutoSize = true;
            this.rbtFreePan.Location = new System.Drawing.Point(6, 66);
            this.rbtFreePan.Name = "rbtFreePan";
            this.rbtFreePan.Size = new System.Drawing.Size(60, 19);
            this.rbtFreePan.TabIndex = 2;
            this.rbtFreePan.TabStop = true;
            this.rbtFreePan.Text = "Free";
            this.rbtFreePan.UseVisualStyleBackColor = true;
            this.rbtFreePan.CheckedChanged += new System.EventHandler(this.rbtFreePan_CheckedChanged);
            // 
            // rbtVPan
            // 
            this.rbtVPan.AutoSize = true;
            this.rbtVPan.Location = new System.Drawing.Point(6, 45);
            this.rbtVPan.Name = "rbtVPan";
            this.rbtVPan.Size = new System.Drawing.Size(92, 19);
            this.rbtVPan.TabIndex = 1;
            this.rbtVPan.TabStop = true;
            this.rbtVPan.Text = "Vertical";
            this.rbtVPan.UseVisualStyleBackColor = true;
            this.rbtVPan.CheckedChanged += new System.EventHandler(this.rbtVPan_CheckedChanged);
            // 
            // rbtHPan
            // 
            this.rbtHPan.AutoSize = true;
            this.rbtHPan.Checked = true;
            this.rbtHPan.Location = new System.Drawing.Point(6, 24);
            this.rbtHPan.Name = "rbtHPan";
            this.rbtHPan.Size = new System.Drawing.Size(108, 19);
            this.rbtHPan.TabIndex = 0;
            this.rbtHPan.TabStop = true;
            this.rbtHPan.Text = "Horizontal";
            this.rbtHPan.UseVisualStyleBackColor = true;
            this.rbtHPan.CheckedChanged += new System.EventHandler(this.rbtHPan_CheckedChanged);
            // 
            // gbxZoom
            // 
            this.gbxZoom.Controls.Add(this.rbtFreeZoom);
            this.gbxZoom.Controls.Add(this.rbtVZoom);
            this.gbxZoom.Controls.Add(this.rbtHzoom);
            this.gbxZoom.Location = new System.Drawing.Point(1266, 3);
            this.gbxZoom.Name = "gbxZoom";
            this.gbxZoom.Size = new System.Drawing.Size(119, 86);
            this.gbxZoom.TabIndex = 17;
            this.gbxZoom.TabStop = false;
            this.gbxZoom.Text = "Zoom Mode:";
            // 
            // rbtFreeZoom
            // 
            this.rbtFreeZoom.AutoSize = true;
            this.rbtFreeZoom.Location = new System.Drawing.Point(6, 66);
            this.rbtFreeZoom.Name = "rbtFreeZoom";
            this.rbtFreeZoom.Size = new System.Drawing.Size(60, 19);
            this.rbtFreeZoom.TabIndex = 2;
            this.rbtFreeZoom.TabStop = true;
            this.rbtFreeZoom.Text = "Free";
            this.rbtFreeZoom.UseVisualStyleBackColor = true;
            this.rbtFreeZoom.CheckedChanged += new System.EventHandler(this.rbtFreeZoom_CheckedChanged);
            // 
            // rbtVZoom
            // 
            this.rbtVZoom.AutoSize = true;
            this.rbtVZoom.Location = new System.Drawing.Point(6, 45);
            this.rbtVZoom.Name = "rbtVZoom";
            this.rbtVZoom.Size = new System.Drawing.Size(92, 19);
            this.rbtVZoom.TabIndex = 1;
            this.rbtVZoom.TabStop = true;
            this.rbtVZoom.Text = "Vertical";
            this.rbtVZoom.UseVisualStyleBackColor = true;
            this.rbtVZoom.CheckedChanged += new System.EventHandler(this.rbtVZoom_CheckedChanged);
            // 
            // rbtHzoom
            // 
            this.rbtHzoom.AutoSize = true;
            this.rbtHzoom.Checked = true;
            this.rbtHzoom.Location = new System.Drawing.Point(6, 24);
            this.rbtHzoom.Name = "rbtHzoom";
            this.rbtHzoom.Size = new System.Drawing.Size(108, 19);
            this.rbtHzoom.TabIndex = 0;
            this.rbtHzoom.TabStop = true;
            this.rbtHzoom.Text = "Horizontal";
            this.rbtHzoom.UseVisualStyleBackColor = true;
            // 
            // cbxMaxMark
            // 
            this.cbxMaxMark.AutoSize = true;
            this.cbxMaxMark.Location = new System.Drawing.Point(1142, 13);
            this.cbxMaxMark.Name = "cbxMaxMark";
            this.cbxMaxMark.Size = new System.Drawing.Size(117, 19);
            this.cbxMaxMark.TabIndex = 16;
            this.cbxMaxMark.Text = "Mark at Max";
            this.cbxMaxMark.UseVisualStyleBackColor = true;
            // 
            // tbxSampleFreq
            // 
            this.tbxSampleFreq.Location = new System.Drawing.Point(95, 53);
            this.tbxSampleFreq.Name = "tbxSampleFreq";
            this.tbxSampleFreq.Size = new System.Drawing.Size(100, 25);
            this.tbxSampleFreq.TabIndex = 15;
            // 
            // lblSampleFrequency
            // 
            this.lblSampleFrequency.AutoSize = true;
            this.lblSampleFrequency.Location = new System.Drawing.Point(10, 56);
            this.lblSampleFrequency.Name = "lblSampleFrequency";
            this.lblSampleFrequency.Size = new System.Drawing.Size(71, 15);
            this.lblSampleFrequency.TabIndex = 14;
            this.lblSampleFrequency.Text = "Fs (Hz):";
            // 
            // tbxLineWidthAt
            // 
            this.tbxLineWidthAt.Location = new System.Drawing.Point(1023, 11);
            this.tbxLineWidthAt.Name = "tbxLineWidthAt";
            this.tbxLineWidthAt.Size = new System.Drawing.Size(100, 25);
            this.tbxLineWidthAt.TabIndex = 13;
            // 
            // lblLineWidthAt
            // 
            this.lblLineWidthAt.AutoSize = true;
            this.lblLineWidthAt.Location = new System.Drawing.Point(901, 16);
            this.lblLineWidthAt.Name = "lblLineWidthAt";
            this.lblLineWidthAt.Size = new System.Drawing.Size(119, 15);
            this.lblLineWidthAt.TabIndex = 12;
            this.lblLineWidthAt.Text = "Line Width at:";
            // 
            // tbxMaxAt
            // 
            this.tbxMaxAt.Location = new System.Drawing.Point(795, 47);
            this.tbxMaxAt.Name = "tbxMaxAt";
            this.tbxMaxAt.Size = new System.Drawing.Size(100, 25);
            this.tbxMaxAt.TabIndex = 11;
            // 
            // lblMaxAt
            // 
            this.lblMaxAt.AutoSize = true;
            this.lblMaxAt.Location = new System.Drawing.Point(710, 51);
            this.lblMaxAt.Name = "lblMaxAt";
            this.lblMaxAt.Size = new System.Drawing.Size(63, 15);
            this.lblMaxAt.TabIndex = 10;
            this.lblMaxAt.Text = "Max at:";
            // 
            // gbxTdFormat
            // 
            this.gbxTdFormat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxTdFormat.Controls.Add(this.rbtTdPhase);
            this.gbxTdFormat.Controls.Add(this.rbtTdAbs);
            this.gbxTdFormat.Controls.Add(this.rbtTdRealImag);
            this.gbxTdFormat.Location = new System.Drawing.Point(1568, 5);
            this.gbxTdFormat.Name = "gbxTdFormat";
            this.gbxTdFormat.Size = new System.Drawing.Size(128, 86);
            this.gbxTdFormat.TabIndex = 9;
            this.gbxTdFormat.TabStop = false;
            this.gbxTdFormat.Text = "TD Format:";
            // 
            // rbtTdPhase
            // 
            this.rbtTdPhase.AutoSize = true;
            this.rbtTdPhase.Location = new System.Drawing.Point(19, 67);
            this.rbtTdPhase.Name = "rbtTdPhase";
            this.rbtTdPhase.Size = new System.Drawing.Size(68, 19);
            this.rbtTdPhase.TabIndex = 2;
            this.rbtTdPhase.Text = "Phase";
            this.rbtTdPhase.UseVisualStyleBackColor = true;
            // 
            // rbtTdAbs
            // 
            this.rbtTdAbs.AutoSize = true;
            this.rbtTdAbs.Location = new System.Drawing.Point(19, 44);
            this.rbtTdAbs.Name = "rbtTdAbs";
            this.rbtTdAbs.Size = new System.Drawing.Size(52, 19);
            this.rbtTdAbs.TabIndex = 1;
            this.rbtTdAbs.Text = "Abs";
            this.rbtTdAbs.UseVisualStyleBackColor = true;
            // 
            // rbtTdRealImag
            // 
            this.rbtTdRealImag.AutoSize = true;
            this.rbtTdRealImag.Checked = true;
            this.rbtTdRealImag.Location = new System.Drawing.Point(19, 19);
            this.rbtTdRealImag.Name = "rbtTdRealImag";
            this.rbtTdRealImag.Size = new System.Drawing.Size(100, 19);
            this.rbtTdRealImag.TabIndex = 0;
            this.rbtTdRealImag.TabStop = true;
            this.rbtTdRealImag.Text = "Real/Imag";
            this.rbtTdRealImag.UseVisualStyleBackColor = true;
            // 
            // gbxSdFormat
            // 
            this.gbxSdFormat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxSdFormat.Controls.Add(this.rbtDB);
            this.gbxSdFormat.Controls.Add(this.rbtAbs);
            this.gbxSdFormat.Location = new System.Drawing.Point(1702, 3);
            this.gbxSdFormat.Name = "gbxSdFormat";
            this.gbxSdFormat.Size = new System.Drawing.Size(110, 78);
            this.gbxSdFormat.TabIndex = 8;
            this.gbxSdFormat.TabStop = false;
            this.gbxSdFormat.Text = "SD Format:";
            // 
            // rbtDB
            // 
            this.rbtDB.AutoSize = true;
            this.rbtDB.Location = new System.Drawing.Point(7, 53);
            this.rbtDB.Name = "rbtDB";
            this.rbtDB.Size = new System.Drawing.Size(44, 19);
            this.rbtDB.TabIndex = 1;
            this.rbtDB.TabStop = true;
            this.rbtDB.Text = "dB";
            this.rbtDB.UseVisualStyleBackColor = true;
            // 
            // rbtAbs
            // 
            this.rbtAbs.AutoSize = true;
            this.rbtAbs.Checked = true;
            this.rbtAbs.Location = new System.Drawing.Point(7, 25);
            this.rbtAbs.Name = "rbtAbs";
            this.rbtAbs.Size = new System.Drawing.Size(52, 19);
            this.rbtAbs.TabIndex = 0;
            this.rbtAbs.TabStop = true;
            this.rbtAbs.Text = "Abs";
            this.rbtAbs.UseVisualStyleBackColor = true;
            // 
            // tbxMaxAmplitude
            // 
            this.tbxMaxAmplitude.Location = new System.Drawing.Point(795, 12);
            this.tbxMaxAmplitude.Name = "tbxMaxAmplitude";
            this.tbxMaxAmplitude.Size = new System.Drawing.Size(100, 25);
            this.tbxMaxAmplitude.TabIndex = 7;
            // 
            // lblMaxAmplitude
            // 
            this.lblMaxAmplitude.AutoSize = true;
            this.lblMaxAmplitude.Location = new System.Drawing.Point(710, 16);
            this.lblMaxAmplitude.Name = "lblMaxAmplitude";
            this.lblMaxAmplitude.Size = new System.Drawing.Size(79, 15);
            this.lblMaxAmplitude.TabIndex = 6;
            this.lblMaxAmplitude.Text = "Max Ampl:";
            // 
            // tbxLineWidth
            // 
            this.tbxLineWidth.Location = new System.Drawing.Point(604, 13);
            this.tbxLineWidth.Name = "tbxLineWidth";
            this.tbxLineWidth.Size = new System.Drawing.Size(100, 25);
            this.tbxLineWidth.TabIndex = 5;
            // 
            // lblLineWidth
            // 
            this.lblLineWidth.AutoSize = true;
            this.lblLineWidth.Location = new System.Drawing.Point(455, 16);
            this.lblLineWidth.Name = "lblLineWidth";
            this.lblLineWidth.Size = new System.Drawing.Size(143, 15);
            this.lblLineWidth.TabIndex = 4;
            this.lblLineWidth.Text = "Spect Width (Hz):";
            // 
            // tbxFreqOffset
            // 
            this.tbxFreqOffset.Location = new System.Drawing.Point(349, 12);
            this.tbxFreqOffset.Name = "tbxFreqOffset";
            this.tbxFreqOffset.Size = new System.Drawing.Size(100, 25);
            this.tbxFreqOffset.TabIndex = 3;
            // 
            // lblFreqOffset
            // 
            this.lblFreqOffset.AutoSize = true;
            this.lblFreqOffset.Location = new System.Drawing.Point(203, 16);
            this.lblFreqOffset.Name = "lblFreqOffset";
            this.lblFreqOffset.Size = new System.Drawing.Size(143, 15);
            this.lblFreqOffset.TabIndex = 2;
            this.lblFreqOffset.Text = "Freq Offset (Hz):";
            // 
            // tbxF0
            // 
            this.tbxF0.Location = new System.Drawing.Point(97, 11);
            this.tbxF0.Name = "tbxF0";
            this.tbxF0.Size = new System.Drawing.Size(100, 25);
            this.tbxF0.TabIndex = 1;
            // 
            // lblF0
            // 
            this.lblF0.AutoSize = true;
            this.lblF0.Location = new System.Drawing.Point(12, 14);
            this.lblF0.Name = "lblF0";
            this.lblF0.Size = new System.Drawing.Size(79, 15);
            this.lblF0.TabIndex = 0;
            this.lblF0.Text = "F0 (MHz):";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbOpenData,
            this.tsbResetZoom,
            this.tsbHardwareInfo});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1826, 48);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbOpenData
            // 
            this.tsbOpenData.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbOpenData.Image = ((System.Drawing.Image)(resources.GetObject("tsbOpenData.Image")));
            this.tsbOpenData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOpenData.Name = "tsbOpenData";
            this.tsbOpenData.Size = new System.Drawing.Size(52, 45);
            this.tsbOpenData.Text = "toolStripButton1";
            this.tsbOpenData.ToolTipText = "Open local MRI raw data";
            this.tsbOpenData.Click += new System.EventHandler(this.btnOpenData_Click);
            // 
            // tsbResetZoom
            // 
            this.tsbResetZoom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbResetZoom.Image = ((System.Drawing.Image)(resources.GetObject("tsbResetZoom.Image")));
            this.tsbResetZoom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbResetZoom.Name = "tsbResetZoom";
            this.tsbResetZoom.Size = new System.Drawing.Size(52, 45);
            this.tsbResetZoom.Text = "toolStripButton2";
            this.tsbResetZoom.ToolTipText = "Reset Graph Zoom";
            this.tsbResetZoom.Click += new System.EventHandler(this.toolZoomPanReset_Click);
            // 
            // tsbHardwareInfo
            // 
            this.tsbHardwareInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbHardwareInfo.Image = ((System.Drawing.Image)(resources.GetObject("tsbHardwareInfo.Image")));
            this.tsbHardwareInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbHardwareInfo.Name = "tsbHardwareInfo";
            this.tsbHardwareInfo.Size = new System.Drawing.Size(52, 45);
            this.tsbHardwareInfo.Text = "toolStripButton3";
            this.tsbHardwareInfo.ToolTipText = "查看谱仪硬件信息";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1826, 924);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "mainForm";
            this.Text = "Auto Shimming";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudGradZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGradY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGradX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFreqOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbShimmingZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbShimmingY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbShimmingX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbFreqOffset)).EndInit();
            this.gbxPanMode.ResumeLayout(false);
            this.gbxPanMode.PerformLayout();
            this.gbxZoom.ResumeLayout(false);
            this.gbxZoom.PerformLayout();
            this.gbxTdFormat.ResumeLayout(false);
            this.gbxTdFormat.PerformLayout();
            this.gbxSdFormat.ResumeLayout(false);
            this.gbxSdFormat.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox gbxSdFormat;
        private System.Windows.Forms.RadioButton rbtDB;
        private System.Windows.Forms.RadioButton rbtAbs;
        private System.Windows.Forms.TextBox tbxMaxAmplitude;
        private System.Windows.Forms.Label lblMaxAmplitude;
        private System.Windows.Forms.TextBox tbxLineWidth;
        private System.Windows.Forms.Label lblLineWidth;
        private System.Windows.Forms.TextBox tbxFreqOffset;
        private System.Windows.Forms.Label lblFreqOffset;
        private System.Windows.Forms.TextBox tbxF0;
        private System.Windows.Forms.Label lblF0;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnLoadSeq;
        private System.Windows.Forms.TextBox tbxSysFreq;
        private System.Windows.Forms.Label lblsysFreq;
        private System.Windows.Forms.NumericUpDown nudGradZ;
        private System.Windows.Forms.NumericUpDown nudGradY;
        private System.Windows.Forms.NumericUpDown nudGradX;
        private System.Windows.Forms.NumericUpDown nudFreqOffset;
        private System.Windows.Forms.Label lblGradZOffset;
        private System.Windows.Forms.Label lblGradYOffset;
        private System.Windows.Forms.Label lblGradXOffset;
        private System.Windows.Forms.Label lblFreqOffsetTrb;
        private System.Windows.Forms.TrackBar trbShimmingZ;
        private System.Windows.Forms.TrackBar trbShimmingY;
        private System.Windows.Forms.TrackBar trbShimmingX;
        private System.Windows.Forms.TrackBar trbFreqOffset;
        private System.Windows.Forms.TextBox tbxRxGain;
        private System.Windows.Forms.Label lblRxGain;
        private System.Windows.Forms.TextBox tbxTxAtt;
        private System.Windows.Forms.Label lblTxAtt;
        private System.Windows.Forms.TextBox tbxTE;
        private System.Windows.Forms.Label lblTE;
        private System.Windows.Forms.TextBox tbxTR;
        private System.Windows.Forms.Label lblTR;
        private System.Windows.Forms.TextBox tbxSequenceName;
        private System.Windows.Forms.Label lblSequenceName;
        private ZedGraph.ZedGraphControl zgc;
        private System.Windows.Forms.GroupBox gbxTdFormat;
        private System.Windows.Forms.RadioButton rbtTdPhase;
        private System.Windows.Forms.RadioButton rbtTdAbs;
        private System.Windows.Forms.RadioButton rbtTdRealImag;
        private System.Windows.Forms.Button btnOpenData;
        private System.Windows.Forms.TextBox tbxMaxAt;
        private System.Windows.Forms.Label lblMaxAt;
        private System.Windows.Forms.TextBox tbxLineWidthAt;
        private System.Windows.Forms.Label lblLineWidthAt;
        private System.Windows.Forms.TextBox tbxSampleFreq;
        private System.Windows.Forms.Label lblSampleFrequency;
        private System.Windows.Forms.CheckBox cbxMaxMark;
        private System.Windows.Forms.GroupBox gbxZoom;
        private System.Windows.Forms.RadioButton rbtFreeZoom;
        private System.Windows.Forms.RadioButton rbtVZoom;
        private System.Windows.Forms.RadioButton rbtHzoom;
        private System.Windows.Forms.GroupBox gbxPanMode;
        private System.Windows.Forms.RadioButton rbtFreePan;
        private System.Windows.Forms.RadioButton rbtVPan;
        private System.Windows.Forms.RadioButton rbtHPan;
        public System.Windows.Forms.TextBox tbxSampleBandWidth;
        private System.Windows.Forms.Label lblSampleBandWidth;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.TextBox tbxDataFolder;
        private System.Windows.Forms.Button btnDataFolder;
        private System.Windows.Forms.TextBox tbxNoScans;
        private System.Windows.Forms.Label lblNoScans;
        private System.Windows.Forms.TextBox tbxIterationStepSize;
        private System.Windows.Forms.Label lblIerationStepSize;
        private System.Windows.Forms.Button btnNextIteration;
        private System.Windows.Forms.TextBox tbxFittingLineWidth;
        private System.Windows.Forms.Label lblFittingLineWidth;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.ToolStripButton tsbOpenData;
        private System.Windows.Forms.ToolStripButton tsbResetZoom;
        private System.Windows.Forms.ToolStripButton tsbHardwareInfo;
        //private System.Windows.Forms.ToolStrip toolStrip1;
    }
}

