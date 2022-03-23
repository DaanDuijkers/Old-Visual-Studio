using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (clsClient.ID <= 0)
        {
            lnkAccount.Visible = false;
            lnkCart.Visible = false;
            lnkLogout.Visible = false;
        }
    }

    protected void lnkLogout_Click(object sender, EventArgs e)
    {
        clsClient.ID = 0;
        Response.Redirect("~/Index.aspx");
    }
}
