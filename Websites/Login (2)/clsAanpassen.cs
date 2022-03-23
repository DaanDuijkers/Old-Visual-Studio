using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


namespace login
{
    /// <summary>
    /// Summary description for clsAanpassen
    /// </summary>
    public class clsAanpassen
    {
        private SqlConnection con = clsDatabase.Connect();
        private SqlCommand cmd = clsDatabase.Command();
        private SqlDataAdapter adapt = clsDatabase.DataAdapter();
        
        public bool checkAanpassenCredentials(string username, string password, string lastName, string insertion, string firstName, string addres, string homeTown, string email)
        {
            bool checkP = checkPassword(password);
            bool checkU = checkUsername(username);
            bool checkE = checkEmail(email);

            if (checkP == true && checkU == true && checkE == true)
            {
                cmd = new SqlCommand(
                        "UPDATE Gebruiker SET Gebruikersnaam=@Gebruikersnaam,Wachtwoord=@Wachtwoord,Email=@Email WHERE ID=@ID",
                        con);
                con.Open();
                cmd.Parameters.AddWithValue("@ID", clsLogin.ID);
                cmd.Parameters.AddWithValue("@Gebruikersnaam", username);
                cmd.Parameters.AddWithValue("@Wachtwoord", password);
                cmd.Parameters.AddWithValue("@Email", email);
                con.Close();

                cmd = new SqlCommand(
                    "UPDATE Pesoonlijke_Gegevens SET Achternaam=@Achternaam,Tussenvoegsel=@Tussenvoegsel,Voornaam=@Voornaam,Adres=Adres,Woonplaats=@Woonplaats WHERE Gebruiker_ID=@Gebruiker_ID",
                    con);
                con.Open();
                cmd.Parameters.AddWithValue("@Gebruiker_ID", clsLogin.ID);
                cmd.Parameters.AddWithValue("@Achternaam", lastName);
                cmd.Parameters.AddWithValue("@Tussenvoegsel", insertion);
                cmd.Parameters.AddWithValue("@Voornaam", firstName);
                cmd.Parameters.AddWithValue("@Adres", addres);
                cmd.Parameters.AddWithValue("@Woonplaats", homeTown);
                cmd.ExecuteNonQuery();
                con.Close();

                return true;
            }
            else
            {
                return false;
            }
        }

        private bool checkPassword(string password)
        {
            if (password.Length < 8)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool checkUsername(string username)
        {
            if (username == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool checkEmail(string email)
        {
            if (email.Contains("@"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
