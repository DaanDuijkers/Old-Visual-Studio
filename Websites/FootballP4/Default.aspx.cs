using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class _Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(
            @"Data Source=(localdb)\MSSQLLocalDB;
            Initial Catalog=Football;
            Integrated Security=True;"
        );
    SqlCommand cmd = new SqlCommand();

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        txbName.Text = String.Empty;
        txbAddress.Text = String.Empty;
        rbFemale.Text = String.Empty;
        rbMale.Text = String.Empty;
        txbEmailAddress.Text = String.Empty;
        txbMobileNumber.Text = String.Empty;
        txbTeam.Text = String.Empty;

        gvPlayers.Visible = false;
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        string gender = string.Empty;
        if (rbMale.Checked)
        {
            gender = "M";
        }
        else if (rbFemale.Checked)
        {
            gender = "F";
        }

        try
        {
            if (txbName.Text == string.Empty || gender == string.Empty || txbAddress.Text == string.Empty || txbEmailAddress.Text == string.Empty || txbMobileNumber.Text == string.Empty || txbTeam.Text == string.Empty)
            {
               lblOutput.ForeColor = System.Drawing.Color.Red;
               lblOutput.Text = "Record Not Saved";
            }
            else
            {
                cmd = new SqlCommand(
                    "INSERT INTO Player (Name,Gender,Address,Email_address,Mobilenumber,Team) VALUES (@Name,@Gender,@Address,@Email_address,@Mobilenumber,@Team)",
                    con);

                con.Open();
                    cmd.Parameters.AddWithValue("@Name", txbName.Text);
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@Address", txbAddress.Text);
                    cmd.Parameters.AddWithValue("@Email_address", txbEmailAddress.Text);
                    cmd.Parameters.AddWithValue("@Mobilenumber", txbMobileNumber.Text);
                    cmd.Parameters.AddWithValue("@Team", txbTeam.Text);
                    cmd.ExecuteNonQuery();
                con.Close();

                lblOutput.ForeColor = System.Drawing.Color.Green;
                lblOutput.Text = "Player Saved";
            }
        }
        catch (Exception ex)
        {
            lblOutput.Text = ex.Message;
        }
        
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        try
        {
            cmd = new SqlCommand(
                "DELETE Player WHERE Name=@Name AND Address=@Address",
                con);

            con.Open();
                cmd.Parameters.AddWithValue("@Name", txbName.Text);
                cmd.Parameters.AddWithValue("@Address", txbAddress.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            lblOutput.Text = "Record Deleted";
        }
        catch (Exception ex)
        {
            lblOutput.Text = ex.Message;
        }
    }

    protected void btnShowData_Click(object sender, EventArgs e)
    {
        gvPlayers.Visible = true;

        con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Player", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gvPlayers.DataSource = dt;
            gvPlayers.DataBind();
        con.Close();
    }
}