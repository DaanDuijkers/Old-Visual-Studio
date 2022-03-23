using System;
using System.Linq;

public partial class Paginas_Spelers : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (txbAchternaam.Text == string.Empty && txbVoornaam.Text == string.Empty)
        {
            lblResult.Text = "Voer een voor- en achternaam in";
        }
        else
        {
            clsSpeler objSchool = new clsSpeler();
            SPELER splr = createSpeler();

            lblResult.Text = objSchool.InsertSpeler(splr);
            Response.Redirect("~/Paginas/Spelers.aspx");
        }
    }

    private SPELER createSpeler()
    {
        TennistoernooiEntities db = new TennistoernooiEntities();
        SCHOOL school = (from x in db.SCHOOLs
                         where x.School_Naam == ddlScholen.SelectedValue
                         select x).FirstOrDefault();

        SPELER s = new SPELER();
        s.Speler_Voornaam = txbVoornaam.Text;
        s.Speler_Tussenvoegsel = txbTussenvoegsel.Text;
        s.Speler_Achternaam = txbAchternaam.Text;
        s.School_Id = school.Id;

        return s;
    }
}