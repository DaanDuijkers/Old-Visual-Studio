using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace toggleColors
{
    public partial class frmColor : Form
    {
        public frmColor()
        {
            InitializeComponent();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (BackColor == Color.Purple)
            {
                BackColor = Color.Green;
            }
            else if (BackColor == Color.Green)
            {
                BackColor = Color.Gray;
            }
            else
            {
                BackColor = Color.Purple;
            }
        }
    }
}
