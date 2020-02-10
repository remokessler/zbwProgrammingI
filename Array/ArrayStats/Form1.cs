using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayStats
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnRazerRgb_Click(object sender, EventArgs e)
        {
            RgbSupport();
            var r = new Random();
            var alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var data = new int[1000].Select(i => alphabet[r.Next(0, 26)]);
            TxtRazerRgb.Text = string.Join(Environment.NewLine, data);
        }
        private void RgbSupport()
        {
            var random = new Random();
            var color = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
            BtnRazerRgb.BackColor = color;
            TxtRazerRgb.BackColor = color;
            label1.ForeColor = color;
            label2.ForeColor = color;
        }
    }
}
