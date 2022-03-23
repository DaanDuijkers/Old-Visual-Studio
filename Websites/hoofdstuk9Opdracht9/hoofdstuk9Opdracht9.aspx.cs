using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class hoofdstuk9Opdracht9 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnClick_Click(object sender, EventArgs e)
    {
        string naam = txbNaam.Text;
        int uur = DateTime.Now.Hour;

        switch(uur)
        {
            case 0:
                lblOutput.Text = "Goedenacht " + naam + ", hoe gaat het?";
            break;
            case 1:
                lblOutput.Text = "Goedenacht " + naam + ", hoe gaat het?";
            break;
            case 2:
                lblOutput.Text = "Goedenacht " + naam + ", hoe gaat het?";
            break;
            case 3:
                lblOutput.Text = "Goedenacht " + naam + ", hoe gaat het?";
            break;
            case 4:
                lblOutput.Text = "Goedenacht " + naam + ", hoe gaat het?";
            break;
            case 5:
                lblOutput.Text = "Goedenacht " + naam + ", hoe gaat het?";
            break;
            case 6:
                lblOutput.Text = "Goedenacht " + naam + ", hoe gaat het?";
            break;
            case 7:
                lblOutput.Text = "Goedenacht " + naam + ", hoe gaat het?";
            break;
            case 8:
                lblOutput.Text = "Goedemorgen " + naam + ", hoe gaat het?";
            break;
            case 9:
                lblOutput.Text = "Goedemorgen " + naam + ", hoe gaat het?";
            break;
            case 10:
                lblOutput.Text = "Goedemorgen " + naam + ", hoe gaat het?";
            break;
            case 11:
                lblOutput.Text = "Goedemorgen " + naam + ", hoe gaat het?";
            break;
            case 12:
                lblOutput.Text = "Goedemiddag " + naam + ", hoe gaat het?";
            break;
            case 13:
                lblOutput.Text = "Goedemiddag " + naam + ", hoe gaat het?";
            break;
            case 14:
                lblOutput.Text = "Goedemiddag " + naam + ", hoe gaat het?";
            break;
            case 15:
                lblOutput.Text = "Goedemiddag " + naam + ", hoe gaat het?";
            break;
            case 16:
                lblOutput.Text = "Goedemiddag " + naam + ", hoe gaat het?";
            break;
            case 17:
                lblOutput.Text = "Goedemiddag " + naam + ", hoe gaat het?";
            break;
            case 18:
                lblOutput.Text = "Goedenavond " + naam + ", hoe gaat het?";
            break;
            case 19:
                lblOutput.Text = "Goedenavond " + naam + ", hoe gaat het?";
            break;
            case 20:
                lblOutput.Text = "Goedenavond " + naam + ", hoe gaat het?";
            break;
            case 21:
                lblOutput.Text = "Goedenavond " + naam + ", hoe gaat het?";
            break;
            case 22:
                lblOutput.Text = "Goedenavond " + naam + ", hoe gaat het?";
            break;
            case 23:
                lblOutput.Text = "Goedenacht " + naam + ", hoe gaat het?";
            break;
        }
    }
}