using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecretNumber
{
    public partial class Form1 : Form
    {
        private Random r = new Random();
        private int secretNumber = 0;
        private int nrOfGuesses;

        public Form1()
        {
            InitializeComponent();
            // Generate a random number between 0 and 10 (including 0 and 10)
            this.GenerateNewRandom();
        }

        private void GenerateNewRandom()
        {
            this.secretNumber = r.Next(0, 11);
            this.nrOfGuesses = 0;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                int guess = Convert.ToInt32(textBox1.Text);
                nrOfGuesses++;
                if (guess == this.secretNumber)
                {
                    MessageBox.Show("You guessed it! Number of tries: " + this.nrOfGuesses);
                    MessageBox.Show("Let's guess again");
                    this.GenerateNewRandom();
                }
                else
                {
                    MessageBox.Show("Not OK, please try again");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter a number");
            }
 
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.GenerateNewRandom();
        }
    }
}
