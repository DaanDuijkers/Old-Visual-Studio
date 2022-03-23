using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hoofdstuk5Opdracht1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOutcome_Click(object sender, EventArgs e)
        {
            DateTime Geboortedatum = dateTimePickerGeboorteDatum.Value;
            TimeSpan leeftijd = DateTime.Now - Geboortedatum;
            double bier = (leeftijd.TotalDays / 365);

            if(bier < 18)
                {
                    MessageBox.Show("Je mag nog geen alchohol drinken.");
                }
                else
                    {
                        MessageBox.Show("Drink bier in plaats van water, dan heb je morgen een flinke kater.");
                    }
        }
    }
}
