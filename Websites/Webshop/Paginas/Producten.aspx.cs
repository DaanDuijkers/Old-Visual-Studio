using System;
using System.Linq;
using System.Collections.Generic;
using System.Web.UI.WebControls;

public partial class Paginas_Artikelen : System.Web.UI.Page
{
    WebshopEntities db = new WebshopEntities();

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    private void FillPage(bool descending = false)
    {
        clsProducten productModel = new clsProducten();
        List<Product> products = null;
        if (descending)
        {
            products = productModel.GetAllProducts().OrderByDescending(x => x.Price).ToList();
        }
        else
        {
            products = productModel.GetAllProducts().OrderBy(x => x.Price).ToList();
        }
        
        if (products != null)
        {
            foreach (Product product in products)
            {
                string insert = ddlType.SelectedItem.Text.ToString();

                Type type = (from x in db.Types 
                             where x.TypeName == insert 
                             select x).FirstOrDefault();

                int typeID = type.Id;
                int productTypeID = product.TypeId;

                if (productTypeID == typeID)
                {
                    Panel productPanel = new Panel();
                    ImageButton imageButton = new ImageButton
                    {
                        ImageUrl = "~/Images/Producten/" + product.Image,
                        CssClass = "productImage",
                        PostBackUrl = string.Format("~/Paginas/Product.aspx?id={0}", product.Id)
                    };
                    Label lblName = new Label
                    {
                        Text = product.Name,
                        CssClass = "productName"
                    };
                    Label lblOmschrijving = new Label
                    {
                        Text = product.Description
                    };
                    Label lblPrice = new Label
                    {
                        Text = "€ " + product.Price,
                        CssClass = "productPrice"
                    };
                    Button btnAdd = new Button
                    {
                        Text = "Stop in winkelmandje"
                    };
                    btnAdd.Click += delegate (object sender, EventArgs e) { btnAdd_Click(sender, e, product.Id); };

                    productPanel.Controls.Add(imageButton);
                    productPanel.Controls.Add(new Literal { Text = "<br />" });
                    productPanel.Controls.Add(lblName);
                    productPanel.Controls.Add(new Literal { Text = "<br />" });
                    productPanel.Controls.Add(lblOmschrijving);
                    productPanel.Controls.Add(new Literal { Text = "<br />" });
                    productPanel.Controls.Add(lblPrice);
                    productPanel.Controls.Add(new Literal { Text = "<br />" });
                    productPanel.Controls.Add(btnAdd);

                    pnlProducts.Controls.Add(productPanel);
                }
            }
        }
        else
        {
            pnlProducts.Controls.Add(new Literal { Text = "Niets tekoop!" });
        }
    }

    protected void btnAdd_Click(object sender, EventArgs e, int id)
    {
        int clientId = clsClient.ID;
        if (clientId > 0)
        {
            Cart cart = new Cart
            {
                Amount = 1,
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

    protected void ddlType_SelectedIndexChanged(object sender, EventArgs e)
    {
        FillPage();
    }

    protected void ddlOrder_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlOrder.Text == "Lage naar hoge prijs")
        {
            FillPage(false);
        }

        if (ddlOrder.Text == "Hoge naar lage prijs")
        {
            FillPage(true);
        }
    }
}