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

    }

    protected void btnMaakKaart_Click(object sender, EventArgs e)
    {
        // aanmaken van variabelen (=Declareren)
        string Naam, Geslacht, Hobby, Opleiding;
        Naam = txtNaam.Text;
        Geslacht = rbGeslacht.SelectedValue;
        Opleiding = chkHobby.SelectedValue;
        Hobby = "Hobby: ";
        if(chkHobby.SelectedValue == "1")
            {
                Hobby += "Gamen ";
            }
        if (chkHobby.SelectedValue == "2")
            {
                Hobby += "Programmeren";
            }
        lblOutcome.Text = "\nNaam: " + Naam + "; " +
            Hobby + "; " +
            "Opleiding: " + Opleiding + "; " +
            "Geslacht: " + Geslacht;
    }
}