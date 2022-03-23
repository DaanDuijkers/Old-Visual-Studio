﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;

public partial class Pages_ShoppingCart : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int userId = clsClient.ID;

        if (userId > 0)
        {
            GetPurchasesInCart(userId.ToString());
        }
        else
        {
            Response.Redirect("~/Index.aspx");
        }
    }

    private void GetPurchasesInCart(string userId)
    {
        clsCart model = new clsCart();
        double subTotal = 0;

        List<Cart> purchaseList = model.GetOrdersInCart(Convert.ToInt32(userId));
        CreateShopTable(purchaseList, out subTotal);

        double vat = subTotal * 0.21;
        double totalAmount = subTotal + vat + 15;

        litTotal.Text = "€ " + subTotal;
        litVat.Text = "€ " + vat;
        litTotalAmount.Text = "€ " + totalAmount;
    }

    private void CreateShopTable(List<Cart> purchaseList, out double subTotal)
    {
        subTotal = new double();
        clsProducten model = new clsProducten();

        foreach (Cart cart in purchaseList)
        {
            Product product = model.GetProduct(cart.ProductId);

            ImageButton btnImage = new ImageButton
            {
                ImageUrl = string.Format("~/Images/Producten/{0}", product.Image),
                PostBackUrl = string.Format("~/Paginas/Product.aspx?id={0}", product.Id)
            };

            LinkButton lnkDelete = new LinkButton
            {
                PostBackUrl = string.Format("~/Paginas/ShoppingCart.aspx?productId={0}", cart.Id),
                Text = "Delete Item",
                ID = "del" + cart.Id
            };

            lnkDelete.Click += Delete_Item;

            int[] amount = Enumerable.Range(1, 20).ToArray();
            DropDownList ddlAmount = new DropDownList
            {
                DataSource = amount,
                AppendDataBoundItems = true,
                AutoPostBack = true,
                ID = cart.Id.ToString()
            };

            ddlAmount.DataBind();
            ddlAmount.SelectedValue = cart.Amount.ToString();
            ddlAmount.SelectedIndexChanged += ddlAmount_SelectedIndexChanged;

            Table table = new Table { CssClass = "cartTable" };
            TableRow a = new TableRow();
            TableRow b = new TableRow();

            TableCell a1 = new TableCell { RowSpan = 2, Width = 50 };
            TableCell a2 = new TableCell { Text = string.Format("<h4>{0}</h4><br />{1}<br />In Stock",
                product.Name, "Item No: " + product.Id ), HorizontalAlign = HorizontalAlign.Left, Width = 350 };
            TableCell a3 = new TableCell { Text = "Unit Price<hr />"};
            TableCell a4 = new TableCell { Text = "Quantity<hr />" };
            TableCell a5 = new TableCell { Text = "Item Total<hr />" };
            TableCell a6 = new TableCell { };

            TableCell b1 = new TableCell { };
            TableCell b2 = new TableCell { Text = "€ " + product.Price};
            TableCell b3 = new TableCell { };
            TableCell b4 = new TableCell { Text = "€ " + Math.Round((double)(cart.Amount * product.Price), 2) };
            TableCell b5 = new TableCell { };
            TableCell b6 = new TableCell { };

            a1.Controls.Add(btnImage);
            a2.Controls.Add(lnkDelete);
            a3.Controls.Add(ddlAmount);

            a.Cells.Add(a1);
            a.Cells.Add(a2);
            a.Cells.Add(a3);
            a.Cells.Add(a4);
            a.Cells.Add(a5);
            a.Cells.Add(a6);

            b.Cells.Add(b1);
            b.Cells.Add(b2);
            b.Cells.Add(b3);
            b.Cells.Add(b4);
            b.Cells.Add(b5);
            b.Cells.Add(b6);

            table.Rows.Add(a);
            table.Rows.Add(b);

            pnlShoppingCart.Controls.Add(table);
            
            subTotal += (double)(cart.Amount * product.Price);
        }
    }

    private void ddlAmount_SelectedIndexChanged(object sender, EventArgs e)
    {
        DropDownList selectedList = (DropDownList)sender;
        int quantity = Convert.ToInt32(selectedList.SelectedValue);
        int cartId = Convert.ToInt32(selectedList.ID);

        clsCart model = new clsCart();
        model.UpdateQuantity(cartId, quantity);
        Response.Redirect("~/Paginas/ShoppingCart.aspx");
    }

    private void Delete_Item(object sender, EventArgs e)
    {
        LinkButton selectedLink = (LinkButton)sender;
        string link = selectedLink.ID.Replace("del", "");
        int cartId = Convert.ToInt32(link);

        clsCart model = new clsCart();
        model.DeleteCart(cartId);

        Response.Redirect("~/Paginas/ShoppingCart.aspx");
    }
}