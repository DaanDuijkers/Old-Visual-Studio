using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ooptwee
{
    public partial class Form1 : Form
    {
        private olifant objOlifant1;
        private olifant objOlifant2;
        private olifant objOlifant3;
        private int selected = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void setNewLine()
        {
            textBox1.Text += "\r\n";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string s = "";
            switch (selected)
            {
                case 1: s = this.objOlifant1.eet("hooi"); break;
                case 2: s = this.objOlifant2.eet("hooi"); break;
                case 3: s = this.objOlifant3.eet("bladeren"); break;
            }
            textBox1.Text += s;
            this.setNewLine();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.objOlifant1 == null)
            {
                this.objOlifant1 = new olifant();
                this.objOlifant1.setNaam("Piet");
                this.objOlifant1.setKleur("grijs");
                textBox1.Text += "Olifant met de naam Piet is aangemaakt.";
                this.setNewLine();
            }
            selected = 1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string s = "";
            switch(selected)
            {
                case 1: s = this.objOlifant1.loop(); break;
                case 2: s = this.objOlifant2.loop(); break;
                case 3: s = this.objOlifant3.loop(); break;
            }
            textBox1.Text += s;
            this.setNewLine();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.objOlifant2 == null)
            {
                this.objOlifant2 = new olifant();
                this.objOlifant2.setNaam("Karel");
                this.objOlifant2.setKleur("grijs");
                textBox1.Text += "Olifant met de naam Karel is aangemaakt.";
                this.setNewLine();
            }
            selected = 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.objOlifant3 == null)
            {
                this.objOlifant3 = new olifant();
                this.objOlifant3.setNaam("Grote Jongen");
                this.objOlifant3.setKleur("grijs");
                textBox1.Text += "Olifant met de naam Grote Jongen is aangemaakt.";
                this.setNewLine();
            }
            selected = 3;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string s = "";
            switch (selected)
            {
                case 1: s = this.objOlifant1.stop(); break;
                case 2: s = this.objOlifant2.stop(); break;
                case 3: s = this.objOlifant3.stop(); break;
            }
            textBox1.Text += s;
            this.setNewLine();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string s = "";
            switch (selected)
            {
                case 1: this.objOlifant1.setKleur("rood");
                    s = this.objOlifant1.Kleur;
                    break;
                case 2: this.objOlifant2.setKleur("rood");
                    s = this.objOlifant2.Kleur;
                    break;
                case 3: this.objOlifant3.setKleur("rood");
                    s = this.objOlifant3.Kleur;
                    break;
            }
            textBox1.Text += s;
            this.setNewLine();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string s = "";
            switch (selected)
            {
                case 1:
                    this.objOlifant1.setKleur("geel");
                    s = this.objOlifant1.Kleur;
                    break;
                case 2:
                    this.objOlifant2.setKleur("geel");
                    s = this.objOlifant2.Kleur;
                    break;
                case 3:
                    this.objOlifant3.setKleur("geel");
                    s = this.objOlifant3.Kleur;
                    break;
            }
            textBox1.Text += s;
            this.setNewLine();
        }
    }
}
