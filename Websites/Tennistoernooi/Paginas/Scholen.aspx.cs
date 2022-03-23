using System;

public partial class Paginas_Scholen : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if(txbSchool.Text == "")
        {
            lblResult.Text = "Voer een school in";
        }
        else
        {
            clsSchool objSchool = new clsSchool();
            SCHOOL sch = CreateSchool();

            lblResult.Text = objSchool.InsertSchool(sch);
            Response.Redirect("~/Paginas/Scholen.aspx");
        }
    }

    private SCHOOL CreateSchool()
    {
        SCHOOL s = new SCHOOL();
        s.School_Naam = txbSchool.Text;

        return s;
    }
}