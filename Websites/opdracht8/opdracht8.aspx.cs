using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class opdracht8 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnClick_Click(object sender, EventArgs e)
    {
        string naam = txbNaam.Text;

        int uur = DateTime.Now.Hour;

        if(uur >= 8 && uur < 12)
        {
            lblOutput.Text = "Goedemorgen " + naam + ", hoe gaat het?";
        }
        else if(uur >= 12 && uur < 18)
        {
            lblOutput.Text = "Goedemiddag " + naam + ", hoe gaat het?";
        }
        else if(uur >= 18 && uur < 23)
        {
            lblOutput.Text = "Goedenavond " + naam + ", hoe gaat het?";
        }
    }

    protected void txbNaam_TextChanged(object sender, EventArgs e)
    {
        
    }
}