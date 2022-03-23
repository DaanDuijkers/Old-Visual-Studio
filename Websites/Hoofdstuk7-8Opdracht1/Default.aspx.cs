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

    protected void Button1_Click(object sender, EventArgs e)
    {

    }

    protected void btnPlus_Click(object sender, EventArgs e)
    {
        double getal1 = Convert.ToDouble(txbGetal1.Text);
        double getal2 = Convert.ToDouble(txbGetal2.Text);
        double getal3 = Convert.ToDouble(txbGetal3.Text);

        double uitkomst = getal1 + getal2 + getal3;

        lblOutput.Text = uitkomst.ToString();
    }

    protected void btnMin_Click(object sender, EventArgs e)
    {
        double getal1 = Convert.ToDouble(txbGetal1.Text);
        double getal2 = Convert.ToDouble(txbGetal2.Text);
        double getal3 = Convert.ToDouble(txbGetal3.Text);

        double uitkomst = getal1 - getal2 - getal3;

        lblOutput.Text = uitkomst.ToString();
    }

    protected void btnKeer_Click(object sender, EventArgs e)
    {
        double getal1 = Convert.ToDouble(txbGetal1.Text);
        double getal2 = Convert.ToDouble(txbGetal2.Text);
        double getal3 = Convert.ToDouble(txbGetal3.Text);

        double uitkomst = getal1 * getal2 * getal3;

        lblOutput.Text = uitkomst.ToString();
    }

    protected void btnDelen_Click(object sender, EventArgs e)
    {
        double getal1 = Convert.ToDouble(txbGetal1.Text);
        double getal2 = Convert.ToDouble(txbGetal2.Text);
        double getal3 = Convert.ToDouble(txbGetal3.Text);

        double uitkomst = getal1 / getal2 / getal3;

        lblOutput.Text = uitkomst.ToString();
    }
}