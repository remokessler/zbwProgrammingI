﻿namespace MyFirstWindowsFormsProject
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
            this.CmdDemo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmdDemo
            // 
            this.CmdDemo.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdDemo.Location = new System.Drawing.Point(31, 38);
            this.CmdDemo.Name = "CmdDemo";
            this.CmdDemo.Size = new System.Drawing.Size(247, 128);
            this.CmdDemo.TabIndex = 0;
            this.CmdDemo.Text = "BEST BUTTON!!!";
            this.CmdDemo.UseVisualStyleBackColor = true;
            this.CmdDemo.Click += new System.EventHandler(this.CmdDemo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CmdDemo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CmdDemo;
    }
}

