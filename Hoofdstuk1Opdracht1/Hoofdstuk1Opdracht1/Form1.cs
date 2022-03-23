using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hoofdstuk1Opdracht1
{
    public partial class FrmKennismakenProgrammeerOmgeving : Form
    {
        public FrmKennismakenProgrammeerOmgeving()
        {
            InitializeComponent();
        }

        private void btnHelloWorld_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World");
        }
    }
}
