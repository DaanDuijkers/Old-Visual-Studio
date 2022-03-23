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
    SqlConnection con = new SqlConnection(
        @"Data Source=LAPTOP-22DSHTEM\SQLEXPRESS;
        Initial Catalog = Gildeopleidingen1;
        Integrated Security = True;"
    );
    SqlCommand command = new SqlCommand();
    string cmd;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnShowData_Click(object sender, EventArgs e)
    {
        DataTable dt = new DataTable();

        con.Open();
        cmd = "SELECT * FROM Opleiding";
        SqlDataAdapter da = new SqlDataAdapter(cmd, con);
        
        try
        {
            da.Fill(dt);
            gvShow.DataSource = dt;
            gvShow.DataBind();
        }
        catch(Exception ex)
        {
            Response.Write(ex.Message);
        }
        finally
        {
            dt.Dispose();
            da.Dispose();
            con.Close();
        }
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        string oplName = txbOpleidingNaam.Text;
        string oplNiveau = txbOpleidingNiveau.Text;
        string duur = txbStudieduur.Text;
        string omschrijving = txbOmschrijving.Text;
        double kosten = Convert.ToDouble(txbKosten.Text);
        DateTime calDatum = calKalender.SelectedDate;

        int result = 0;

        cmd = "INSERT INTO Opleiding (Opleiding_Naam,Niveau,Studieduur,Omschrijving,kosten,Startdatum) values(@Opleiding_naam,@Niveau,@Studieduur,@Omschrijving,@Kosten,@Startdatum)";
        command = new SqlCommand(cmd, con);

        command.Parameters.AddWithValue("@Opleiding_Naam", oplName);
        command.Parameters.AddWithValue("@Niveau", oplNiveau);
        command.Parameters.AddWithValue("@Studieduur", duur);
        command.Parameters.AddWithValue("@Omschrijving", omschrijving);
        command.Parameters.AddWithValue("@kosten", kosten);
        command.Parameters.AddWithValue("@Startdatum", calDatum);

        con.Open();
        result = command.ExecuteNonQuery(); 

        if(result > 0)
        {
            lblOutput.ForeColor = System.Drawing.Color.Green;
            lblOutput.Text = "Opleiding Saved";
            txbOpleidingNaam.Text = "";
            txbKosten.Text = "";

            con.Close();
        }
        else
        {
            lblOutput.Text = "Opleiding not Saved";
            con.Close();
        }
    }
}