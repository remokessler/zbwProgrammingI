namespace Aufgabe_A10_1_10
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
            this.CmdIteration = new System.Windows.Forms.Button();
            this.CmdRekursion = new System.Windows.Forms.Button();
            this.TxtbxValues = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CmdIteration
            // 
            this.CmdIteration.Location = new System.Drawing.Point(203, 13);
            this.CmdIteration.Name = "CmdIteration";
            this.CmdIteration.Size = new System.Drawing.Size(144, 23);
            this.CmdIteration.TabIndex = 1;
            this.CmdIteration.Text = "Methode mit Schleife";
            this.CmdIteration.UseVisualStyleBackColor = true;
            this.CmdIteration.Click += new System.EventHandler(this.CmdIteration_Click);
            // 
            // CmdRekursion
            // 
            this.CmdRekursion.Location = new System.Drawing.Point(203, 42);
            this.CmdRekursion.Name = "CmdRekursion";
            this.CmdRekursion.Size = new System.Drawing.Size(144, 23);
            this.CmdRekursion.TabIndex = 2;
            this.CmdRekursion.Text = "Methode Rekursion";
            this.CmdRekursion.UseVisualStyleBackColor = true;
            this.CmdRekursion.Click += new System.EventHandler(this.CmdRekursion_Click);
            // 
            // TxtbxValues
            // 
            this.TxtbxValues.Location = new System.Drawing.Point(13, 13);
            this.TxtbxValues.Multiline = true;
            this.TxtbxValues.Name = "TxtbxValues";
            this.TxtbxValues.Size = new System.Drawing.Size(184, 265);
            this.TxtbxValues.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 290);
            this.Controls.Add(this.TxtbxValues);
            this.Controls.Add(this.CmdRekursion);
            this.Controls.Add(this.CmdIteration);
            this.Name = "Form1";
            this.Text = "Aufgabe_A10-1-10";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CmdIteration;
        private System.Windows.Forms.Button CmdRekursion;
        private System.Windows.Forms.TextBox TxtbxValues;
    }
}

