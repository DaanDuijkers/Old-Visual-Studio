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

    string[] namen = { "Mudi", "Van der Heijden", "Asshole" };

    protected void btnStart_Click(object sender, EventArgs e)
    {
        foreach(string c in namen)
        {
            lblOutput.Text += c + "<br />";
        }
    }

    protected void btnClean_Click(object sender, EventArgs e)
    {
        lblOutput.Text = "";
    }
}