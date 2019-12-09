using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lession05
{
    public partial class Form1 : Form
    {
        #region declaration
        private Random rand = new Random();
        private int speed = 1;
        private int points = 0;
        private int Points
        {
            get => points;
            set
            {
                lblPoints.Text = value.ToString();
                points = value;
            }
        }
        private int goal = 25;
        private int health = 3;
        private int Health
        {
            get => health;
            set
            {
                lblHealth.Text = value.ToString();
                health = value;
            }
        }
        #endregion
        public Form1()
        {
            InitializeComponent();
            
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            pnlSlider.Location = new Point(pnlSlider.Location.X, (int)((50 - trackBar1.Value) * 7.5)+35);
        }
        private void TmrProjectile_Tick(object sender, EventArgs e)
        {
            if(pnlProjectile.Bounds.IntersectsWith(pnlSlider.Bounds))
            {
                Points+=1;
                if (Points == goal) StopGame("You've won congratulations!");
                ResetProjectile();
            } 
            if(pnlProjectile.Bounds.IntersectsWith(trackBar1.Bounds))
            {
                Health-=1;
                if (Health == 0) StopGame("You've lost, noob!");
                ResetProjectile();
            }
            pnlProjectile.Location = new Point(pnlProjectile.Location.X+speed, pnlProjectile.Location.Y);
        }
        private void ResetProjectile()
        {
            pnlProjectile.Location = new Point(10, rand.Next(75, 400));
            speed = rand.Next(2, 8);
        }
        private void StopGame(string s = "")
        {
            TmrProjectile.Enabled = false;
            MessageBox.Show(s);
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (TmrProjectile.Enabled)
                btnStartStop.Text = "Stop";
            else
                btnStartStop.Text = "Start";
            TmrProjectile.Enabled = !TmrProjectile.Enabled;
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Aqua;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.White;
        }
    }
}
