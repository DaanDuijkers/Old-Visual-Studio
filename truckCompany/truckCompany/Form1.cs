using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace truckCompany
{
    public partial class Form1 : Form
    {
        int boxes;
        int boxesPerPallet;
        int truckCapacity;
        double truck;
        int fullTruck;
        double remainingPallets;
        int fullRemainingPallets;
        double remainingBoxes;
        double pallets;

        double truckPrice;
        double palletPrice;
        double boxPrice;
        double fullPrice;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                boxes = Convert.ToInt32(txbBoxes.Text);
                boxesPerPallet = Convert.ToInt32(txbBoxesPerPallet.Text);
                truckCapacity = Convert.ToInt32(txbTruckCapacity.Text);

                pallets = boxes / boxesPerPallet;
                truck = pallets / truckCapacity;
                fullTruck = Convert.ToInt32(truck);
                remainingPallets = (truck - fullTruck) * truckCapacity;
                fullRemainingPallets = Convert.ToInt32(remainingPallets);
                remainingBoxes = (remainingPallets - fullRemainingPallets) * boxesPerPallet;

                if (rbA.Checked == true)
                {
                    truckPrice = 400;
                    palletPrice = 25;
                    boxPrice = 1.5;
                }
                else if (rbB.Checked == true)
                {
                    truckPrice = 430;
                    palletPrice = 19;
                    boxPrice = 1.25;
                }
                else
                {
                    truckPrice = 500;
                    palletPrice = 34;
                    boxPrice = 2.5;
                }

                lblResult.Text = fullTruck.ToString() + " trucks";
                lblRemainingPallets.Text = remainingPallets.ToString() + " remaining pallets";
                lblRemainingBoxes.Text = "and " + remainingBoxes.ToString() + " remaining boxes";

                truckPrice = truckPrice * fullTruck;
                palletPrice = palletPrice * pallets;
                boxPrice = boxPrice * boxes;
                fullPrice = truckPrice + palletPrice + boxPrice;

                lblTruckPrice.Text = "€" + fullPrice.ToString("0.00");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
