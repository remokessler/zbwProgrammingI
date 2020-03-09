namespace Playground
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.Cmd1 = new System.Windows.Forms.Button();
            this.Lbl1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Cmd1
            // 
            this.Cmd1.Location = new System.Drawing.Point(40, 41);
            this.Cmd1.Name = "Cmd1";
            this.Cmd1.Size = new System.Drawing.Size(75, 23);
            this.Cmd1.TabIndex = 0;
            this.Cmd1.Text = "button1";
            this.Cmd1.UseVisualStyleBackColor = true;
            this.Cmd1.Click += new System.EventHandler(this.Cmd1_Click);
            // 
            // Lbl1
            // 
            this.Lbl1.AutoSize = true;
            this.Lbl1.Location = new System.Drawing.Point(40, 100);
            this.Lbl1.Name = "Lbl1";
            this.Lbl1.Size = new System.Drawing.Size(35, 13);
            this.Lbl1.TabIndex = 1;
            this.Lbl1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 304);
            this.Controls.Add(this.Lbl1);
            this.Controls.Add(this.Cmd1);
            this.Name = "Form1";
            this.Text = "Playground";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cmd1;
        private System.Windows.Forms.Label Lbl1;
    }
}

