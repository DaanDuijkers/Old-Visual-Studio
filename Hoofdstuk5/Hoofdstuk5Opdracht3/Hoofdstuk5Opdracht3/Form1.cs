using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hoofdstuk5Opdracht3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnVerstuur_Click(object sender, EventArgs e)
        {
            DateTime geboortedatum = dateTimePickerGeboortedatum.Value;
            TimeSpan leeftijd = DateTime.Now - geboortedatum;
            double totaalleeftijd = (leeftijd.TotalDays / 365);

            DateTime rijbewijs = dateTimePickerRijbewijs.Value;

            string bezit = txbRijbewijs.Text;

            if(totaalleeftijd >= 22 && bezit == "A3")
                {
                    lblOutput.Text = "U kan geen hoger rijbewijs ontvangen";
                }
                else if(totaalleeftijd >= 20 && bezit == "A2")
                    {
                        lblOutput.Text = "U kunt op voor rijbewijs A3 op " + rijbewijs.AddYears(2).ToString("yyyy-MM-dd");
                    }
                    else if(totaalleeftijd >= 18 && bezit == "A1")
                        {
                            lblOutput.Text = "U kunt op voor rijbewijs op " + rijbewijs.AddYears(2).ToString("yyyy-MM-dd");
                        }
                        else if(totaalleeftijd >= 18 && bezit == "geen")
                            {
                                lblOutput.Text = "U mag nu op voor rijbewijs A1";
                            }
                            else if (totaalleeftijd < 18)
                                {
                                    lblOutput.Text = "U mag op voor rijbewijs A1 op " + geboortedatum.AddYears(18).ToString("yyyy-MM-dd");
                                }
                                else
                                    {
                                        lblOutput.Text = "Error";
                                    }
        }
    }
}
