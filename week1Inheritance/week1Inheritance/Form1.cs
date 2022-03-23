using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week1Inheritance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Boat b1 = new Boat("Fontys", 10, 1);
            Car c = new Car("12-ABC-3", Color.Pink, 2);
            Bicycle b2 = new Bicycle(true, 3);
            Transportation t = new Transportation(4);

            lbTransportation.Items.Add(b1.GetInfo());
            lbTransportation.Items.Add(c.GetInfo());
            lbTransportation.Items.Add(b2.GetInfo());
            lbTransportation.Items.Add(t.GetInfo());
        }
    }
}
