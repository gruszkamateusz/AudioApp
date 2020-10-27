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
            this.button1 = new System.Windows.Forms.Button();
            this.pauseBtn = new System.Windows.Forms.Button();
            this.buttonWMP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(284, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Open Wav File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pauseBtn
            // 
            this.pauseBtn.Enabled = false;
            this.pauseBtn.Location = new System.Drawing.Point(27, 67);
            this.pauseBtn.Margin = new System.Windows.Forms.Padding(2);
            this.pauseBtn.Name = "pauseBtn";
            this.pauseBtn.Size = new System.Drawing.Size(284, 37);
            this.pauseBtn.TabIndex = 1;
            this.pauseBtn.Text = "Pause/Play wav";
            this.pauseBtn.UseVisualStyleBackColor = true;
            this.pauseBtn.Click += new System.EventHandler(this.pauseBtn_Click);
            // 
            // buttonWMP
            // 
            this.buttonWMP.Location = new System.Drawing.Point(59, 204);
            this.buttonWMP.Name = "buttonWMP";
            this.buttonWMP.Size = new System.Drawing.Size(141, 46);
            this.buttonWMP.TabIndex = 2;
            this.buttonWMP.Text = "Windows Media Player";
            this.buttonWMP.UseVisualStyleBackColor = true;
            this.buttonWMP.Click += new System.EventHandler(this.buttonWMP_Click);
            // 
            // AudioApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.buttonWMP);
            this.Controls.Add(this.pauseBtn);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AudioApp";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AudioApp_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button pauseBtn;
        private System.Windows.Forms.Button buttonWMP;
    }
}

