using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Maandnamen : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnClick_Click(object sender, EventArgs e)
    {
        string maand = txbInput.Text;

        if (maand == "januari")
        {
            lblOutput.Text = "Wintermaand";
        }
        else if (maand == "februari")
        {
            lblOutput.Text = "Sprokkelmaand";
        }
        else if (maand == "maart")
        {
            lblOutput.Text = "Lentemaand";
        }
        else if (maand == "april")
        {
            lblOutput.Text = "Grasmaand";
        }
        else if (maand == "mei")
        {
            lblOutput.Text = "Bloeimaand";
        }
        else if (maand == "juni")
        {
            lblOutput.Text = "Zomermaand";
        }
        else if (maand == "juli")
        {
            lblOutput.Text = "Hooimaand";
        }
        else if (maand == "augustus")
        {
            lblOutput.Text = "Oogstmaand";
        }
        else if (maand == "september")
        {
            lblOutput.Text = "Herstmaand";
        }
        else if (maand == "oktober")
        {
            lblOutput.Text = "Wijnmaand";
        }
        else if (maand == "november")
        {
            lblOutput.Text = "Slachtmaand";
        }
        else if (maand == "december")
        {
            lblOutput.Text = "Sneeuwmaand";
        }
    }
}