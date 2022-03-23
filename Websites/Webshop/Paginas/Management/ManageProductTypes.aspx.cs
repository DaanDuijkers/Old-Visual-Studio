using System;

public partial class Pages_Management_ManageProductTypes : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        clsType model = new clsType();
        Type pt = CreateProductType();

        lblResult.Text = model.InsertType(pt);
    }

    private Type CreateProductType()
    {
        Type p = new Type();
        p.TypeName = txtName.Text;

        return p;
    }
}