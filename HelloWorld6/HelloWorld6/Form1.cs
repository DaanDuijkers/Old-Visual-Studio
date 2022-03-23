using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIndex_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(txbinvoer.Text);

            int[] getallen = { 25, 35, 22, 44, 53 };
            string[] namen = { "Mudi", "Tim", "Theo", "Sef", "Erik" };
            lblOutput.Text = getallen[index].ToString() + "\r\n" + namen[index];
        }
    }
}
