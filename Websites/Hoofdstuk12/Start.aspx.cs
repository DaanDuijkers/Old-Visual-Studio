using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Start : System.Web.UI.Page
{
    string connstring;

    protected void Page_Load(object sender, EventArgs e)
    {
        connstring = @"Data Source=(localdb)\MSSQLLocalDB;";
        connstring += "Initial Catalog=Agenda;";
        connstring += "Integrated Security=True";

        if (this.IsPostBack == false)
        {
            string tijd;
            for (int uur = 8; uur <= 23; uur++)
            {
                tijd = uur.ToString() + ":00";
                lbTijd.Items.Add(tijd);
                tijd = uur.ToString() + ":30";
                lbTijd.Items.Add(tijd);
            }
        }
       calAgenda.SelectedDate = System.DateTime.Now;
       calAgenda_SelectionChanged(sender, e);
    }

    protected void calAgenda_SelectionChanged(object sender, EventArgs e)
    {
        string sql;
        sql = "SELECT item_id, dag, tijd + ' ' + bericht AS item ";
        sql += "FROM Afspraak ";
        sql += "WHERE dag='" + calAgenda.SelectedDate.ToString("yyyy-MM-dd") + "' ";
        sql += "ORDER BY tijd ";
        SqlDataAdapter DA = new SqlDataAdapter(sql, connstring);
        DataSet DS = new DataSet();
        DA.Fill(DS);
        lbBerichten.DataSource = DS.Tables[0];
        lbBerichten.DataTextField = "item";
        lbBerichten.DataValueField = "item_id";
        lbBerichten.DataBind();
        if (lbBerichten.Items.Count>0)
        {
            lbBerichten.Items[0].Selected = true;
            lbBerichten_SelectedIndexChanged(sender, e);
        }
    }

    protected void lbBerichten_SelectedIndexChanged(object sender, EventArgs e)
    {
        if(lbBerichten.SelectedIndex!=-1)
        {
            string tijd;
            tijd = lbBerichten.SelectedItem.ToString().Substring(0, 5);
            for(int uur=0;uur<lbTijd.Items.Count-1;uur++)
            {
                if(lbTijd.Items[uur].Text==tijd)
                {
                    lbTijd.SelectedIndex = uur;
                    lbTijd_SelectedIndexChanged(sender, e);
                }
            }
        }
    }

    protected void lbTijd_SelectedIndexChanged(object sender, EventArgs e)
    {
        string sql;
        sql = "SELECT bericht ";
        sql += "FROM Afspraak ";
        sql += "WHERE dag='" + calAgenda.SelectedDate.ToString("yyyy-MM-dd") + "' ";
        sql += "AND tijd='" + lbTijd.SelectedItem.Text + "'";
        SqlDataAdapter DA = new SqlDataAdapter(sql, connstring);
        DataSet DS = new DataSet();
        DS.Clear();
        DA.Fill(DS);
        if (DS.Tables[0].Rows.Count>0)
        {
            txbBericht.Text = Convert.ToString(DS.Tables[0].Rows[0].ItemArray[0]);
        }
        else
        {
            txbBericht.Text = string.Empty;
        }
    }

    protected void btnBewaren_Click(object sender, ImageClickEventArgs e)
    {
        string sql;
        sql = "SELECT bericht ";
        sql += "FROM Afspraak ";
        sql += "WHERE dag='" + calAgenda.SelectedDate.ToString("yyyy-MM-dd") + "' ";
        sql += "AND tijd='" + lbTijd.SelectedItem.Text + "'";
        SqlDataAdapter DA = new SqlDataAdapter(sql, connstring);
        DataSet DS = new DataSet();
        DS.Clear();
        DA.Fill(DS);
        if(DS.Tables[0].Rows.Count==0)
        {
            sql = "INSERT INTO Afspraak (dag, tijd, bericht) values ";
            sql += "('" + calAgenda.SelectedDate.ToString("yyyy-MM-dd") + "', ";
            sql += "'" + lbTijd.SelectedItem.Text + "', ";
            sql += "'" + txbBericht.Text + "')";
            SqlConnection Conn = new SqlConnection(connstring);
            Conn.Open();
            SqlCommand Cmd = new SqlCommand(sql, Conn);
            int aantal = Cmd.ExecuteNonQuery();
            Conn.Close();
        }
        else
        {
            sql = "UPDATE Afspraak ";
            sql += "SET bericht='" + txbBericht.Text + "' ";
            sql += "WHERE dag='" + calAgenda.SelectedDate.ToString("yyyy-MM-dd") + "' ";
            sql += "AND tijd='" + lbTijd.SelectedItem.Text + "'";
            SqlConnection Conn = new SqlConnection(connstring);
            Conn.Open();
            SqlCommand Cmd = new SqlCommand(sql, Conn);
            int aantal = Cmd.ExecuteNonQuery();
            Conn.Close();
        }
        int tijdnr = lbTijd.SelectedIndex;
        calAgenda_SelectionChanged(sender, e);
        lbTijd.SelectedIndex = tijdnr;
        lbTijd_SelectedIndexChanged(sender, e);
    }

    protected void btnAnnuleren_Click(object sender, ImageClickEventArgs e)
    {
        string sql;
        sql = "DELETE FROM Afspraak ";
        sql += "WHERE dag='" + calAgenda.SelectedDate.ToString("yyyy-MM-dd") + "' ";
        sql += "AND tijd='" + lbTijd.SelectedItem.Text + "'";
        SqlConnection Conn = new SqlConnection(connstring);
        Conn.Open();
        SqlCommand Cmd = new SqlCommand(sql, Conn);
        int aantal = Cmd.ExecuteNonQuery();
        Conn.Close();
        int tijdnr = lbTijd.SelectedIndex;
        calAgenda_SelectionChanged(sender, e);
        lbTijd.SelectedIndex = tijdnr;
        lbTijd_SelectedIndexChanged(sender, e);
    }

    protected void lbBerichten_SelectedIndexChanged1(object sender, EventArgs e)
    {

    }

    protected void lbBerichten_SelectedIndexChanged2(object sender, EventArgs e)
    {
        if (lbBerichten.SelectedIndex!=-1)
        {
            string tijd;
            tijd = lbBerichten.SelectedItem.ToString().Substring(0, 5);
            for (int uur=0;uur<lbTijd.Items.Count-1;uur++)
            {
                if (lbTijd.Items[uur].Text==tijd)
                {
                    lbTijd.SelectedIndex = uur;
                    lbTijd_SelectedIndexChanged(sender, e);
                }
            }
        }
    }
}