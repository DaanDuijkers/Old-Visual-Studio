using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        show_data(); 
    }

    private void show_data()
    {
        DataTable dt = new DataTable();
        SqlConnection con = new SqlConnection(
            @"Data Source=LAPTOP-22DSHTEM\SQLEXPRESS;
            Initial Catalog = Gildeopleidingen1;
            Integrated Security = True;"
        );
        SqlCommand cmd = new SqlCommand("SELECT * FROM Opleiding", con);
        con.Open();

        SqlDataReader dr = cmd.ExecuteReader();
        dt.Load(dr);
        gvTest.DataSource = dt;
        gvTest.DataBind();
        con.Close();
    }
}