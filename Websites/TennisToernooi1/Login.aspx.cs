using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        string Username = txbGebruikersnaam.Text;
        string Password = txbWachtwoord.Text;
        clsScheidsrechter objScheidsrechter = new clsScheidsrechter();

        bool Id = objScheidsrechter.getScheidsrechter(Username, Password);
        if (Id == true)
        {
            Response.Redirect("~/Index.aspx");
        }
        else
        {
            lblLogin.Text = "Onbekende gebruikersnaam en/of wachtwoord";
        }
    }
}