using System;

public partial class Paginas_Account_Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnRegistreer_Click(object sender, EventArgs e)
    {
        clsClient objClient = new clsClient();
        Client client = createClient();

        lblRegistreren.Text = objClient.InsertClient(client);
    }

    private Client createClient()
    {
        Client c = new Client();
        c.UserName = txbGebruikersnaam.Text;
        c.Password = txbWachtwoord.Text;
        c.FirstName = txbVoornaam.Text;
        c.LastName = txbAchternaam.Text;
        c.Address = txbAdres.Text;
        c.Mail = txbEmail.Text;

        return c;
    }
}