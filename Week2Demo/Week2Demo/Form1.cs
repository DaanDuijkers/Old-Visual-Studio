using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week2Demo
{
    public partial class Form1 : Form
    {
        private TransportationAdministration adm;

        public Form1()
        {
            InitializeComponent();
            adm = new TransportationAdministration();
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            string licensePlate = txbLicensePlate.Text;
            string color = txbColor.Text;
            int speed = Convert.ToInt32(txbSpeed.Text);
            Car c = new Car(licensePlate, color, speed);
            adm.AddTransportation(c);
            this.ShowInListBox();
        }

        private void btnAddBicycle_Click(object sender, EventArgs e)
        {
            bool hasCarrier = cbHasLuggageCarrier.Checked;
            int speed = Convert.ToInt32(txbSpeed.Text);
            Bicycle b = new Bicycle(hasCarrier, speed);
            adm.AddTransportation(b);
            this.ShowInListBox();
        }

        private void ShowInListBox()
        {
            lbTransportation.Items.Clear();
            Transportation[] transportations = adm.GetAll();
            foreach (Transportation t in transportations)
            {
                lbTransportation.Items.Add(t);
            }
        }
    }
}
