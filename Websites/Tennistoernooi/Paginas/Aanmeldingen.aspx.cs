using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

public partial class Paginas_Aanmeldingen : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (clsScheidsrechter.ID < 1)
        {
            Response.Redirect("~/Login.aspx");
        }
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        clsAanmeldingen objAanmelding = new clsAanmeldingen();
        AANMELDING aan = createAanmelding();

        lblResult.Text = objAanmelding.InsertAanmelding(aan);
        Response.Redirect("~/Paginas/Aanmeldingen.aspx");
    }

    private AANMELDING createAanmelding()
    {
        TennistoernooiEntities db = new TennistoernooiEntities();
        SPELER speler = (from x in db.SPELERs
                         where x.Speler_Voornaam == ddlVooraam.SelectedValue && x.Speler_Tussenvoegsel ==
                            ddlTussenvoegsel.SelectedValue && x.Speler_Achternaam == ddlAchternaam.SelectedValue
                         select x).FirstOrDefault();
        AANMELDING a = new AANMELDING();
        a.Speler_Id = speler.Id;

        TOERNOOI toernooi = (from x in db.TOERNOOIs
                             where x.Toernooi_Naam == ddlToernooien.SelectedValue
                             select x).FirstOrDefault();
        a.Toernooi_Id = toernooi.Id;

        return a;
    }

    protected void btnSchema_Click(object sender, EventArgs e)
    {
        TennistoernooiEntities db = new TennistoernooiEntities();
        TOERNOOI toernooi = (from x in db.TOERNOOIs
                             where x.Toernooi_Naam == ddlToernooien.SelectedItem.Text
                             select x).FirstOrDefault();
        int ToernooiId = toernooi.Id;

        string mainconn = ConfigurationManager.ConnectionStrings["TennistoernooiConnectionString"].ToString();
        SqlConnection sqlconn = new SqlConnection(mainconn);
        string sqlquery = "SELECT * FROM AANMELDING WHERE Toernooi_Id='" + ToernooiId + "';";

        sqlconn.Open();
        SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
        SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
        DataTable dt = new DataTable();
        sda.Fill(dt);
        grdAanmeldingen.DataSource = dt;
        grdAanmeldingen.DataBind();
        sqlconn.Close();
    }
}