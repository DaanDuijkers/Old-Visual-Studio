using System;
using System.Windows.Forms;

namespace Fontys
{
    public partial class frmFontys : Form
    {
        frmReserveringen FrmReserveringen = new frmReserveringen();
        frmKlanten FrmKlanten = new frmKlanten();
        frmAutos FrmAutos = new frmAutos();

        public frmFontys()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void sluitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void klantenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmReserveringen.Visible = false;
                FrmAutos.Visible = false;

                FrmKlanten.MdiParent = this;
                // Display the new form.  
                FrmKlanten.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void reserveringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmKlanten.Visible = false;
                FrmAutos.Visible = false;

                // Set the Parent Form of the Child window.  
                FrmReserveringen.MdiParent = this;
                // Display the new form.  
                FrmReserveringen.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void autosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmReserveringen.Visible = false;
                FrmKlanten.Visible = false;

                FrmAutos.MdiParent = this;
                // Display the new form.
                FrmAutos.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
