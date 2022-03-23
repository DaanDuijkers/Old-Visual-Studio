using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Speler
{
    public partial class Form1 : Form
    {
        speler speler1 = new speler();
        speler speler2 = new speler();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string naam = textBox2.Text;

            speler2.setNaam(naam);

            textBox1.Text += speler2.getNaam() + "\r\n";
            textBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string naam = textBox3.Text;

            speler1.setNaam(naam);

            textBox1.Text += speler1.getNaam() + "\r\n";
            textBox3.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += speler1.getNaam() + "\r\n";
            textBox1.Text += speler2.getNaam() + "\r\n";
        }
    }
}
