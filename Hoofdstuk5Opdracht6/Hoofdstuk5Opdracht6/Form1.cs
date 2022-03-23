using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hoofdstuk5Opdracht6
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

            switch(maand)
                {
                    case "Januari" :
                        {
                            lblOutput.Text = "Wintermaand";
                            break;
                        }
                        case "Februari":
                            {
                                lblOutput.Text = "Sprokkelmaand";
                                break;
                            }
                            case "Maart":
                                {
                                    lblOutput.Text = "Lentemaand";
                                    break;
                                }
                                case "April":
                                    {
                                        lblOutput.Text = "Grasmaand";
                                        break;
                                    }
                                    case "Mei":
                                        {
                                            lblOutput.Text = "Bloeimaand";
                                            break;
                                        }
                                        case "Juni":
                                            {
                                                lblOutput.Text = "Zomermaand";
                                                break;
                                            }
                                            case "Juli":
                                                {
                                                    lblOutput.Text = "Hooimaand";
                                                    break;
                                                }
                                                case "Augustus":
                                                    {
                                                        lblOutput.Text = "Oogstmaand";
                                                        break;
                                                    }
                                                    case "September":
                                                        {
                                                            lblOutput.Text = "Herfstmaand";
                                                            break;
                                                        }
                                                        case "Oktober":
                                                            {
                                                                lblOutput.Text = "Wijnmaand";
                                                                break;
                                                            }
                                                            case "November":
                                                                {
                                                                    lblOutput.Text = "Slachtmaand";
                                                                    break;
                                                                }
                                                                case "Decemter":
                                                                    {
                                                                        lblOutput.Text = "Sneeuwmaand";
                                                                        break;
                                                                    }
                                                                    default:
                                                                        {
                                                                            lblOutput.Text = "Error! U heeft iets niet of verkeerd ingevuld! (Tip: Denk aan de hoofdletters)";
                                                                            break;
                                                                        }
            }
        }
    }
}
