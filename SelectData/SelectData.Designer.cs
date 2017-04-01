namespace SelectData
{
    partial class SelectDataForm
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
            this.nudSlice = new System.Windows.Forms.NumericUpDown();
            this.lblSlice = new System.Windows.Forms.Label();
            this.lblScan = new System.Windows.Forms.Label();
            this.nudScan = new System.Windows.Forms.NumericUpDown();
            this.lblEcho = new System.Windows.Forms.Label();
            this.nudEcho = new System.Windows.Forms.NumericUpDown();
            this.lblAverage = new System.Windows.Forms.Label();
            this.nudAverage = new System.Windows.Forms.NumericUpDown();
            this.lblSysFreq = new System.Windows.Forms.Label();
            this.tbxSysFreq = new System.Windows.Forms.TextBox();
            this.lblTR = new System.Windows.Forms.Label();
            this.tbxTR = new System.Windows.Forms.TextBox();
            this.lblNoSlices = new System.Windows.Forms.Label();
            this.tbxNoSlices = new System.Windows.Forms.TextBox();
            this.lblNoScans = new System.Windows.Forms.Label();
            this.tbxNoScans = new System.Windows.Forms.TextBox();
            this.tbxNoEchoes = new System.Windows.Forms.TextBox();
            this.lblNoEchoes = new System.Windows.Forms.Label();
            this.tbxNoAverages = new System.Windows.Forms.TextBox();
            this.lblNoAverages = new System.Windows.Forms.Label();
            this.tbxSamplePeriod = new System.Windows.Forms.TextBox();
            this.lblSamplePeriod = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudSlice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEcho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAverage)).BeginInit();
            this.SuspendLayout();
            // 
            // nudSlice
            // 
            this.nudSlice.Location = new System.Drawing.Point(132, 338);
            this.nudSlice.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudSlice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSlice.Name = "nudSlice";
            this.nudSlice.Size = new System.Drawing.Size(62, 25);
            this.nudSlice.TabIndex = 0;
            this.nudSlice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblSlice
            // 
            this.lblSlice.AutoSize = true;
            this.lblSlice.Location = new System.Drawing.Point(71, 340);
            this.lblSlice.Name = "lblSlice";
            this.lblSlice.Size = new System.Drawing.Size(55, 15);
            this.lblSlice.TabIndex = 1;
            this.lblSlice.Text = "Slice:";
            // 
            // lblScan
            // 
            this.lblScan.AutoSize = true;
            this.lblScan.Location = new System.Drawing.Point(218, 340);
            this.lblScan.Name = "lblScan";
            this.lblScan.Size = new System.Drawing.Size(47, 15);
            this.lblScan.TabIndex = 2;
            this.lblScan.Text = "Scan:";
            // 
            // nudScan
            // 
            this.nudScan.Location = new System.Drawing.Point(271, 338);
            this.nudScan.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.nudScan.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudScan.Name = "nudScan";
            this.nudScan.Size = new System.Drawing.Size(73, 25);
            this.nudScan.TabIndex = 3;
            this.nudScan.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblEcho
            // 
            this.lblEcho.AutoSize = true;
            this.lblEcho.Location = new System.Drawing.Point(373, 347);
            this.lblEcho.Name = "lblEcho";
            this.lblEcho.Size = new System.Drawing.Size(47, 15);
            this.lblEcho.TabIndex = 4;
            this.lblEcho.Text = "Echo:";
            // 
            // nudEcho
            // 
            this.nudEcho.Location = new System.Drawing.Point(427, 337);
            this.nudEcho.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudEcho.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudEcho.Name = "nudEcho";
            this.nudEcho.Size = new System.Drawing.Size(69, 25);
            this.nudEcho.TabIndex = 5;
            this.nudEcho.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Location = new System.Drawing.Point(521, 340);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(71, 15);
            this.lblAverage.TabIndex = 6;
            this.lblAverage.Text = "Average:";
            // 
            // nudAverage
            // 
            this.nudAverage.Location = new System.Drawing.Point(612, 340);
            this.nudAverage.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudAverage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAverage.Name = "nudAverage";
            this.nudAverage.Size = new System.Drawing.Size(65, 25);
            this.nudAverage.TabIndex = 7;
            this.nudAverage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblSysFreq
            // 
            this.lblSysFreq.AutoSize = true;
            this.lblSysFreq.Location = new System.Drawing.Point(47, 26);
            this.lblSysFreq.Name = "lblSysFreq";
            this.lblSysFreq.Size = new System.Drawing.Size(127, 15);
            this.lblSysFreq.TabIndex = 8;
            this.lblSysFreq.Text = "Sys Freq (MHz):";
            // 
            // tbxSysFreq
            // 
            this.tbxSysFreq.Location = new System.Drawing.Point(180, 23);
            this.tbxSysFreq.Name = "tbxSysFreq";
            this.tbxSysFreq.Size = new System.Drawing.Size(84, 25);
            this.tbxSysFreq.TabIndex = 9;
            // 
            // lblTR
            // 
            this.lblTR.AutoSize = true;
            this.lblTR.Location = new System.Drawing.Point(292, 26);
            this.lblTR.Name = "lblTR";
            this.lblTR.Size = new System.Drawing.Size(71, 15);
            this.lblTR.TabIndex = 10;
            this.lblTR.Text = "TR (ms):";
            // 
            // tbxTR
            // 
            this.tbxTR.Location = new System.Drawing.Point(370, 26);
            this.tbxTR.Name = "tbxTR";
            this.tbxTR.Size = new System.Drawing.Size(78, 25);
            this.tbxTR.TabIndex = 11;
            // 
            // lblNoSlices
            // 
            this.lblNoSlices.AutoSize = true;
            this.lblNoSlices.Location = new System.Drawing.Point(50, 68);
            this.lblNoSlices.Name = "lblNoSlices";
            this.lblNoSlices.Size = new System.Drawing.Size(79, 15);
            this.lblNoSlices.TabIndex = 12;
            this.lblNoSlices.Text = "noSlices:";
            // 
            // tbxNoSlices
            // 
            this.tbxNoSlices.Location = new System.Drawing.Point(181, 58);
            this.tbxNoSlices.Name = "tbxNoSlices";
            this.tbxNoSlices.Size = new System.Drawing.Size(84, 25);
            this.tbxNoSlices.TabIndex = 13;
            // 
            // lblNoScans
            // 
            this.lblNoScans.AutoSize = true;
            this.lblNoScans.Location = new System.Drawing.Point(287, 71);
            this.lblNoScans.Name = "lblNoScans";
            this.lblNoScans.Size = new System.Drawing.Size(71, 15);
            this.lblNoScans.TabIndex = 14;
            this.lblNoScans.Text = "noScans:";
            // 
            // tbxNoScans
            // 
            this.tbxNoScans.Location = new System.Drawing.Point(370, 61);
            this.tbxNoScans.Name = "tbxNoScans";
            this.tbxNoScans.Size = new System.Drawing.Size(84, 25);
            this.tbxNoScans.TabIndex = 15;
            // 
            // tbxNoEchoes
            // 
            this.tbxNoEchoes.Location = new System.Drawing.Point(545, 64);
            this.tbxNoEchoes.Name = "tbxNoEchoes";
            this.tbxNoEchoes.Size = new System.Drawing.Size(84, 25);
            this.tbxNoEchoes.TabIndex = 17;
            // 
            // lblNoEchoes
            // 
            this.lblNoEchoes.AutoSize = true;
            this.lblNoEchoes.Location = new System.Drawing.Point(472, 74);
            this.lblNoEchoes.Name = "lblNoEchoes";
            this.lblNoEchoes.Size = new System.Drawing.Size(79, 15);
            this.lblNoEchoes.TabIndex = 16;
            this.lblNoEchoes.Text = "noEchoes:";
            // 
            // tbxNoAverages
            // 
            this.tbxNoAverages.Location = new System.Drawing.Point(724, 68);
            this.tbxNoAverages.Name = "tbxNoAverages";
            this.tbxNoAverages.Size = new System.Drawing.Size(84, 25);
            this.tbxNoAverages.TabIndex = 19;
            // 
            // lblNoAverages
            // 
            this.lblNoAverages.AutoSize = true;
            this.lblNoAverages.Location = new System.Drawing.Point(644, 77);
            this.lblNoAverages.Name = "lblNoAverages";
            this.lblNoAverages.Size = new System.Drawing.Size(95, 15);
            this.lblNoAverages.TabIndex = 18;
            this.lblNoAverages.Text = "noAverages:";
            // 
            // tbxSamplePeriod
            // 
            this.tbxSamplePeriod.Location = new System.Drawing.Point(180, 100);
            this.tbxSamplePeriod.Name = "tbxSamplePeriod";
            this.tbxSamplePeriod.Size = new System.Drawing.Size(84, 25);
            this.tbxSamplePeriod.TabIndex = 21;
            // 
            // lblSamplePeriod
            // 
            this.lblSamplePeriod.AutoSize = true;
            this.lblSamplePeriod.Location = new System.Drawing.Point(15, 110);
            this.lblSamplePeriod.Name = "lblSamplePeriod";
            this.lblSamplePeriod.Size = new System.Drawing.Size(159, 15);
            this.lblSamplePeriod.TabIndex = 20;
            this.lblSamplePeriod.Text = "Sample Period (us):";
            // 
            // SelectDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 398);
            this.Controls.Add(this.tbxSamplePeriod);
            this.Controls.Add(this.lblSamplePeriod);
            this.Controls.Add(this.tbxNoAverages);
            this.Controls.Add(this.lblNoAverages);
            this.Controls.Add(this.tbxNoEchoes);
            this.Controls.Add(this.lblNoEchoes);
            this.Controls.Add(this.tbxNoScans);
            this.Controls.Add(this.lblNoScans);
            this.Controls.Add(this.tbxNoSlices);
            this.Controls.Add(this.lblNoSlices);
            this.Controls.Add(this.tbxTR);
            this.Controls.Add(this.lblTR);
            this.Controls.Add(this.tbxSysFreq);
            this.Controls.Add(this.lblSysFreq);
            this.Controls.Add(this.nudAverage);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.nudEcho);
            this.Controls.Add(this.lblEcho);
            this.Controls.Add(this.nudScan);
            this.Controls.Add(this.lblScan);
            this.Controls.Add(this.lblSlice);
            this.Controls.Add(this.nudSlice);
            this.Name = "SelectDataForm";
            this.Text = "Select Data";
            this.Load += new System.EventHandler(this.SelectDataForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudSlice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEcho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAverage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSlice;
        private System.Windows.Forms.Label lblScan;
        private System.Windows.Forms.Label lblEcho;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Label lblSysFreq;
        private System.Windows.Forms.Label lblTR;
        public System.Windows.Forms.TextBox tbxSysFreq;
        public System.Windows.Forms.TextBox tbxTR;
        private System.Windows.Forms.Label lblNoSlices;
        private System.Windows.Forms.Label lblNoScans;
        private System.Windows.Forms.Label lblNoEchoes;
        private System.Windows.Forms.Label lblNoAverages;
        public System.Windows.Forms.TextBox tbxNoSlices;
        public System.Windows.Forms.TextBox tbxNoScans;
        public System.Windows.Forms.TextBox tbxNoEchoes;
        public System.Windows.Forms.TextBox tbxNoAverages;
        public System.Windows.Forms.NumericUpDown nudSlice;
        public System.Windows.Forms.NumericUpDown nudScan;
        public System.Windows.Forms.NumericUpDown nudEcho;
        public System.Windows.Forms.NumericUpDown nudAverage;
        public System.Windows.Forms.TextBox tbxSamplePeriod;
        private System.Windows.Forms.Label lblSamplePeriod;
    }
}

