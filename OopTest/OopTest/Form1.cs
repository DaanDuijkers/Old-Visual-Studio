using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OopTest
{
    public partial class Form1 : Form
    {
        private Oliefant objOlifant1;
        private Oliefant objOlifant2;
        private Oliefant objOlifant3;
        private int selected = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (objOlifant1 == null)
            {
                objOlifant1 = new Oliefant();
                objOlifant1.setNaam("Piet");
                objOlifant1.setKleur("grijs");
                textBox1.Text += "Olifant genaamd Piet is aangemaakt\r\n";
            }

            selected = 1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += objOlifant1.Loop() + "\r\n";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += objOlifant1.Stop() + "\r\n";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += objOlifant1.Eet() + "\r\n";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (objOlifant2 == null)
            {
                objOlifant2 = new Oliefant();
                objOlifant2.setNaam("Test");
                objOlifant2.setKleur("bruin");
            }

            selected = 2;
        }
    }
}
