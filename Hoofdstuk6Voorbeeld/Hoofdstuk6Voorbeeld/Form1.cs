using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hoofdstuk6Voorbeeld
{
    public partial class frmWaarBenIk : Form
    {
        public frmWaarBenIk()
        {
            InitializeComponent();
        }

        private void lblX_Click(object sender, EventArgs e)
        {

        }

        private void frmWaarBenIk_Load(object sender, EventArgs e)
        {

        }

        private void frmWaarBenIk_MouseClick(object sender, MouseEventArgs e)
        {
            lblX.Text = e.X.ToString();
            lblY.Text = e.Y.ToString();

            pnlLocation.Location = e.Location;
        }
    }
}
