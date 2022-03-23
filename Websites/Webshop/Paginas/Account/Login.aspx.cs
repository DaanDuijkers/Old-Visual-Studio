using System;
using System.Web;

public partial class Paginas_Account_Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        string Username = txbGebruikersnaam.Text;
        string Password = txbWachtwoord.Text;
        clsClient objClient = new clsClient();
        
        bool Id = objClient.getClient(Username, Password);
        if (Id == true)
        {
            Response.Redirect("~/Paginas/Account/Account.aspx");
        }
        else
        {
            lblLogin.Text = "Onbekend gebruikersnaam en/of wachtwoord";
        }
    }
}