using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace multiplicationFor
{
    public partial class frmMultiplicationTable : Form
    {
        public frmMultiplicationTable()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                int baseNumber = Convert.ToInt32(txbBaseNumber.Text);
                int length = Convert.ToInt32(txbLength.Text);

                int loops = baseNumber * length;

                for (int counter = baseNumber; counter <= loops; counter += baseNumber)
                {
                    lblResult.Text += " " + counter.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
