using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace preExam
{
    public partial class Form1 : Form
    {
        BreweryService bs;
        List<BreweryService> breweryServices = new List<BreweryService> ();

        public Form1()
        {
            InitializeComponent();

            addSomeTestingStuff();
            list();
            getTanks();
            getBrewers();
        }

        private void addSomeTestingStuff() 
        {
            bs = new BreweryService("TestingStuff");
            breweryServices.Add(bs);

            bs.AddTank("2Sdo", 300);
            bs.AddTank("buk2", 200);
            bs.AddTank("buk3", 450);
            bs.AddTank("buk6", 50);
            bs.AddTank("A3", 300);
            bs.AddTank("A5", 300);
            bs.AddTank("A6", 3000);
            bs.AddTank("D4", 5000);
            bs.AddTank("Pd", 250);
            bs.AddTank("C4", 300);
        }

        private void list()
        {
            lbOutput.Items.Clear();
            List<Tank> tanks = bs.GetAllTanks();
            foreach (Tank t in tanks)
            {
                string output = t.GetInfo();
                if (t.Occupied == false)
                {
                    output += ", empty";
                }
                else
                {
                    output += ", occupied";
                }

                lbOutput.Items.Add(output);
            }
        }

        private void getBrewers()
        {
            cmbBrewers.Items.Clear();
            List<Brewer> brewers = bs.GetAllBrewers();
            foreach (Brewer b in brewers)
            {
                cmbBrewers.Items.Add(b.getInfo());
            }

            int last = cmbBrewers.Items.Count - 1;
            cmbBrewers.SelectedIndex = last;
        }

        private void getTanks()
        {
            cmbTanks.Items.Clear();
            List<Tank> tanks = bs.GetAllTanks();
            foreach (Tank t in tanks)
            {
                cmbTanks.Items.Add(t.ID);
            }

            int last = cmbTanks.Items.Count - 1;
            cmbTanks.SelectedIndex = last;
        }

        private void btnAddBrewery_Click(object sender, EventArgs e)
        {
            if (txbAdd.Text != string.Empty)
            {
                string name = txbAdd.Text;

                MessageBox.Show("Brewer " + bs.AddBrewer(name) + " has been added!");
                getBrewers();
            }
            else
            {
                MessageBox.Show("Please enter a new brewery");
            }

        }

        private void btnAddTank_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txbAdd.Text;
                int capacity = Convert.ToInt32(txbRequestTank.Text);

                if (bs.AddTank(id, capacity) == true)
                {
                    list();
                    getTanks();
                    MessageBox.Show("A new tank has been added!");
                }
                else
                {
                    MessageBox.Show("This tank already exists!");
                }
            }
            catch
            {
                MessageBox.Show("");
            }
        }

        private void btnRequestTank_Click(object sender, EventArgs e)
        {
            try
            {
                string ID = cmbBrewers.SelectedItem.ToString();
                int capacity = Convert.ToInt32(txbRequestTank.Text);

                MessageBox.Show(bs.RequestTank(ID, capacity));
                list();
            }
            catch
            {
                MessageBox.Show("Please enter a value");
            }
        }
    }
}
