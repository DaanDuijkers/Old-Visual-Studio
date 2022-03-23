using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Paginas_Scholen : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if(lblResult.Text == string.Empty)
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