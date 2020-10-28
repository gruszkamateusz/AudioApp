namespace AudioApp
{
    partial class AudioApp
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.openBtn = new System.Windows.Forms.Button();
            this.pauseBtn = new System.Windows.Forms.Button();
            this.buttonWMP = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.sourceList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.waveBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.refBtn = new System.Windows.Forms.Button();
            this.buttonReadWavHeader = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openBtn
            // 
            this.openBtn.Location = new System.Drawing.Point(27, 10);
            this.openBtn.Margin = new System.Windows.Forms.Padding(2);
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(118, 36);
            this.openBtn.TabIndex = 0;
            this.openBtn.Text = "Open Wav File";
            this.openBtn.UseVisualStyleBackColor = true;
            this.openBtn.Click += new System.EventHandler(this.openBtn_Click);
            // 
            // pauseBtn
            // 
            this.pauseBtn.Enabled = false;
            this.pauseBtn.Location = new System.Drawing.Point(27, 67);
            this.pauseBtn.Margin = new System.Windows.Forms.Padding(2);
            this.pauseBtn.Name = "pauseBtn";
            this.pauseBtn.Size = new System.Drawing.Size(118, 32);
            this.pauseBtn.TabIndex = 1;
            this.pauseBtn.Text = "Pause/Play wav";
            this.pauseBtn.UseVisualStyleBackColor = true;
            this.pauseBtn.Click += new System.EventHandler(this.pauseBtn_Click);
            // 
            // buttonWMP
            // 
            this.buttonWMP.Location = new System.Drawing.Point(169, 11);
            this.buttonWMP.Name = "buttonWMP";
            this.buttonWMP.Size = new System.Drawing.Size(136, 35);
            this.buttonWMP.TabIndex = 2;
            this.buttonWMP.Text = "Windows Media Player";
            this.buttonWMP.UseVisualStyleBackColor = true;
            this.buttonWMP.Click += new System.EventHandler(this.buttonWMP_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(27, 111);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.sourceList);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.waveBtn);
            this.splitContainer1.Panel2.Controls.Add(this.stopBtn);
            this.splitContainer1.Panel2.Controls.Add(this.refBtn);
            this.splitContainer1.Size = new System.Drawing.Size(310, 232);
            this.splitContainer1.SplitterDistance = 180;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 3;
            // 
            // sourceList
            // 
            this.sourceList.BackgroundImageTiled = true;
            this.sourceList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.sourceList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sourceList.HideSelection = false;
            this.sourceList.Location = new System.Drawing.Point(0, 0);
            this.sourceList.Margin = new System.Windows.Forms.Padding(2);
            this.sourceList.MultiSelect = false;
            this.sourceList.Name = "sourceList";
            this.sourceList.Size = new System.Drawing.Size(180, 232);
            this.sourceList.TabIndex = 0;
            this.sourceList.UseCompatibleStateImageBehavior = false;
            this.sourceList.View = System.Windows.Forms.View.Details;
            this.sourceList.SelectedIndexChanged += new System.EventHandler(this.sourceList_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Device";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Channels";
            this.columnHeader2.Width = 80;
            // 
            // waveBtn
            // 
            this.waveBtn.Location = new System.Drawing.Point(13, 106);
            this.waveBtn.Margin = new System.Windows.Forms.Padding(2);
            this.waveBtn.Name = "waveBtn";
            this.waveBtn.Size = new System.Drawing.Size(101, 19);
            this.waveBtn.TabIndex = 5;
            this.waveBtn.Text = "To wave";
            this.waveBtn.UseVisualStyleBackColor = true;
            this.waveBtn.Click += new System.EventHandler(this.waveBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.Location = new System.Drawing.Point(12, 130);
            this.stopBtn.Margin = new System.Windows.Forms.Padding(2);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(102, 22);
            this.stopBtn.TabIndex = 2;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click_1);
            // 
            // refBtn
            // 
            this.refBtn.Location = new System.Drawing.Point(13, 11);
            this.refBtn.Margin = new System.Windows.Forms.Padding(2);
            this.refBtn.Name = "refBtn";
            this.refBtn.Size = new System.Drawing.Size(102, 20);
            this.refBtn.TabIndex = 0;
            this.refBtn.Text = "Refresh sources";
            this.refBtn.UseVisualStyleBackColor = true;
            this.refBtn.Click += new System.EventHandler(this.refBtn_Click);
            // 
            // buttonReadWavHeader
            // 
            this.buttonReadWavHeader.Location = new System.Drawing.Point(437, 75);
            this.buttonReadWavHeader.Name = "buttonReadWavHeader";
            this.buttonReadWavHeader.Size = new System.Drawing.Size(87, 36);
            this.buttonReadWavHeader.TabIndex = 4;
            this.buttonReadWavHeader.Text = "Read WAV file header";
            this.buttonReadWavHeader.UseVisualStyleBackColor = true;
            this.buttonReadWavHeader.Click += new System.EventHandler(this.buttonReadWavHeader_Click);
            // 
            // AudioApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.buttonReadWavHeader);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.buttonWMP);
            this.Controls.Add(this.pauseBtn);
            this.Controls.Add(this.openBtn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AudioApp";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AudioApp_FormClosing);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openBtn;
        private System.Windows.Forms.Button pauseBtn;
        private System.Windows.Forms.Button buttonWMP;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView sourceList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Button refBtn;
        private System.Windows.Forms.Button waveBtn;
        private System.Windows.Forms.Button buttonReadWavHeader;
    }
}

