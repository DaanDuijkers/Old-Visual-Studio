using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dieren
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGaEten_Click(object sender, EventArgs e)
        {
            dieren objDieren = new dieren("oliefant", "roze", "");
            string output = objDieren.gaEten();
            txbOutput.Text = output;
        }

        private void btnOliefant_Click(object sender, EventArgs e)
        {
            oliefant objOliefant = new oliefant("oliefant");
            string output = objOliefant.naamDier();
            txbOutput.Text = output;
        }

        private void btntest_Click(object sender, EventArgs e)
        {
            // error
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            dieren objDieren = new dieren("", "", " blauw");
            string output = objDieren.gaEten();
            txbOutput.Text = output;
        }
    }
}
