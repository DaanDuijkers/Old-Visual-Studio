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

    double getal1()
    {
        double getal = double.Parse(txbGetal1.Text);
        return getal;
    }

    double getal2()
    {
        double getal = double.Parse(txbGetal2.Text);
        return getal;
    }

    double getal3()
    {
        double getal = double.Parse(txbGetal3.Text);
        return getal;
    }

    protected void btnPlus_Click(object sender, EventArgs e)
    {
        double som = getal1() + getal2() + getal3();

        lblUitkomst.Text = som.ToString();
    }

    protected void btnMin_Click(object sender, EventArgs e)
    {
        double som = getal1() - getal2() - getal3();

        lblUitkomst.Text = som.ToString();
    }

    protected void btnKeer_Click(object sender, EventArgs e)
    {
        double som = getal1() * getal2() * getal3();

        lblUitkomst.Text = som.ToString();
    }

    protected void btnDeel_Click(object sender, EventArgs e)
    {
        double som = getal1() / getal2() / getal3();

        lblUitkomst.Text = som.ToString();
    }
}