using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lession2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TxtDemo_TextChanged(object sender, EventArgs e)
        {
            var rnd = new Random();
            LblDemo.Text = TxtDemo.Text;
            TxtDemo.BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
        }

        private void NumDemo_ValueChanged(object sender, EventArgs e)
        {
            var val = 255 - Convert.ToInt32(NumDemo.Value);
            NumDemo.BackColor = Color.FromArgb(val, val, val);
        }
    }
}
