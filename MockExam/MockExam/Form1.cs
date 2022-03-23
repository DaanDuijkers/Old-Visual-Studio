using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MockExam
{
    public partial class Form1 : Form
    {
        BicycleParking bp;

        public Form1()
        {
            InitializeComponent();

            bp = new BicycleParking (2, 3);
        }

        private void btnParkBicycle_Click(object sender, EventArgs e)
        {

        }
    }
}
