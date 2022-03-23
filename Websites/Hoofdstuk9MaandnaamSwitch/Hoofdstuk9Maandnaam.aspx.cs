using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Hoofdstuk9Maandnaam : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnClick_Click(object sender, EventArgs e)
    {
        string maand = txbMaand.Text;

        switch(maand)
        {
            case "januari":
                lblOutput.Text = "Wintermaand";
            break;
            case "februari":
                lblOutput.Text = "sprokkelmaand";
            break;
            case "maart":
                lblOutput.Text = "Lengtemaand";
            break;
            case "april":
                lblOutput.Text = "Grasmaand";
            break;
            case "mei":
                lblOutput.Text = "Bloeimaand";
            break;
            case "juni":
                lblOutput.Text = "Zomermaand";
            break;
            case "juli":
                lblOutput.Text = "Hooimaand";
            break;
            case "augustus":
                lblOutput.Text = "Oogstmaand";
            break;
            case "september":
                lblOutput.Text = "Herfstmaand";
            break;
            case "oktober":
                lblOutput.Text = "Wijnmaand";
            break;
            case "november":
                lblOutput.Text = "Slachtmaand";
            break;
            case "december":
                lblOutput.Text = "Sneeuwmaand";
            break;
        }
    }
}