namespace MySecondWindowsFormsProject
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
            this.CmdMove = new System.Windows.Forms.Button();
            this.LblPosX = new System.Windows.Forms.Label();
            this.LblY = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CmdMove
            // 
            this.CmdMove.Location = new System.Drawing.Point(129, 164);
            this.CmdMove.Name = "CmdMove";
            this.CmdMove.Size = new System.Drawing.Size(75, 34);
            this.CmdMove.TabIndex = 0;
            this.CmdMove.Text = "Move ";
            this.CmdMove.UseVisualStyleBackColor = true;
            this.CmdMove.Click += new System.EventHandler(this.CmdMove_Click);
            // 
            // LblPosX
            // 
            this.LblPosX.AutoSize = true;
            this.LblPosX.Location = new System.Drawing.Point(126, 115);
            this.LblPosX.Name = "LblPosX";
            this.LblPosX.Size = new System.Drawing.Size(45, 17);
            this.LblPosX.TabIndex = 1;
            this.LblPosX.Text = "Pos X";
            // 
            // LblY
            // 
            this.LblY.AutoSize = true;
            this.LblY.Location = new System.Drawing.Point(126, 132);
            this.LblY.Name = "LblY";
            this.LblY.Size = new System.Drawing.Size(45, 17);
            this.LblY.TabIndex = 2;
            this.LblY.Text = "Pos Y";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblY);
            this.Controls.Add(this.LblPosX);
            this.Controls.Add(this.CmdMove);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdMove;
        private System.Windows.Forms.Label LblPosX;
        private System.Windows.Forms.Label LblY;
    }
}

