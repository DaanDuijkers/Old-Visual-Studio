using System;
using System.Collections;
using System.IO;

public partial class Paginas_Management_ManageProducts : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            GetImages();

            if (!String.IsNullOrWhiteSpace(Request.QueryString["id"]))
            {
                int id = Convert.ToInt32(Request.QueryString["id"]);
                FillPage(id);
            }
        }
    }

    private void FillPage(int id)
    {
        clsProducten productModel = new clsProducten();
        Product product = productModel.GetProduct(id);

        txbDescription.Text = product.Description;
        txbName.Text = product.Name;
        txbPrice.Text = product.Price.ToString();

        ddlImage.SelectedValue = product.Image;
        ddlImage.SelectedValue = product.TypeId.ToString();
    }

    private void GetImages()
    {
            string[] images = Directory.GetFiles(Server.MapPath("~/Images/Producten/"));

            ArrayList imageList = new ArrayList();
            foreach (string image in images)
            {
                string imageName = image.Substring(image.LastIndexOf(@"\", StringComparison.Ordinal) + 1);
                imageList.Add(imageName);
            }

            ddlImage.DataSource = imageList;
            ddlImage.AppendDataBoundItems = true;
            ddlImage.DataBind();
        }

    private Product CreateProduct()
    {
        Product product = new Product();

        product.Name = txbName.Text;
        product.Price = Convert.ToDecimal(txbPrice.Text);
        product.TypeId = Convert.ToInt32(ddlType.SelectedValue);
        product.Description = txbDescription.Text;
        product.Image = ddlImage.SelectedValue;

        return product;
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        clsProducten productModel = new clsProducten();
        Product product = CreateProduct();

        if (!String.IsNullOrWhiteSpace(Request.QueryString["Id"]))
        {
            int id = Convert.ToInt32(Request.QueryString["Id"]);
            lblResult.Text = productModel.UpdateProduct(id, product);
        }
        else
        {
            lblResult.Text = productModel.InsertProduct(product);
        }
    }
}