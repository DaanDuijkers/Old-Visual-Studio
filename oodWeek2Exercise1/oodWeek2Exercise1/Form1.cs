using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oodWeek2Exercise1
{
    public partial class Form1 : Form
    {
        private List<Street> streets;

        public Form1()
        {
            InitializeComponent();

            this.streets = new List<Street>();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Street street = new Street(txbName.Text, txbCity.Text);
            this.streets.Add(street);
        }
    }
}
