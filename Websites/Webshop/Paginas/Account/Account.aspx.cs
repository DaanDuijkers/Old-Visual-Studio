using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Paginas_Account_Account : System.Web.UI.Page
{
    int count = 0;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (clsClient.ID <= 0)
        {
            Response.Redirect("~/Index.aspx");
        }
        else if (!IsPostBack)
        {
            load();
        }

        if (clsClient.USER != "admin")
        {
            hprlnkManagement.Visible = false;
        }
    }

    private void load()
    {
        WebshopEntities db = new WebshopEntities();
        Client client = (from x in db.Clients
                         where x.Id == clsClient.ID
                         select x).FirstOrDefault();

        txbGebruikersnaam.Text = client.UserName;
        txbVoornaam.Text = client.FirstName;
        txbTussenvoegsel.Text = client.Insertion;
        txbAchternaam.Text = client.LastName;
        txbAdres.Text = client.Address;
        txbEmail.Text = client.Mail;
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        if (btnDelete.Text != "Weet u het zeker")
        {
            btnDelete.Text = "Weet u het zeker";
        }
        else if (btnDelete.Text == "Weet u het zeker")
        {
            clsClient objClient = new clsClient();
            objClient.DeleteClient(clsClient.ID);

            clsClient.ID = 0;
            btnDelete.Text = "Verwijder Account";
            Response.Redirect("~/Index.aspx");
        }
    }

    protected void btnPasAan_Click(object sender, EventArgs e)
    {
        clsClient objClient = new clsClient();
        Client client = createClient();

        lblAangepast.Text = objClient.UpdateClient(clsClient.ID, client);
    }

    private Client createClient()
    {
        Client client = new Client();

        client.UserName = txbGebruikersnaam.Text;
        client.Password = txbWachtwoord.Text;
        client.FirstName = txbVoornaam.Text;
        client.Insertion = txbTussenvoegsel.Text;
        client.LastName = txbAchternaam.Text;
        client.Address = txbAdres.Text;
        client.Mail = txbEmail.Text;

        return client;
    }
}