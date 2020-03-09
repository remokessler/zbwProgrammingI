using System;
using System.Linq;
using System.Windows.Forms;

namespace Aufgabe_10_1_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string GetLargerValue(string a, string b) => int.Parse(a) > int.Parse(b) ? a : b;

        private void CmdMax1_Click(object sender, EventArgs e)
        {
            LblMax.Text = GetLargerValue(TxtValue1.Text, TxtValue2.Text);
        }

        private void CmdMax2_Click(object sender, EventArgs e)
        {
            LblMax.Text = GetLargerValue(TxtValue2.Text, TxtValue3.Text);
        }

        private void CmdMax3_Click(object sender, EventArgs e)
        {
            LblMax.Text = GetLargerValue(TxtValue1.Text, TxtValue3.Text);
        }
    }
}
