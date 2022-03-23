using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hoofdstuk5opdracht5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerzend_Click(object sender, EventArgs e)
        {
            string maand = txbMaand.Text;

            if(maand == "Januari")
                {
                    lblOutput.Text = "Wintermaand";
                }
                else if (maand == "Februari")
                    {
                        lblOutput.Text = "Sprokkelmaand";
                    }
                    else if (maand == "Maart")
                        {
                            lblOutput.Text = "Lentemaand";
                        }
                        else if (maand == "April")
                            {
                                lblOutput.Text = "Grasmaand";
                            }
                            else if (maand == "Mei")
                                {
                                    lblOutput.Text = "Bloeimaand";
                                }
                                else if (maand == "Juni")
                                    {
                                        lblOutput.Text = "Zomermaand";
                                    }
                                    else if (maand == "Juli")
                                        {
                                            lblOutput.Text = "Hooimaand";
                                        }
                                        else if (maand == "Augustus")
                                            {
                                                lblOutput.Text = "Oogstmaand";
                                            }
                                            else if (maand == "September")
                                                {
                                                    lblOutput.Text = "Herfstmaand";
                                                }
                                                else if (maand == "Oktober")
                                                    {
                                                        lblOutput.Text = "Wijnmaand";
                                                    }
                                                    else if (maand == "November")
                                                        {
                                                            lblOutput.Text = "Slachtmaand";
                                                        }
                                                        else if (maand == "December")
                                                            {
                                                                lblOutput.Text = "Sneeuwmaand";
                                                            }
                                                            else
                                                                {
                                                                    lblOutput.Text = "Error! U heeft niet niet of fout ingevult (Tip: Denk aan de Hoofdletters)!";
                                                                }
        }
    }
}
