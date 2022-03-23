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

    protected void btnClickMe_Click(object sender, EventArgs e)
    {
        string firstName = txbFirstName.Text;
        string familyName = txbFamilyName.Text;

        lblOutput.Text = "Welcome " + firstName + " " + familyName + " in ASP World";
    }
}