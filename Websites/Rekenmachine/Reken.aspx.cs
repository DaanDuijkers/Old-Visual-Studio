using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Reken : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOptrekken_Click(object sender, EventArgs e)
    {
        double getal1;
        double getal2;
        double uitkomst;
        getal1 = Convert.ToDouble(txbGetal1.Text);
        getal2 = Convert.ToDouble(txbGetal2.Text);
        uitkomst = getal1 + getal2;
        txbUitkomst.Text = Convert.ToString(uitkomst);
    }

    protected void btnAftrekken_Click(object sender, EventArgs e)
    {
        double getal1;
        double getal2;
        double uitkomst;
        getal1 = Convert.ToDouble(txbGetal1.Text);
        getal2 = Convert.ToDouble(txbGetal2.Text);
        uitkomst = getal1 - getal2;
        txbUitkomst.Text = Convert.ToString(uitkomst);
    }
}