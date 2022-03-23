using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class _Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(
            @"Data Source=(localdb)\MSSQLLocalDB;
            Initial Catalog=Gildeopleidingen;
            Integrated Security=True;
            Connect Timeout=30;
            Encrypt=False;
            TrustServerCertificate=True;
            ApplicationIntent=ReadWrite;
            MultiSubnetFailover=False"
        );

    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        txbNaam.Text = string.Empty;
        txbNiveau.Text = string.Empty;
        txbStudieduur.Text = string.Empty;
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (txbNaam.Text == "" || txbNiveau.Text == "" || txbStudieduur.Text == "")
            {
                lblOutput.BackColor = System.Drawing.Color.Red;
                lblOutput.Text = "Information Not Saved! Check input";
            }
            else
            {
                con.Open();
                    SqlCommand cmd = new SqlCommand(
                        "INSERT INTO Opleiding VALUES('" + txbNaam.Text + "', '" + txbNiveau.Text + "', '" + txbStudieduur.Text + "')", 
                        con);
                    cmd.ExecuteNonQuery();
                con.Close();

                lblOutput.BackColor = System.Drawing.Color.Green;
                lblOutput.Text = "Information Saved!";
            }

        }
        catch (Exception ex)
        {
            lblOutput.Text = ex.Message;
        }
    }

    protected void btnShowData_Click(object sender, EventArgs e)
    {
        lbDatabase.Items.Clear();
        con.Open();
        SqlCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "SELECT * FROM Opleiding";
        cmd.ExecuteNonQuery();
        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(dt);
        con.Close();
        foreach(DataRow dr in dt.Rows)
        {
            lbDatabase.Items.Add(dr["naam"].ToString());
            lbDatabase.Items.Add(dr["niveau"].ToString());
            lbDatabase.Items.Add(dr["studieduur"].ToString());
        }
    }
}