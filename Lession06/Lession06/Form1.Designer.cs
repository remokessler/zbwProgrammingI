namespace Lession06
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
            this.txtStart = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblCountOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtStart
            // 
            this.txtStart.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtStart.Location = new System.Drawing.Point(0, 63);
            this.txtStart.Multiline = true;
            this.txtStart.Name = "txtStart";
            this.txtStart.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtStart.Size = new System.Drawing.Size(800, 321);
            this.txtStart.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(12, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(231, 42);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.Location = new System.Drawing.Point(285, 13);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(65, 25);
            this.lblCount.TabIndex = 2;
            this.lblCount.Text = "Count";
            // 
            // lblCountOutput
            // 
            this.lblCountOutput.AutoSize = true;
            this.lblCountOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountOutput.Location = new System.Drawing.Point(356, 13);
            this.lblCountOutput.Name = "lblCountOutput";
            this.lblCountOutput.Size = new System.Drawing.Size(32, 25);
            this.lblCountOutput.TabIndex = 3;
            this.lblCountOutput.Text = "....";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 384);
            this.Controls.Add(this.lblCountOutput);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblCountOutput;
    }
}

