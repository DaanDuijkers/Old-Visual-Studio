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

    protected void btnClean_Click(object sender, EventArgs e)
    {
        txbGetal1.Text = "";
        txbGetal2.Text = "";
        txbOperator.Text = "";
        lblOutput.Text = "";
    }

    protected void btnStart_Click(object sender, EventArgs e)
    {
        double getal1 = double.Parse(txbGetal1.Text);
        double getal2 = double.Parse(txbGetal2.Text);
        string Operator = txbOperator.Text;

        if (Operator == "+")
        {
            double uitkomst = getal1 + getal2;
            lblOutput.Text = uitkomst.ToString();
        }
        else if (Operator == "-")
        {
            double uitkomst = getal1 - getal2;
            lblOutput.Text = uitkomst.ToString();
        }
        else if (Operator == "*")
        {
            double uitkomst = getal1 * getal2;
            lblOutput.Text = uitkomst.ToString();
        }
        else if (Operator == "/")
        {
            double uitkomst = getal1 / getal2;
            lblOutput.Text = uitkomst.ToString();
        }
        else
        {
            lblOutput.Text = "Error";
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {

    }
}