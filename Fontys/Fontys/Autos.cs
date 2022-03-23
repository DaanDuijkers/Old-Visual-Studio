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
    public partial class frmAutos : Form
    {
        SqlConnection con = new SqlConnection(
            @"Data Source=LAPTOP-22DSHTEM\SQLEXPRESS;
            Initial Catalog=Fontys;
            Integrated Security=true;
        ");
        SqlCommand cmd;
        SqlDataAdapter adapt;

        //ID variable used in Updating and Deleting Record  
        int ID = 0;

        public frmAutos()
        {
            InitializeComponent();
            DisplayData();
        }

        //Display Data in DataGridView  
        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("SELECT * FROM auto", con);
            adapt.Fill(dt);
            gvAuto.DataSource = dt;
            con.Close();
        }

        //Clear Data  
        private void ClearData()
        {
            txbMerk.Text = string.Empty;
            cmbKleur.Text = string.Empty;
            txbKenteken.Text = string.Empty;
            txbPrijs.Text = string.Empty;
            ID = 0;
        }

        // Insert Data
        private void btnInsert_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txbMerk.Text != string.Empty && cmbKleur.Text != string.Empty && txbPrijs.Text != string.Empty)
                {
                    cmd = new SqlCommand(
                        "INSERT INTO auto(Kenteken,Merk,Kleur,Prijs) values(@Kenteken,@Merk,@Kleur,@Prijs)",
                        con);

                    con.Open();
                        cmd.Parameters.AddWithValue("@Kenteken", txbKenteken.Text);
                        cmd.Parameters.AddWithValue("@Merk", txbMerk.Text);
                        cmd.Parameters.AddWithValue("@Kleur", cmbKleur.Text);
                        cmd.Parameters.AddWithValue("@Prijs", txbPrijs.Text);
                        cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Het record is toegevoegd!");
                    DisplayData();
                    ClearData();
                }
                else
                {
                    MessageBox.Show("Voer eerst de data in als u een record wil toevoegen");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + " Tip: gebruik bij de tekstbox 'Prijs' een punt in plaats van een komma!");
            }
        }

        // gvAuto RowHeaderMouseClick Event  
        private void gvAuto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(gvAuto.Rows[e.RowIndex].Cells[0].Value.ToString());
            txbKenteken.Text = gvAuto.Rows[e.RowIndex].Cells[1].Value.ToString();
            txbMerk.Text = gvAuto.Rows[e.RowIndex].Cells[2].Value.ToString();
            cmbKleur.Text = gvAuto.Rows[e.RowIndex].Cells[3].Value.ToString();
            txbPrijs.Text = gvAuto.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        // Update Record
        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txbMerk.Text != string.Empty && cmbKleur.Text != string.Empty)
                {
                    cmd = new SqlCommand(
                        "UPDATE auto SET Kenteken=@Kenteken,Merk=@Merk,Kleur=@Kleur WHERE Id=@Id",
                        con);

                    con.Open();
                        cmd.Parameters.AddWithValue("@Id", ID);
                        cmd.Parameters.AddWithValue("@Kenteken", txbKenteken.Text);
                        cmd.Parameters.AddWithValue("@Merk", txbMerk.Text);
                        cmd.Parameters.AddWithValue("@Kleur", cmbKleur.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Het record is aangepast!");
                    con.Close();

                    DisplayData();
                    ClearData();
                }
                else
                {
                    MessageBox.Show("Selecteer eerst een record om aan te passen");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + " Tip: gebruik bij de tekstbox 'Prijs' een punt in plaats van een komma!");
            }
        }

        //Delete Record
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (ID != 0)
                {
                    cmd = new SqlCommand(
                        "DELETE auto WHERE Id=@Id",
                        con);

                    con.Open();
                        cmd.Parameters.AddWithValue("@Id", ID);
                        cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Het record is verwijderd!");
                    DisplayData();
                    ClearData();
                }
                else
                {
                    MessageBox.Show("Selecteer eerst een record om te verwijderen");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}