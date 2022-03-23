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

        private void btnClick_Click(object sender, EventArgs e)
        {
            DateTime Geboortedatum = dateTimePickerGeboorteDatum.Value;
            TimeSpan leeftijdDagen = DateTime.Now - Geboortedatum;
            double leeftijdGetal = (leeftijdDagen.TotalDays / 365);

            DateTime rijbewijs = dateTimePickerRijbewijs.Value;

            if (leeftijdGetal >= 22 && radioButtonA3.Checked)
                {
                    MessageBox.Show("U kan geen hoger rijbewijs ontvangen");
                }
                else if (leeftijdGetal >= 22 && radioButtonA2.Checked)
                    {
                        string examen = rijbewijs.AddYears(2).ToString("yyyy-MM-dd");
                        MessageBox.Show("U mag nu op voor Rijbewijs A3 op om " + examen + ".");
                    }
                    else if(leeftijdGetal >= 20 && radioButtonA1.Checked)
                        {
                            string examen = rijbewijs.AddYears(2).ToString("yyyy-MM-dd");
                            MessageBox.Show("U mag nu op voor Rijbewijs A2 op om " + examen + ".");
                        }      
                        else if (leeftijdGetal >= 18 && radioButtonGeen.Checked)
                            {
                                MessageBox.Show("U mag nu op voor Rijbewijs A1.");
                            }
                            else if (leeftijdGetal < 18)
                                {
                                    string examen = rijbewijs.AddYears(18).ToString("yyyy-MM-dd");
                                    MessageBox.Show("U mag nu op voor Rijbewijs A1 op om " + examen + ".");
                                }
                                else
                                    {
                                        MessageBox.Show("Error");
                                    }
        }
    }
}
