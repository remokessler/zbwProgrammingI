using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnRazerRgb_Click(object sender, EventArgs e)
        {
            var random = new Random();
            var data = new int[20]; 
            RgbSupport();
            data = data.Select(i => random.Next(0, 1000)).ToArray();
            TxtRazerRgb.Text = string.Join(", ", data) + Environment.NewLine + Environment.NewLine;
            TxtRazerRgb.Text += "Max Value: " + data.Max().ToString() + Environment.NewLine;
            TxtRazerRgb.Text += "Min Value: " + data.Min().ToString() + Environment.NewLine;
            TxtRazerRgb.Text += "Avg Value: " + data.Average().ToString() + Environment.NewLine + Environment.NewLine;
            TxtRazerRgb.Text += "Sorted: " + string.Join(", ", BubbleSort(data));
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

        private int[] BubbleSort(int[] data)
        {
            bool modified;
            do
            {
                modified = false;
                for (int i = 0; i < data.Length - 1; i++)
                {
                    if (data[i] > data[i + 1])
                    {
                        var grande = data[i];
                        data[i] = data[i + 1];
                        data[i + 1] = grande;
                        modified = true;
                    }
                }
            } while (modified);
            return data;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
