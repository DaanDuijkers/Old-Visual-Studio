using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace opdracht_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string var1 = "Dit is een string";
            string var2 = "Dit is een kleine string";
            string var3 = "Dit is geen string";
            string var4 = "6,67";
            double var5 = 10.330;
            double var6 = 20.000;
            string var7 = "5.12345";
            string var8 = "int.Parse(var7) + var6   dit is fout"   ;

            label1.Text = "var1 + var2 levert op: "+var1+var2;
            label2.Text = "var1 + var2 + var3 levert op: "+var1+var2+var3;
            label3.Text = "var4 + var5 levert op: dit is fout";
            label4.Text = "var5 + var6 levert op: " + var5 + var6;
            label5.Text = "var5 + var6 + var7 levert op: Dit is fout";
            label6.Text = "var5 * var6 levert op: "+var5*var6;
            label7.Text = "var6 * var7 levert op : Dit is fout";
            label8.Text = "var1 * var2 levert op : Dit is fout";
        }
    }
}
