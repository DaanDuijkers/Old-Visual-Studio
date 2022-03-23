using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOptellen_Click(object sender, EventArgs e)
    {
        double getal1 = double.Parse(txbGetal1.Text);
        double getal2 = double.Parse(txbGetal2.Text);

        double som = getal1 + getal2;

        txbUitkomst.Text = som.ToString();
    }

    protected void btnAftrekken_Click(object sender, EventArgs e)
    {
        double getal1 = double.Parse(txbGetal1.Text);
        double getal2 = double.Parse(txbGetal2.Text);

        double som = getal1 - getal2;

        txbUitkomst.Text = som.ToString();
    }
}