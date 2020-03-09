using System;
using System.Drawing;
using System.Windows.Forms;

namespace Aufgabe_A10_1_9
{
    public partial class Form1 : Form
    {
        private int[] data = new int[100];

        public Form1()
        {
            InitializeComponent();
        }
        #region Random Generators
        private void CmdGenerateRandomValues_Click(object sender, EventArgs e)
        {
            data = GenerateRandomValues(100, -100, 100);
            ShowRandomNumbers(TxtValues, data);
        }

        private void CmdGenerateRandomValues2_Click(object sender, EventArgs e)
        {
            data = GenerateRandomValues();
            ShowRandomNumbers(TxtValues, data);
        }

        private void CmdGenerateRandomValues3_Click(object sender, EventArgs e)
        {
            data = GenerateRandomValues(min: -300, max: 50);
            ShowRandomNumbers(TxtValues, data);
        }
        #endregion

        private void ShowRandomNumbers(TextBox tb, int[] data)
        {
           
        }

        private void CmdSmallestNumber_Click(object sender, EventArgs e)
        {
            
        }

        private void CmdLargestNumber_Click(object sender, EventArgs e)
        {
           
        }

        private void CmdAverage_Click(object sender, EventArgs e)
        {
           
        }

        private void CmdDeltaMax_Click(object sender, EventArgs e)
        {
            
        }

        private void CmdDeltaMin_Click(object sender, EventArgs e)
        {
           
        }

        private int[] GenerateRandomValues(int amount = 20, int min = -20, int max = 30)
        {
           
            return null; // must be replace
        }

        private int Max(int[] data)
        {
            
            return 0; // must be replace
        }

        private int Min(int[] data)
        {
           
            return 0; // must be replace
        }

        private double Average(int[] data)
        {
            
            return 0; // must be replace
        }

        private void ShowResult(Label l, double result)
        {
            
        }

        private int DeltaMax(int[] data)
        {
            return 0; // must be replace
        }

        private int DeltaMin(int[] data)
        {
            return 0; // must be replace
        }
    }
}
