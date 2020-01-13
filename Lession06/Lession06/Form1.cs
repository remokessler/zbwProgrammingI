using System;
using System.Data;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lession06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            var star = "*";
            var space = " ";
            var result = string.Empty;
            for(var i = 30; i > 0; i--)
            {
                i--;
                var seperator = string.Empty;
                var line = string.Empty;
                for (var a = 0; a < (30 - i) / 2; a++)
                    seperator += space;
                for (var a = 0; a < i; a++)
                    line += star;
                result += seperator + line + seperator + Environment.NewLine;
            }
            txtStart.Text = result;
        }
        private void reversedStaircase()
        {
            txtStart.Text += string.Join(Environment.NewLine,
                Enumerable.Range(1, 10).Select(
                    c => string.Join(" ", Enumerable.Range(1, c))).Reverse());
        }
    }
}
