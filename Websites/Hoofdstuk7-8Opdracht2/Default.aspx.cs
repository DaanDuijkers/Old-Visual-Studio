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
        string voornaam = txbVoornaam.Text;
        string achternaam = txbAchternaam.Text;
        string leeftijd = txbLeeftijd.Text;

        lblOutput.Text = "Welkom " + voornaam + " " + achternaam + " " + leeftijd + " to ASP World";
    }
}