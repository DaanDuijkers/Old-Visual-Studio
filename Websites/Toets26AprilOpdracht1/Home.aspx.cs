using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Home : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);

    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (txbName.Text == "" || txbCapital.Text == "" || txbLanguage.Text == "")
            {
                lblOutput.Text = "Information Not Saved! Check input";
            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into Country values('" + txbName.Text + "', '" + txbCapital.Text + "', '" + txbLanguage.Text + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                lblOutput.Text = "Information Saved!";
            }
            
        }
        catch(Exception ex)
        {
            lblOutput.Text = ex.Message;
        }
        
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        txbName.Text = "";
        txbCapital.Text = "";
        txbLanguage.Text = "";
        lbOutput.Text = "";
        lblOutput.Text = "";
    }

    protected void btnShowData_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-22DSHTEM\SQLEXPRESS;Initial Catalog=Country;Integrated Security=True");
        SqlDataAdapter sda = new SqlDataAdapter("Select * from Countries", conn);
        DataTable dt = new DataTable();
        sda.Fill(dt);
        foreach(DataRow row in dt.Rows)
        {
            lbOutput.Items.Add(row["Country"].ToString());
        }
    }
}