using System;
using System.Linq;

public partial class Pages_Product : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        FillPage();
    }

    private void FillPage()
    {
        if (!String.IsNullOrWhiteSpace(Request.QueryString["Id"]))
        {
            int id = Convert.ToInt32(Request.QueryString["Id"]);
            clsProducten productModel = new clsProducten();
            Product product = productModel.GetProduct(id);

            lblPrice.Text = "Prijs per stuk: <br />€ " + product.Price;
            lblTitle.Text = product.Name;
            lblDescription.Text = product.Description;
            lblItemNr.Text = id.ToString();
            imgProduct.ImageUrl = "~/Images/Producten/" + product.Image;

            int[] amount = Enumerable.Range(1, 20).ToArray();
            ddlAmount.DataSource = amount;
            ddlAmount.AppendDataBoundItems = true;
            ddlAmount.DataBind();
        }
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        int clientId = clsClient.ID;

        if (clientId > 0)
        {
            int id = Convert.ToInt32(Request.QueryString["Id"]);
            int amount = Convert.ToInt32(ddlAmount.SelectedValue);

            Cart cart = new Cart
            {
                Amount = amount,
                ClientId = clientId,
                IsInCart = true,
                ProductId = id
            };

            clsCart model = new clsCart();
            lblResult.Text = model.InsertCart(cart);
        }
        else
        {
            lblResult.Text = "Log eerst in";
        }
    }
}