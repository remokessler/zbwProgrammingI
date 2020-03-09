using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Playground
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int A10_1_8_1(int a, int b = 3, double c = 14.26, char d = 'B')
        {
            return a+b+(int)c+(int)d;
        }

        private void Cmd1_Click(object sender, EventArgs e)
        {
            Lbl1.Text = "" + A10_1_8_1 (9,  13, 1.1, 'A');

        }
    } 
}
