using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
            {
                if(Page.IsPostBack == true)
                    {
                        Response.Write("Herhaalde aanvraag");
                    }
                    else
                        {
                            Response.Write(" De eerste keer");
                        }
            }

    protected void btnDoeIets_Click(object sender, EventArgs e)
    {
        string naam;
        naam = txtNaam.Text;
        lblBoodschap.Text = "Welkom " + naam + ". De datum is " + calKalender.SelectedDate;
    }
}