using System;
using System.Linq;

public partial class Paginas_Uitslagen : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnZoek_Click(object sender, EventArgs e)
    {
        lblSpeler1.Text = "Score van " + txbSpeler1Naam.Text + ":";
        lblSpeler2.Text = "Score van " + txbSpeler2Naam.Text + ":";
        txbSpeler1Naam.Enabled = false;
        txbSpeler2Naam.Enabled = false;
        txbRonde.Enabled = false;
        txbToernooi.Enabled = false;
        btnZoek.Enabled = false;
        txbWinnaar.Enabled = true;
        txbSpeler1Score.Enabled = true;
        txbSpeler2Score.Enabled = true;
        btnSubmit.Enabled = true;
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        TennistoernooiEntities db = new TennistoernooiEntities();

        SPELER speler1 = (from x in db.SPELERs
                          where x.Speler_Voornaam == txbSpeler1Naam.Text
                          select x).FirstOrDefault();
        int speler1Id = speler1.Id;

        SPELER speler2 = (from x in db.SPELERs
                          where x.Speler_Voornaam == txbSpeler2Naam.Text
                          select x).FirstOrDefault();
        int speler2Id = speler2.Id;

        TOERNOOI toernooi = (from x in db.TOERNOOIs
                             where x.Toernooi_Naam == txbToernooi.Text
                             select x).FirstOrDefault();
        int toernooiId = toernooi.Id;

        int ronde = Convert.ToInt32(txbRonde.Text);
        WEDSTRIJD wedstrijd = (from x in db.WEDSTRIJDs
                               where x.Speler1_Id == speler1Id && x.Speler2_Id == speler2Id && x.Toernooi_Id == 
                                toernooiId && x.Ronde == ronde
                               select x).FirstOrDefault();
        int wedstrijdId = wedstrijd.Id;

        clsWedstrijd objUitslag = new clsWedstrijd();
        WEDSTRIJD uit = createUitslag();

        lblResult.Text = objUitslag.UpdateProduct(wedstrijdId, uit);
        Response.Redirect("~/Paginas/Uitslagen.aspx");
    }

    private WEDSTRIJD createUitslag()
    {
        TennistoernooiEntities db = new TennistoernooiEntities();

        SPELER speler = (from x in db.SPELERs
                         where x.Speler_Voornaam == txbWinnaar.Text
                         select x).FirstOrDefault();
        int spelerId = speler.Id;

        WEDSTRIJD u = new WEDSTRIJD();
        u.Score1 = Convert.ToInt32(txbSpeler1Score.Text);
        u.Score2 = Convert.ToInt32(txbSpeler2Score.Text);
        u.Winnaar_Id = spelerId;

        return u;
    }
}