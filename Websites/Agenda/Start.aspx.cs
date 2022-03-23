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

        if (this.IsPostBack == true)
        {
            string tijd;
            for(int uur = 8; uur <= 23; uur++)
            {
                tijd = uur.ToString() + ":00";
                lbTijd.Items.Add(tijd);
                tijd = uur.ToString() + ":30";
                lbTijd.Items.Add(tijd);
            }
            calAgenda.SelectedDate = System.DateTime.Now;
            calAgenda_SelectionChanged(sender, e);
        }
    }

    protected void calAgenda_SelectionChanged(object sender, EventArgs e)
    {
        string sql;
        sql = "Select Item_id, dag, tijd + '' + bericht AS item ";
        sql += "FROM Afspraak ";
        sql += "WHERE dag='" + calAgenda.SelectedDate.ToString("yyyy-MM-dd") + "' ";
        sql += "ORDER BY tijd ";
        SqlDataAdapter DA = new SqlDataAdapter(sql, connstring);
        DataSet DS = new DataSet();
        DA.Fill(DS);
        lbAfspraken.DataSource = DS.Tables[0];
        lbAfspraken.DataTextField = "item";
        lbAfspraken.DataValueField = "Item_id";
        lbAfspraken.DataBind();
        if(lbAfspraken.Items.Count > 0)
        {
            lbAfspraken.Items[0].Selected = true;
        }
    }

    protected void lbAfspraken_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (lbAfspraken.SelectedIndex != -1)
        {
            string tijd;
            tijd = lbAfspraken.SelectedItem.ToString().Substring(0, 5);
            for (int uur = 0; uur < lbTijd.Items.Count - 1; uur++)
            {
                if (lbTijd.Items[uur].Text == tijd)
                {
                    lbTijd.SelectedIndex = uur;
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
        if(DS.Tables[0].Rows.Count>0)
        {
            txbBericht.Text = Convert.ToString(DS.Tables[0].Rows[0].ItemArray[0]);
        }
        else
        {
            txbBericht.Text = "Error";
        }
    }
}