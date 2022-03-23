using System;

public partial class Paginas_Toernooien : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (txbToernooi.Text == string.Empty && txbDatum.Text == string.Empty)
        {
            lblResult.Text = "Voer de naam van het toernooi en een datum in";
        }
        else
        {
            clsToernooi objToernooi = new clsToernooi();
            TOERNOOI toer = createToernooi();

            lblResult.Text = objToernooi.InsertToernooi(toer);
            Response.Redirect("~/Paginas/Toernooien.aspx");
        }
    }

    private TOERNOOI createToernooi()
    {
        TOERNOOI t = new TOERNOOI();
        t.Toernooi_Naam = txbToernooi.Text;
        try
        {
            t.Datum = Convert.ToDateTime(txbDatum.Text);
        }
        catch (Exception ex)
        {
            lblResult.Text = ex.ToString();
        }

        return t;
    }
}