namespace Aufgabe_A10_1_11
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
            this.TxtbxValues = new System.Windows.Forms.TextBox();
            this.CmdSearchIteration = new System.Windows.Forms.Button();
            this.CmdSearchRekursiv = new System.Windows.Forms.Button();
            this.LblSearch = new System.Windows.Forms.Label();
            this.TxtSearchingValue = new System.Windows.Forms.TextBox();
            this.LblFoundPosition = new System.Windows.Forms.Label();
            this.LblValuePosition = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtbxValues
            // 
            this.TxtbxValues.Location = new System.Drawing.Point(13, 13);
            this.TxtbxValues.Multiline = true;
            this.TxtbxValues.Name = "TxtbxValues";
            this.TxtbxValues.Size = new System.Drawing.Size(404, 96);
            this.TxtbxValues.TabIndex = 0;
            // 
            // CmdSearchIteration
            // 
            this.CmdSearchIteration.Location = new System.Drawing.Point(13, 153);
            this.CmdSearchIteration.Name = "CmdSearchIteration";
            this.CmdSearchIteration.Size = new System.Drawing.Size(199, 23);
            this.CmdSearchIteration.TabIndex = 1;
            this.CmdSearchIteration.Text = "Suche mit Schleife";
            this.CmdSearchIteration.UseVisualStyleBackColor = true;
            this.CmdSearchIteration.Click += new System.EventHandler(this.CmdSearchIteration_Click);
            // 
            // CmdSearchRekursiv
            // 
            this.CmdSearchRekursiv.Location = new System.Drawing.Point(218, 152);
            this.CmdSearchRekursiv.Name = "CmdSearchRekursiv";
            this.CmdSearchRekursiv.Size = new System.Drawing.Size(199, 23);
            this.CmdSearchRekursiv.TabIndex = 2;
            this.CmdSearchRekursiv.Text = "Suche mit Rekursion";
            this.CmdSearchRekursiv.UseVisualStyleBackColor = true;
            this.CmdSearchRekursiv.Click += new System.EventHandler(this.CmdSearchRekursiv_Click);
            // 
            // LblSearch
            // 
            this.LblSearch.AutoSize = true;
            this.LblSearch.Location = new System.Drawing.Point(12, 121);
            this.LblSearch.Name = "LblSearch";
            this.LblSearch.Size = new System.Drawing.Size(183, 13);
            this.LblSearch.TabIndex = 3;
            this.LblSearch.Text = "Welcher Wert soll gefunden werden?";
            // 
            // TxtSearchingValue
            // 
            this.TxtSearchingValue.Location = new System.Drawing.Point(201, 118);
            this.TxtSearchingValue.Name = "TxtSearchingValue";
            this.TxtSearchingValue.Size = new System.Drawing.Size(216, 20);
            this.TxtSearchingValue.TabIndex = 4;
            // 
            // LblFoundPosition
            // 
            this.LblFoundPosition.AutoSize = true;
            this.LblFoundPosition.Location = new System.Drawing.Point(12, 198);
            this.LblFoundPosition.Name = "LblFoundPosition";
            this.LblFoundPosition.Size = new System.Drawing.Size(103, 13);
            this.LblFoundPosition.TabIndex = 5;
            this.LblFoundPosition.Text = "Gefundene Position:";
            // 
            // LblValuePosition
            // 
            this.LblValuePosition.AutoSize = true;
            this.LblValuePosition.Location = new System.Drawing.Point(122, 198);
            this.LblValuePosition.Name = "LblValuePosition";
            this.LblValuePosition.Size = new System.Drawing.Size(16, 13);
            this.LblValuePosition.TabIndex = 6;
            this.LblValuePosition.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 249);
            this.Controls.Add(this.LblValuePosition);
            this.Controls.Add(this.LblFoundPosition);
            this.Controls.Add(this.TxtSearchingValue);
            this.Controls.Add(this.LblSearch);
            this.Controls.Add(this.CmdSearchRekursiv);
            this.Controls.Add(this.CmdSearchIteration);
            this.Controls.Add(this.TxtbxValues);
            this.Name = "Form1";
            this.Text = "Aufgabe_A10-1-11";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtbxValues;
        private System.Windows.Forms.Button CmdSearchIteration;
        private System.Windows.Forms.Button CmdSearchRekursiv;
        private System.Windows.Forms.Label LblSearch;
        private System.Windows.Forms.TextBox TxtSearchingValue;
        private System.Windows.Forms.Label LblFoundPosition;
        private System.Windows.Forms.Label LblValuePosition;
    }
}

