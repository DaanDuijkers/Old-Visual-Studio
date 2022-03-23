using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace opdracht_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string var1 = "Deze tekst noemen we een string";
            string var2 = "etje van een aantal woorden bij elkaar en een string van het getal:";
            string var3 = "100";
            string var4 = "200";

            label1.Text = "<br /><br /><br /><br />";
            label2.Text = "var1+var2+var3 levert op: " + var1 + var2 + var3;
            label3.Text = "var3+var4 levert op: " + var3 + var4;
            label4.Text = "var1*var2 levert op: " + "var1 * var2 dit werkt niet";
            label5.Text = "var3*var4 levert op: " + "var3 * var4 dit werkt niet";
            label6.Text = "var4:var3 levert op: " + "var4 / var3 dit werkt niet";
            label7.Text = "var1*var4 levert op: " + "var1 * var4 dit werkt niet";
        }
    }
}
