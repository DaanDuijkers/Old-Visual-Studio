using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

public partial class Index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void ddlSpelers_SelectedIndexChanged(object sender, EventArgs e)
    {
        string mainconn = ConfigurationManager.ConnectionStrings["TennistoernooiConnectionString"].ToString();
        SqlConnection sqlconn = new SqlConnection(mainconn);
        string sqlquery = "SELECT * FROM SPELER WHERE Speler_Voornaam='" + ddlSpelers.SelectedItem.Text + "';";

        sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            grdSpelers.DataSource = dt;
            grdSpelers.DataBind();
        sqlconn.Close();
    }
}