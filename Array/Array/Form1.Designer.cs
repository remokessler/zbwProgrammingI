namespace Array
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
            this.BtnRazerRgb = new System.Windows.Forms.Button();
            this.TxtRazerRgb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnRazerRgb
            // 
            this.BtnRazerRgb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnRazerRgb.Location = new System.Drawing.Point(12, 420);
            this.BtnRazerRgb.Name = "BtnRazerRgb";
            this.BtnRazerRgb.Size = new System.Drawing.Size(284, 50);
            this.BtnRazerRgb.TabIndex = 0;
            this.BtnRazerRgb.Text = "Razer RGB Support";
            this.BtnRazerRgb.UseVisualStyleBackColor = true;
            this.BtnRazerRgb.Click += new System.EventHandler(this.BtnRazerRgb_Click);
            // 
            // TxtRazerRgb
            // 
            this.TxtRazerRgb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtRazerRgb.Location = new System.Drawing.Point(12, 54);
            this.TxtRazerRgb.Multiline = true;
            this.TxtRazerRgb.Name = "TxtRazerRgb";
            this.TxtRazerRgb.Size = new System.Drawing.Size(720, 360);
            this.TxtRazerRgb.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(706, 8);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Razer RGB Support Super Duper Cool App!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(732, 482);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtRazerRgb);
            this.Controls.Add(this.BtnRazerRgb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(750, 500);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Razer RGB Support";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnRazerRgb;
        private System.Windows.Forms.TextBox TxtRazerRgb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

