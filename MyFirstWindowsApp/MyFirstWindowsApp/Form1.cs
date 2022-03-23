using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstWindowsApp
{
    public partial class frmMyFirstProgram : Form
    {
        public frmMyFirstProgram()
        {
            InitializeComponent();
        }

        private void btnIdentifier_Click(object sender, EventArgs e)
        {
            MessageBox.Show("My name is Daan Duijkers");
        }

        private void trbTrack_Scroll(object sender, EventArgs e)
        {
            prgbProgress.Value = trbTrack.Value;
            lblResult.Text = trbTrack.Value.ToString();
        }

        private void rbtnMakeMeRed_CheckedChanged(object sender, EventArgs e)
        {
            BackColor = Color.Red;
        }

        private void rbtnMakeMeYellow_CheckedChanged(object sender, EventArgs e)
        {
            BackColor = Color.Yellow;
        }

        private void rbtnMakeMeBlue_CheckedChanged(object sender, EventArgs e)
        {
            BackColor = Color.Blue;
        }
    }
}
