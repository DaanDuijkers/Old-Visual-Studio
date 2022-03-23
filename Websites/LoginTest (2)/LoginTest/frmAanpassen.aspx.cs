using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginTest
{
    public partial class frmAanpassen : System.Web.UI.Page
    {
        public string username;
        public string password;
        public string lastName;
        public string insertion;
        public string firstName;
        public string addres;
        public string homeTown;
        public string email;

        clsAanpassen objAanpassen = new clsAanpassen();
        clsDelete objDelete = new clsDelete();

        private SqlConnection con = clsDatabase.Connect();
        private SqlCommand cmd = clsDatabase.Command();
        private SqlDataAdapter adapt = clsDatabase.DataAdapter();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (clsLogin.ID != 0)
            {
                con.Open();
                    cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT * FROM Pesoonlijke_Gegevens WHERE gebruiker_id=" + clsLogin.ID;
                    SqlDataReader rd = cmd.ExecuteReader();
                    rd.Read();

                    txbVoornaam.Text = rd[2].ToString();
                    txbTussenvoegsel.Text = rd[3].ToString();
                    txbAchternaam.Text = rd[4].ToString();
                    txbAdres.Text = rd[5].ToString();
                    txbWoonplaats.Text = rd[6].ToString();
                con.Close();
            }
            else
            {
                lblAccount.Text = "Log astublieft in";
            }
        }

        private string Encrypt(string value)
        {
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                byte[] data = md5.ComputeHash(utf8.GetBytes(value));
                return Convert.ToBase64String(data);
            }
        }

        protected void btnAanpassen_Click(object sender, EventArgs e)
        {
            if (clsLogin.ID != 0)
            {
                username = txbGebruikersnaam.Text;
                password = Encrypt(txbWachtwoord.Text);
                lastName = txbVoornaam.Text;
                insertion = txbTussenvoegsel.Text;
                firstName = txbVoornaam.Text;
                addres = txbAdres.Text;
                homeTown = txbWoonplaats.Text;
                email = txbEmail.Text;
                objAanpassen.checkAanpassenCredentials(username, password, lastName, insertion, firstName, addres, homeTown, email);

                bool check = objAanpassen.checkAanpassenCredentials(username, password, lastName, insertion, firstName, addres, homeTown, email);
                if (check == true)
                {
                    lblAccount.Text = "Uw gegevens zijn aangepast";
                }
                else
                {
                    lblAccount.Text = "Moet minstens een gebruikersnaam, een wachtwoord van 8+ tekens en een E-Mail adres met een '@' bevatten";
                }
            }
            else
            {
                lblAccount.Text = "Log eerst in";
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            if (clsLogin.ID != 0)
            {
                lblAccount.Text = "werkt niet";

                /*cmd = new SqlCommand(
                    "DELETE * FROM Gebruiker WHERE ID=@ID",
                    con);
                con.Open();
                    cmd.Parameters.AddWithValue("@ID", clsLogin.ID);
                con.Close();

                cmd = new SqlCommand(
                    "DELETE * FROM Persoonlijke_Gegevens WHERE Gebruikers_ID=@Gebruikers_ID",
                    con);
                con.Open();
                    cmd.Parameters.AddWithValue("@Gebruikers_ID", clsLogin.ID);
                    cmd.ExecuteNonQuery();
                con.Close();

                txbVoornaam.Text = "";
                txbTussenvoegsel.Text = "";
                txbAchternaam.Text = "";
                txbAdres.Text = "";
                txbWoonplaats.Text = "";

                objDelete.checkDeleteCredentials(ID);

                bool check = objDelete.checkDeleteCredentials(ID);
                if(check == true)
                {
                    lblAccount.Text = "Uw gegevens zijn aangepast";
                }*/
            }
            else
            {
                lblAccount.Text = "Log eerst in";
            }
        }
    }
}