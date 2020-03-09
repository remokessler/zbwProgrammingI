using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aufgabe_10_1_2
{
    public partial class Form1 : Form
    {
        private int upperLimit = 0;
        private int secretNumber = 0;
        private int enteredNumber = 0;
        private int enterCounter = 0;
        private int answerIndexCode = -1;
        private readonly string[] answers =
            { "Die von mir gedachte Zahl ist grösser!",
              "Die von mir geachte Zahl ist kleiner!",
              "Du hast die Zahl erraten! Gratuliere!!!",
              " .Versuch",
              "Ich denke mir eine Zahl zwischen 0 und "};

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeGame();
        }

        /// <summary>
        /// Will called when the user have pressed the Enter-Key
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void CmdRestart_Click(object sender, EventArgs e)
        {
            InitializeGame();
        }

        /// <summary>
        /// That method initialize all relevant things for a solid start the game
        /// </summary>
        private void InitializeGame()
        {
           
        }

        private void GenerateLimitAndSecret()
        {
           
        }
        /// <summary>
        /// Check the entered number, if it's the same than the secretNumber
        /// </summary>
        private void CheckNumber()
        {
            
        }

        private void PutTextOut()
        {
            
        }

        private void ShowErrorMessages()
        {
            Sum("much nömber", 1);
            Sum("männi nömbers, bröther", 1, 2, 3, 4, 5, 6);
        }

        private int Sum(string s, params int[] i)
        {
            return i.Sum();
        }
    }
}
