using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySecondWindowsFormsProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            setLbl();
        }

        private void setLbl()
        {
            LblPosX.Text = "Pos X: " + CmdMove.Location.X.ToString();
            LblY.Text = "Pos Y: " + CmdMove.Location.Y.ToString();
        }

        private void CmdMove_Click(object sender, EventArgs e)
        {
            CmdMove.Location = new Point(CmdMove.Location.X + 10, CmdMove.Location.Y + 10);
            setLbl();
        }
    }
}
