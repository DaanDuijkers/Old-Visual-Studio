using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hoofdstuk5Opdracht4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            int leeftijd = Convert.ToInt32(txbLeeftijd.Text);

            if(leeftijd < 18)
                {
                    lblOutcome.Text = "Je mag niet motorrijden, want je bent nog niet 18!";
                }
                else if(leeftijd < 20)
                    {
                        lblOutcome.Text = "Als je je rijbewijs A1 haalt." + "\r\n" + 
                        "mag je motorrijwielen rijden van maximaal 11 kW, 125cc en 0,1 kW " +
                        "per kilo ledig gewicht." + "\r\n" +
                        "je mag ook op een gemotoriseerde driewieler van maximaal 15 kW rijgen";
                    }
                    else if(leeftijd < 22)
                        {
                            lblOutcome.Text = "Als je je rijbewijs A2 haalt." + "\r\n" +
                            "mag je ook op motorrijwielen rijgen die een vermogen hebben tussen 30 en 35 kw" + "\r\n" +
                            "en een gewicht tot 150 --175 kg(maximaal 0, 2 kw per kilo ladig gewicht)." + "\r\n" +
                            "Je moet dan wellerst rijbewijs A1 gehaald hebben.";
                        }
                        else
                            {
                                lblOutcome.Text = "Je mag alle voertuigen rijden!" + "\r\n" +
                                "Teminste als je rijbewijs A3 hebt behaalt";
                            }
        }
    }
}
