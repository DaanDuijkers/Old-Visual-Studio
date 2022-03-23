using privateMessenger.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace privateMessenger
{
    public partial class introPagina : Form
    {
        public introPagina()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            

            Hide();
            MainWindow main = new MainWindow(true);
            main.ShowDialog();
            Close();
        }
    }
}
