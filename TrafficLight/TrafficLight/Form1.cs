using System;
using System.Drawing;
using System.Windows.Forms;

namespace TrafficLight
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            setState();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            pnlRed.BackColor = Color.White;
            pnlYellow.BackColor = Color.White;
            pnlGreen.BackColor = Color.White;
            ShiftState();
            setState();
        }

        private int state = 1;
        private void ShiftState()
        {
            if (state == 4)
                state = 0;
            state++;
        }

        private void setState()
        {
            switch (state)
            {
                case 1:
                    pnlRed.BackColor = Color.Red;
                    break;
                case 2:
                    pnlYellow.BackColor = Color.Yellow;
                    pnlRed.BackColor = Color.Red;
                    break;
                case 3:
                    pnlGreen.BackColor = Color.Green;
                    break;
                case 4:
                    pnlGreen.BackColor = Color.Green;
                    pnlYellow.BackColor = Color.Yellow;
                    break;
            }
        }
    }
}
