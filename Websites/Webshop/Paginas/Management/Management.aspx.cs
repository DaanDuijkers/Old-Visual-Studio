using System;
using System.Web.UI.WebControls;

public partial class Paginas_Management_Management : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void grdProducts_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridViewRow row = grdProducts.Rows[e.NewEditIndex];

        int rowId = Convert.ToInt32(row.Cells[1].Text);

        Response.Redirect("~/Paginas/Management/ManageProducts.aspx?id=" + rowId);
    }
}