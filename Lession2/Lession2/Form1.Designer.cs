namespace Lession2
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
            this.TxtDemo = new System.Windows.Forms.TextBox();
            this.LblDemo = new System.Windows.Forms.Label();
            this.NumDemo = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NumDemo)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtDemo
            // 
            this.TxtDemo.Location = new System.Drawing.Point(12, 12);
            this.TxtDemo.Name = "TxtDemo";
            this.TxtDemo.Size = new System.Drawing.Size(344, 22);
            this.TxtDemo.TabIndex = 0;
            this.TxtDemo.Text = "...";
            this.TxtDemo.TextChanged += new System.EventHandler(this.TxtDemo_TextChanged);
            // 
            // LblDemo
            // 
            this.LblDemo.AutoSize = true;
            this.LblDemo.Location = new System.Drawing.Point(362, 15);
            this.LblDemo.Name = "LblDemo";
            this.LblDemo.Size = new System.Drawing.Size(59, 17);
            this.LblDemo.TabIndex = 1;
            this.LblDemo.Text = "lblDemo";
            // 
            // NumDemo
            // 
            this.NumDemo.Location = new System.Drawing.Point(12, 41);
            this.NumDemo.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NumDemo.Name = "NumDemo";
            this.NumDemo.Size = new System.Drawing.Size(103, 22);
            this.NumDemo.TabIndex = 2;
            this.NumDemo.ValueChanged += new System.EventHandler(this.NumDemo_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NumDemo);
            this.Controls.Add(this.LblDemo);
            this.Controls.Add(this.TxtDemo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NumDemo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtDemo;
        private System.Windows.Forms.Label LblDemo;
        private System.Windows.Forms.NumericUpDown NumDemo;
    }
}

