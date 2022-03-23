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

    protected void btnClick_Click(object sender, EventArgs e)
    {
        double getal = double.Parse(txbGetal.Text);

        if(getal < 6)
        {
            lblOutput.Text = "Dat kan veel beter";
        }
        else if(getal >= 6 && getal <8)
        {
            lblOutput.Text = "Dat is voldoende";
        }
        else if (getal >= 8)
        {
            lblOutput.Text = "Dat is heel goed";
        }
    }
}