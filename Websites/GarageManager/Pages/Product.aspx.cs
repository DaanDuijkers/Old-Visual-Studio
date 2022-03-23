﻿using Microsoft.AspNet.Identity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
            ProductModel productModel = new ProductModel();
            Product product = productModel.GetProduct(id);

            lblPrice.Text = "Price per unit: <br />$ " + product.Price;
            lblTitle.Text = product.Name;
            lblDescription.Text = product.Description;
            lblItemNr.Text = id.ToString();
            imgProduct.ImageUrl = "~/Images/Products/" + product.Image;

            int[] amount = Enumerable.Range(1, 20).ToArray();
            ddlAmount.DataSource = amount;
            ddlAmount.AppendDataBoundItems = true;
            ddlAmount.DataBind();
        }
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        string clientId = Context.User.Identity.GetUserId();

        if (clientId != null)
        {
            int id = Convert.ToInt32(Request.QueryString["ID"]);
            int amount = Convert.ToInt32(ddlAmount.SelectedValue);

            Cart cart = new Cart
            {
                Amount = amount,
                ClientId = clientId,
                DatePurchased = DateTime.Now,
                IsInCart = true,
                ProductId = id
            };

            CartModel model = new CartModel();
            lblResult.Text = model.InsertCart(cart);
        }
        else
        {
            lblResult.Text = "Please log in to order items";
        }
    }
}