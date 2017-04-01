namespace AutoShimmming
{
    partial class SimpleForm
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
            this.lblInitFileName = new System.Windows.Forms.Label();
            this.tbxInitFileName = new System.Windows.Forms.TextBox();
            this.tbxFcfgFileName = new System.Windows.Forms.TextBox();
            this.lblFcfgFileName = new System.Windows.Forms.Label();
            this.lblTR = new System.Windows.Forms.Label();
            this.tbxTR = new System.Windows.Forms.TextBox();
            this.tbxNoSamples = new System.Windows.Forms.TextBox();
            this.lblNoSamples = new System.Windows.Forms.Label();
            this.tbxSampleBandWidth = new System.Windows.Forms.TextBox();
            this.lblSampleBandWidth = new System.Windows.Forms.Label();
            this.tbxDataFolder = new System.Windows.Forms.TextBox();
            this.lblDataFolder = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.ConnectState = new System.Windows.Forms.ToolStripStatusLabel();
            this.tbxDllVersion = new System.Windows.Forms.TextBox();
            this.lblDllVersion = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.tbxFilterFolder = new System.Windows.Forms.TextBox();
            this.lblFilterFolder = new System.Windows.Forms.Label();
            this.tbxFilterFileName = new System.Windows.Forms.TextBox();
            this.lblFilterFileName = new System.Windows.Forms.Label();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInitFileName
            // 
            this.lblInitFileName.AutoSize = true;
            this.lblInitFileName.Location = new System.Drawing.Point(13, 16);
            this.lblInitFileName.Name = "lblInitFileName";
            this.lblInitFileName.Size = new System.Drawing.Size(119, 15);
            this.lblInitFileName.TabIndex = 0;
            this.lblInitFileName.Text = "Init FileName:";
            // 
            // tbxInitFileName
            // 
            this.tbxInitFileName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbxInitFileName.Location = new System.Drawing.Point(138, 13);
            this.tbxInitFileName.Name = "tbxInitFileName";
            this.tbxInitFileName.ReadOnly = true;
            this.tbxInitFileName.Size = new System.Drawing.Size(607, 25);
            this.tbxInitFileName.TabIndex = 1;
            // 
            // tbxFcfgFileName
            // 
            this.tbxFcfgFileName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbxFcfgFileName.Location = new System.Drawing.Point(138, 48);
            this.tbxFcfgFileName.Name = "tbxFcfgFileName";
            this.tbxFcfgFileName.ReadOnly = true;
            this.tbxFcfgFileName.Size = new System.Drawing.Size(607, 25);
            this.tbxFcfgFileName.TabIndex = 3;
            // 
            // lblFcfgFileName
            // 
            this.lblFcfgFileName.AutoSize = true;
            this.lblFcfgFileName.Location = new System.Drawing.Point(13, 51);
            this.lblFcfgFileName.Name = "lblFcfgFileName";
            this.lblFcfgFileName.Size = new System.Drawing.Size(119, 15);
            this.lblFcfgFileName.TabIndex = 2;
            this.lblFcfgFileName.Text = "Fcfg FileName:";
            // 
            // lblTR
            // 
            this.lblTR.AutoSize = true;
            this.lblTR.Location = new System.Drawing.Point(16, 215);
            this.lblTR.Name = "lblTR";
            this.lblTR.Size = new System.Drawing.Size(71, 15);
            this.lblTR.TabIndex = 4;
            this.lblTR.Text = "TR (ms):";
            // 
            // tbxTR
            // 
            this.tbxTR.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbxTR.Location = new System.Drawing.Point(102, 212);
            this.tbxTR.Name = "tbxTR";
            this.tbxTR.ReadOnly = true;
            this.tbxTR.Size = new System.Drawing.Size(100, 25);
            this.tbxTR.TabIndex = 5;
            // 
            // tbxNoSamples
            // 
            this.tbxNoSamples.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbxNoSamples.Location = new System.Drawing.Point(320, 215);
            this.tbxNoSamples.Name = "tbxNoSamples";
            this.tbxNoSamples.ReadOnly = true;
            this.tbxNoSamples.Size = new System.Drawing.Size(100, 25);
            this.tbxNoSamples.TabIndex = 7;
            // 
            // lblNoSamples
            // 
            this.lblNoSamples.AutoSize = true;
            this.lblNoSamples.Location = new System.Drawing.Point(234, 218);
            this.lblNoSamples.Name = "lblNoSamples";
            this.lblNoSamples.Size = new System.Drawing.Size(87, 15);
            this.lblNoSamples.TabIndex = 6;
            this.lblNoSamples.Text = "noSamples:";
            // 
            // tbxSampleBandWidth
            // 
            this.tbxSampleBandWidth.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbxSampleBandWidth.Location = new System.Drawing.Point(645, 212);
            this.tbxSampleBandWidth.Name = "tbxSampleBandWidth";
            this.tbxSampleBandWidth.ReadOnly = true;
            this.tbxSampleBandWidth.Size = new System.Drawing.Size(100, 25);
            this.tbxSampleBandWidth.TabIndex = 9;
            // 
            // lblSampleBandWidth
            // 
            this.lblSampleBandWidth.AutoSize = true;
            this.lblSampleBandWidth.Location = new System.Drawing.Point(450, 218);
            this.lblSampleBandWidth.Name = "lblSampleBandWidth";
            this.lblSampleBandWidth.Size = new System.Drawing.Size(191, 15);
            this.lblSampleBandWidth.TabIndex = 8;
            this.lblSampleBandWidth.Text = "Sample Band Width (Hz):";
            // 
            // tbxDataFolder
            // 
            this.tbxDataFolder.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbxDataFolder.Location = new System.Drawing.Point(138, 79);
            this.tbxDataFolder.Name = "tbxDataFolder";
            this.tbxDataFolder.ReadOnly = true;
            this.tbxDataFolder.Size = new System.Drawing.Size(607, 25);
            this.tbxDataFolder.TabIndex = 11;
            // 
            // lblDataFolder
            // 
            this.lblDataFolder.AutoSize = true;
            this.lblDataFolder.Location = new System.Drawing.Point(13, 82);
            this.lblDataFolder.Name = "lblDataFolder";
            this.lblDataFolder.Size = new System.Drawing.Size(103, 15);
            this.lblDataFolder.TabIndex = 10;
            this.lblDataFolder.Text = "Data Folder:";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(30, 422);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(102, 23);
            this.btnConnect.TabIndex = 12;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConnectState});
            this.statusStrip.Location = new System.Drawing.Point(0, 471);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(757, 22);
            this.statusStrip.TabIndex = 13;
            this.statusStrip.Text = "statusStrip1";
            // 
            // ConnectState
            // 
            this.ConnectState.Name = "ConnectState";
            this.ConnectState.Size = new System.Drawing.Size(0, 17);
            // 
            // tbxDllVersion
            // 
            this.tbxDllVersion.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbxDllVersion.Location = new System.Drawing.Point(138, 142);
            this.tbxDllVersion.Name = "tbxDllVersion";
            this.tbxDllVersion.ReadOnly = true;
            this.tbxDllVersion.Size = new System.Drawing.Size(151, 25);
            this.tbxDllVersion.TabIndex = 15;
            // 
            // lblDllVersion
            // 
            this.lblDllVersion.AutoSize = true;
            this.lblDllVersion.Location = new System.Drawing.Point(13, 145);
            this.lblDllVersion.Name = "lblDllVersion";
            this.lblDllVersion.Size = new System.Drawing.Size(103, 15);
            this.lblDllVersion.TabIndex = 14;
            this.lblDllVersion.Text = "DLL Version:";
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(244, 422);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(97, 23);
            this.btnRun.TabIndex = 16;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // tbxFilterFolder
            // 
            this.tbxFilterFolder.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbxFilterFolder.Location = new System.Drawing.Point(138, 111);
            this.tbxFilterFolder.Name = "tbxFilterFolder";
            this.tbxFilterFolder.ReadOnly = true;
            this.tbxFilterFolder.Size = new System.Drawing.Size(607, 25);
            this.tbxFilterFolder.TabIndex = 18;
            // 
            // lblFilterFolder
            // 
            this.lblFilterFolder.AutoSize = true;
            this.lblFilterFolder.Location = new System.Drawing.Point(13, 114);
            this.lblFilterFolder.Name = "lblFilterFolder";
            this.lblFilterFolder.Size = new System.Drawing.Size(119, 15);
            this.lblFilterFolder.TabIndex = 17;
            this.lblFilterFolder.Text = "Filter Folder:";
            // 
            // tbxFilterFileName
            // 
            this.tbxFilterFileName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbxFilterFileName.Location = new System.Drawing.Point(138, 178);
            this.tbxFilterFileName.Name = "tbxFilterFileName";
            this.tbxFilterFileName.ReadOnly = true;
            this.tbxFilterFileName.Size = new System.Drawing.Size(607, 25);
            this.tbxFilterFileName.TabIndex = 20;
            // 
            // lblFilterFileName
            // 
            this.lblFilterFileName.AutoSize = true;
            this.lblFilterFileName.Location = new System.Drawing.Point(-3, 181);
            this.lblFilterFileName.Name = "lblFilterFileName";
            this.lblFilterFileName.Size = new System.Drawing.Size(135, 15);
            this.lblFilterFileName.TabIndex = 19;
            this.lblFilterFileName.Text = "Filter FileName:";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(138, 422);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(100, 23);
            this.btnDisconnect.TabIndex = 21;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // SimpleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 493);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.tbxFilterFileName);
            this.Controls.Add(this.lblFilterFileName);
            this.Controls.Add(this.tbxFilterFolder);
            this.Controls.Add(this.lblFilterFolder);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.tbxDllVersion);
            this.Controls.Add(this.lblDllVersion);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.tbxDataFolder);
            this.Controls.Add(this.lblDataFolder);
            this.Controls.Add(this.tbxSampleBandWidth);
            this.Controls.Add(this.lblSampleBandWidth);
            this.Controls.Add(this.tbxNoSamples);
            this.Controls.Add(this.lblNoSamples);
            this.Controls.Add(this.tbxTR);
            this.Controls.Add(this.lblTR);
            this.Controls.Add(this.tbxFcfgFileName);
            this.Controls.Add(this.lblFcfgFileName);
            this.Controls.Add(this.tbxInitFileName);
            this.Controls.Add(this.lblInitFileName);
            this.Name = "SimpleForm";
            this.Text = "Simple Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SimpleForm_FormClosing);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInitFileName;
        private System.Windows.Forms.TextBox tbxInitFileName;
        private System.Windows.Forms.TextBox tbxFcfgFileName;
        private System.Windows.Forms.Label lblFcfgFileName;
        private System.Windows.Forms.Label lblTR;
        private System.Windows.Forms.TextBox tbxTR;
        private System.Windows.Forms.TextBox tbxNoSamples;
        private System.Windows.Forms.Label lblNoSamples;
        private System.Windows.Forms.TextBox tbxSampleBandWidth;
        private System.Windows.Forms.Label lblSampleBandWidth;
        private System.Windows.Forms.TextBox tbxDataFolder;
        private System.Windows.Forms.Label lblDataFolder;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel ConnectState;
        private System.Windows.Forms.TextBox tbxDllVersion;
        private System.Windows.Forms.Label lblDllVersion;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.TextBox tbxFilterFolder;
        private System.Windows.Forms.Label lblFilterFolder;
        private System.Windows.Forms.TextBox tbxFilterFileName;
        private System.Windows.Forms.Label lblFilterFileName;
        private System.Windows.Forms.Button btnDisconnect;
    }
}

