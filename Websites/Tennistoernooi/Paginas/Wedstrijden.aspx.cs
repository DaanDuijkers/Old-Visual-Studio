using System;
using System.Linq;

public partial class Paginas_Wedstrijden : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        clsWedstrijd objSchool = new clsWedstrijd();
        WEDSTRIJD wed = createWedstrijd();

        lblResult.Text = objSchool.InsertWedstrijd(wed);
        Response.Redirect("~/Paginas/Wedstrijden.aspx");
    }

    private WEDSTRIJD createWedstrijd()
    {
        TennistoernooiEntities db = new TennistoernooiEntities();

        SPELER speler1 = (from x in db.SPELERs
                          where x.Speler_Voornaam == ddlSpeler1.SelectedItem.Text && x.Speler_Tussenvoegsel == 
                            ddlSpeler1Tussenvoegsel.Text && x.Speler_Achternaam == ddlSpeler1Achternaam.Text
                          select x).FirstOrDefault();
        int speler1Id = speler1.Id;

        SPELER speler2 = (from x in db.SPELERs
                         where x.Speler_Voornaam == ddlSpeler2.SelectedItem.Text && x.Speler_Tussenvoegsel == 
                            ddlSpeler2Tussenvoegsel.Text && x.Speler_Achternaam == ddlSpeler2Achternaam.Text
                         select x).FirstOrDefault();
        int speler2Id = speler2.Id;

        SCHEIDSRECHTER scheidsrechter = (from x in db.SCHEIDSRECHTERs
                                       where x.Voornaam == ddlScheidsrechter.SelectedItem.Text && x.Tussenvoegsel 
                                        == ddlScheidsrechterTussenvoegsel.Text && x.Achternaam == 
                                        ddlScheidsrechterAchternaam.Text
                                       select x).FirstOrDefault();
        int scheidsrechterId = scheidsrechter.Id;

        TOERNOOI toernooi = (from x in db.TOERNOOIs
                             where x.Toernooi_Naam == ddlToernooi.SelectedItem.Text
                             select x).FirstOrDefault();
        int toernooiId = toernooi.Id;

        WEDSTRIJD w = new WEDSTRIJD();
        w.Speler1_Id = speler1Id;
        w.Speler2_Id = speler2Id;
        w.Scheidsrechter_Id = scheidsrechterId;
        w.Toernooi_Id = toernooiId;
        w.Ronde = Convert.ToInt32(txbRonde.Text);
        w.Veld = txbVeld.Text;
        w.Begin_Tijd = TimeSpan.Parse(txbBeginTijd.Text);
        w.Eind_Tijd = TimeSpan.Parse(txbEindTijd.Text);

        return w;
    }
}