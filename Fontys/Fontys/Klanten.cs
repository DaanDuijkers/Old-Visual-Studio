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
    public partial class frmKlanten : Form
    {
        SqlConnection con = new SqlConnection(
            @"Data Source=LAPTOP-22DSHTEM\SQLEXPRESS;
            Initial Catalog=Fontys;
            Integrated Security=true;
        ");
        SqlCommand cmd;
        SqlDataAdapter adapt;

        // ID variable (used in Updating and Deleting Record)
        int ID = 0;

        public frmKlanten()
        {
            InitializeComponent();
            DisplayData();
        }

        //Display Data in DataGridView  
        private void DisplayData()
        {
            con.Open();
                DataTable dt = new DataTable();
                adapt = new SqlDataAdapter("SELECT * FROM klant", con);
                adapt.Fill(dt);
                gvKlant.DataSource = dt;
            con.Close();
        }

        //Clear Data  
        private void ClearData()
        {
            txbVoornaam.Text = string.Empty;
            txbTussenvoegsel.Text = string.Empty;
            txbAchternaam.Text = string.Empty;
            txbPostcode.Text = string.Empty;
            txbAdres.Text = string.Empty;
            txbWoonplaats.Text = string.Empty;
            txbTelefoon.Text = string.Empty;
            txbEmail.Text = string.Empty;
            ID = 0;
        }

        // Record opslaan
        private void btnOpslaan_Click(object sender, EventArgs e)
        {
            try
            {
                if (txbVoornaam.Text != string.Empty && txbAchternaam.Text != string.Empty && txbAdres.Text != string.Empty && txbWoonplaats.Text != string.Empty && txbTelefoon.Text != string.Empty && txbEmail.Text != string.Empty)
                {
                    cmd = new SqlCommand(
                        "INSERT INTO klant(achternaam,tussenvoegsel,voornaam,postcode,adres,woonplaats,telefoon,email) values(@Achternaam,@Tussenvoegsel,@Voornaam,@Postcode,@adres,@woonplaats,@telefoon,@email)",
                        con);

                    con.Open();
                        cmd.Parameters.AddWithValue("@Voornaam", txbVoornaam.Text);
                        cmd.Parameters.AddWithValue("@Tussenvoegsel", txbTussenvoegsel.Text);
                        cmd.Parameters.AddWithValue("@Achternaam", txbAchternaam.Text);
                        cmd.Parameters.AddWithValue("@Postcode", txbPostcode.Text);
                        cmd.Parameters.AddWithValue("@Adres", txbAdres.Text);
                        cmd.Parameters.AddWithValue("@Woonplaats", txbWoonplaats.Text);
                        cmd.Parameters.AddWithValue("@Telefoon", txbTelefoon.Text);
                        cmd.Parameters.AddWithValue("@Email", txbEmail.Text);
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Update record
        private void btnAanpassen_Click(object sender, EventArgs e)
        {
            try
            {
                if (txbVoornaam.Text != string.Empty && txbAchternaam.Text != string.Empty && txbAdres.Text != string.Empty && txbWoonplaats.Text != string.Empty && txbTelefoon.Text != string.Empty && txbEmail.Text != string.Empty)
                {
                    cmd = new SqlCommand(
                        "UPDATE klant SET Achternaam=@Achternaam,Tussenvoegsel=@Tussenvoegsel,Voornaam=@Voornaam,Postcode=@Postcode,Adres=@Adres,Woonplaats=@Woonplaats,Telefoon=@Telefoon,Email=@Email WHERE Id=@id",
                        con);

                    con.Open();
                        cmd.Parameters.AddWithValue("@Id", ID);
                        cmd.Parameters.AddWithValue("@Voornaam", txbVoornaam.Text);
                        cmd.Parameters.AddWithValue("@Tussenvoegsel", txbTussenvoegsel.Text);
                        cmd.Parameters.AddWithValue("@Achternaam", txbAchternaam.Text);
                        cmd.Parameters.AddWithValue("@Postcode", txbPostcode.Text);
                        cmd.Parameters.AddWithValue("@Adres", txbAdres.Text);
                        cmd.Parameters.AddWithValue("@Woonplaats", txbWoonplaats.Text);
                        cmd.Parameters.AddWithValue("@Telefoon", txbTelefoon.Text);
                        cmd.Parameters.AddWithValue("@Email", txbEmail.Text);
                        cmd.ExecuteNonQuery();
                    MessageBox.Show("Het record is aangepast!");
                    con.Close();

                    DisplayData();
                    ClearData();
                }
                else
                {
                    MessageBox.Show("Selecteer eerst een record om te aan te passen");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gvKlant_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(gvKlant.Rows[e.RowIndex].Cells[0].Value.ToString());
            txbVoornaam.Text = gvKlant.Rows[e.RowIndex].Cells[3].Value.ToString();
            txbTussenvoegsel.Text = gvKlant.Rows[e.RowIndex].Cells[2].Value.ToString();
            txbAchternaam.Text = gvKlant.Rows[e.RowIndex].Cells[1].Value.ToString();
            txbPostcode.Text = gvKlant.Rows[e.RowIndex].Cells[4].Value.ToString();
            txbAdres.Text = gvKlant.Rows[e.RowIndex].Cells[5].Value.ToString();
            txbWoonplaats.Text = gvKlant.Rows[e.RowIndex].Cells[6].Value.ToString();
            txbTelefoon.Text = gvKlant.Rows[e.RowIndex].Cells[7].Value.ToString();
            txbEmail.Text = gvKlant.Rows[e.RowIndex].Cells[8].Value.ToString();
        }

        // Delete record
        private void btnVerwijder_Click(object sender, EventArgs e)
        {
            try
            {
                if (ID != 0)
                {
                    cmd = new SqlCommand("DELETE klant WHERE Id=@Id", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@Id", ID);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Het record is verwijdert!");
                    DisplayData();
                    ClearData();
                }
                else
                {
                    MessageBox.Show("Selecteer eerst een record om te verwijderen");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
