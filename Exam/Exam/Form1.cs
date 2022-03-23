using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam
{
    public partial class Form1 : Form
    {
        Winery w = new Winery("Winery");
        List<Winery> wineryList = new List<Winery> ();

        public Form1()
        {
            InitializeComponent();

            AddSomeTestingStuff();
            Carriers();
            getKind();
        }

        private void AddSomeTestingStuff() 
        {
            this.w.AddBarrel(30); 
            this.w.AddBarrel(150); 
            this.w.AddBarrel(500); 
            this.w.AddBarrel(3000); 
            this.w.AddBarrel(150); 
            this.w.AddBarrel(300); 
            this.w.AddBarrel(300); 
            this.w.AddBarrel(200); 
            this.w.AddBarrel(700); 
            this.w.AddBarrel(700); 
            this.w.AddBarrel(600); 
            this.w.AddBarrel(30); 
            this.w.RemoveBarrel("207D"); 
            this.w.RemoveBarrel("211C");
            /*this.w.AddWineToBarrel("206B", 40, KindOfWine.MERLOT); 
            this.w.AddWineToBarrel("208D", 40, KindOfWine.GRENACHE); 
            this.w.AddWineToBarrel("212C", 200, KindOfWine.MERLOT); 
            this.w.AddWineToBarrel("213D", 500, KindOfWine.MERLOT); 
            this.w.AddWineToBarrel("214D", 500, KindOfWine.MIXED); 
            this.w.AddWineToBarrel("216A", 27, KindOfWine.TEMPRANILLO);*/

            List();
        }

        private void Carriers()
        {
            w.AddCarrier("Carrier A", 50);
            w.AddCarrier("Carrier B", 100);
            w.AddCarrier("Carrier C", 400);
        }

        private void getKind()
        {
            cmbKind.DataSource = Enum.GetValues(typeof(KindOfWine));
            cmbKind.SelectedIndex = 0;
        }

        private void List()
        {
            lbOutput.Items.Clear();
            List<Barrel> barrels = w.GetAllBarrels();
            foreach (Barrel b in barrels)
            {
                string output = b.GetInfo();
                if (b.Occupied == false)
                {
                    output += ", is empty";
                }
                else
                {
                    output += ", " + b.Amount + " liters of wine";
                }

                lbOutput.Items.Add(output);
            }
        }

        private void btnAddBarrel_Click(object sender, EventArgs e)
        {
            try
            {
                int capacity = Convert.ToInt32(txbCapacity.Text);

                MessageBox.Show("Barrel " + w.AddBarrel(capacity) + " has been added!");
                List();
            }
            catch
            {
                MessageBox.Show("Please enter the capacity of the barrel you wish to add");
            }
        }

        private void btnRemoveBarrel_Click(object sender, EventArgs e)
        {
            if (txbBarrelID.Text != string.Empty)
            {
                string id = txbBarrelID.Text;

                MessageBox.Show("Barrel " + w.RemoveBarrel(id) + " has been removed");
                List();
            }
            else
            {
                MessageBox.Show("Please enter a the ID of the barrel you wish to remove");
            }
        }
    }
}