namespace TrafficLight
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlBg = new System.Windows.Forms.Panel();
            this.pnlGreen = new System.Windows.Forms.Panel();
            this.pnlYellow = new System.Windows.Forms.Panel();
            this.pnlRed = new System.Windows.Forms.Panel();
            this.btnContinue = new System.Windows.Forms.Button();
            this.pnlBg.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBg
            // 
            this.pnlBg.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pnlBg.Controls.Add(this.pnlGreen);
            this.pnlBg.Controls.Add(this.pnlYellow);
            this.pnlBg.Controls.Add(this.pnlRed);
            this.pnlBg.Location = new System.Drawing.Point(12, 12);
            this.pnlBg.Name = "pnlBg";
            this.pnlBg.Size = new System.Drawing.Size(172, 288);
            this.pnlBg.TabIndex = 0;
            // 
            // pnlGreen
            // 
            this.pnlGreen.BackColor = System.Drawing.Color.White;
            this.pnlGreen.Location = new System.Drawing.Point(44, 188);
            this.pnlGreen.Name = "pnlGreen";
            this.pnlGreen.Size = new System.Drawing.Size(75, 75);
            this.pnlGreen.TabIndex = 1;
            // 
            // pnlYellow
            // 
            this.pnlYellow.BackColor = System.Drawing.Color.White;
            this.pnlYellow.Location = new System.Drawing.Point(44, 107);
            this.pnlYellow.Name = "pnlYellow";
            this.pnlYellow.Size = new System.Drawing.Size(75, 75);
            this.pnlYellow.TabIndex = 1;
            // 
            // pnlRed
            // 
            this.pnlRed.BackColor = System.Drawing.Color.White;
            this.pnlRed.Location = new System.Drawing.Point(44, 26);
            this.pnlRed.Name = "pnlRed";
            this.pnlRed.Size = new System.Drawing.Size(75, 75);
            this.pnlRed.TabIndex = 0;
            // 
            // btnContinue
            // 
            this.btnContinue.Location = new System.Drawing.Point(190, 249);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(101, 51);
            this.btnContinue.TabIndex = 1;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(322, 328);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.pnlBg);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlBg.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBg;
        private System.Windows.Forms.Panel pnlGreen;
        private System.Windows.Forms.Panel pnlYellow;
        private System.Windows.Forms.Panel pnlRed;
        private System.Windows.Forms.Button btnContinue;
    }
}

