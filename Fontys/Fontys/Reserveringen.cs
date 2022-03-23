using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Fontys
{
    public partial class frmReserveringen : Form
    {
        SqlConnection cn = new SqlConnection(
            @"Data Source=LAPTOP-22DSHTEM\SQLEXPRESS;
            Initial Catalog=Fontys;
            Integrated Security=true;
        ");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        SqlDataAdapter adapt;

        //ID variable used in Updating and Deleting Record  
        int ID = 0;

        public frmReserveringen()
        {
            InitializeComponent();
            DisplayData();
        }

        //Display Data in DataGridView  
        private void DisplayData()
        {
            cn.Open();
                DataTable dt = new DataTable();
                adapt = new SqlDataAdapter("SELECT * FROM reservering", cn);
                adapt.Fill(dt);
                dgvReserveringen.DataSource = dt;
            cn.Close();
        }

        //Clear Data  
        private void ClearData()
        {
            calBeginEindDatum.SelectionStart = DateTime.Now;
            calBeginEindDatum.SelectionEnd = DateTime.Now;
            lvKlant.Refresh();
            lvAuto.Refresh();
            ID = 0;
        }

        private void Reserveringen_Load_1(object sender, EventArgs e)
        {
            cn.Open();
                string FetchKlant = ("SELECT * FROM klant");
                cmd = new SqlCommand(FetchKlant, cn);
                dr = cmd.ExecuteReader();
            
                while(dr.Read())
                {
                    ListViewItem lv = new ListViewItem(dr[0].ToString());
                    lv.SubItems.Add(dr[3].ToString());
                    lv.SubItems.Add(dr[2].ToString());
                    lv.SubItems.Add(dr[1].ToString());
                    lv.SubItems.Add(dr[4].ToString());
                    lvKlant.Items.Add(lv);
                }
            cn.Close();

            cn.Open();
                string FetchAuto = ("SELECT * FROM auto");
                cmd = new SqlCommand(FetchAuto, cn);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    ListViewItem lv = new ListViewItem(dr[0].ToString());
                    lv.SubItems.Add(dr[1].ToString());
                    lv.SubItems.Add(dr[2].ToString());
                    lv.SubItems.Add(dr[3].ToString());
                    lvAuto.Items.Add(lv);
                }
            cn.Close();
        }

        private int haalPrijsOpVanAuto(int autoId)
        {
            cmd = new SqlCommand(
                "SELECT prijs FROM auto WHERE Id = " + autoId,
                cn);

            cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                int prijs = Convert.ToInt32(dr["prijs"]);
            cn.Close();

            return prijs;
        }
        
        private void btnReserveren_Click(object sender, EventArgs e)
        {
            try
            {
                int prijs = haalPrijsOpVanAuto(Convert.ToInt32(lvAuto.SelectedItems[0].Text));

                DateTime startdate = calBeginEindDatum.SelectionStart;
                DateTime enddate = calBeginEindDatum.SelectionEnd;
                TimeSpan verschil;
                verschil = enddate - startdate;
                int totaalprijs = (verschil.Days + 1) * prijs;

                cmd = new SqlCommand(
                    "INSERT INTO reservering(Auto_Id,Klant_Id,Begin_Datum,Eind_Datum,Totaal_prijs) values(@Auto_Id,@Klant_Id,@Begin_Datum,@Eind_Datum,@Totaal_prijs)",
                    cn
                );
                cn.Open();
                    cmd.Parameters.AddWithValue("@Auto_Id", lvAuto.SelectedItems[0].Text);
                    cmd.Parameters.AddWithValue("@Klant_Id", lvKlant.SelectedItems[0].Text);
                    cmd.Parameters.AddWithValue("@Begin_Datum", startdate);
                    cmd.Parameters.AddWithValue("@Eind_Datum", enddate);
                    cmd.Parameters.AddWithValue("@Totaal_prijs", totaalprijs);
                    cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Het record is toegevoegd!");
                DisplayData();
                ClearData();

                btnReserveren.Enabled = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void calBeginEindDatum_Leave(object sender, EventArgs e)
        {
            btnReserveren.Enabled = true;
        }

        // Delete record
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Console.WriteLine("ID = " + ID);
            try
            {
                if (ID != 0)
                {
                    cmd = new SqlCommand(
                        "DELETE reservering WHERE Id=@Id", 
                        cn);

                    cn.Open();
                        cmd.Parameters.AddWithValue("@Id", ID);
                        cmd.ExecuteNonQuery();
                    cn.Close();

                    MessageBox.Show("Het record is verwijdert!");
                    DisplayData();
                    ClearData();
                }
                else
                {
                    MessageBox.Show("Please Select Record to Delete");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvReserveringen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(dgvReserveringen.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int prijs = haalPrijsOpVanAuto(Convert.ToInt32(lvAuto.SelectedItems[0].Text));

                DateTime startdate = calBeginEindDatum.SelectionStart;
                DateTime enddate = calBeginEindDatum.SelectionEnd;
                TimeSpan verschil;
                verschil = enddate - startdate;
                int totaalprijs = (verschil.Days + 1) * prijs;

                cmd = new SqlCommand(
                    "UPDATE reservering SET Auto_Id=@Auto_Id,Klant_Id=@Klant_Id,Begin_Datum=@Begin_Datum,Eind_Datum=@Eind_Datum,Totaal_prijs=@Totaal_prijs WHERE Id=@id",
                    cn);

                cn.Open();
                    cmd.Parameters.AddWithValue("@Id", ID);
                    cmd.Parameters.AddWithValue("@Auto_Id", lvAuto.SelectedItems[0].Text);
                    cmd.Parameters.AddWithValue("@Klant_Id", lvKlant.SelectedItems[0].Text);
                    cmd.Parameters.AddWithValue("@Begin_Datum", startdate);
                    cmd.Parameters.AddWithValue("@Eind_Datum", enddate);
                    cmd.Parameters.AddWithValue("@Totaal_prijs", totaalprijs);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Het record is aangepast");
                cn.Close();

                DisplayData();
                ClearData();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
