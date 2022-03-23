using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class opdracht7 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnBereken_Click(object sender, EventArgs e)
    {
        int cijfer = Convert.ToInt32(txbGetal.Text);

        if (cijfer >= 8)
        {
            txbResultaat.Text = "Dat is erg goed";
        }
        else if (cijfer >= 6)
        {
            txbResultaat.Text = "U heeft een voldoende";
        }
        else
        {
            txbResultaat.Text = "Dat kan beter";
        }
    }
}