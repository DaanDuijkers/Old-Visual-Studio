using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for clsRegistreren
/// </summary>
class clsRegistreren
{
    private SqlConnection con = clsDatabase.Connect();
    private SqlCommand cmd = clsDatabase.Command();
    private SqlDataAdapter adapt = clsDatabase.DataAdapter();

    public bool checkRegistrationCredentials(string username, string password, string lastName, string insertion, string firstName, string addres, string homeTown, string email)
    {
        bool checkP = checkPassword(password);
        bool checkU = checkUsername(username);
        bool checkE = checkEmail(email);

        if (checkP == true && checkU == true && checkE == true)
        {
            cmd = new SqlCommand(
                    "INSERT INTO Gebruiker(Gebruikersnaam,Wachtwoord,Email) VALUES(@Gebruikersnaam,@Wachtwoord,@Email); SELECT SCOPE_IDENTITY()",
                    con);
            con.Open();
            cmd.Parameters.AddWithValue("@Gebruikersnaam", username);
            cmd.Parameters.AddWithValue("@Wachtwoord", password);
            cmd.Parameters.AddWithValue("@Email", email);
            int userID = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();

            cmd = new SqlCommand(
                    "INSERT INTO Pesoonlijke_Gegevens(Gebruiker_ID,Achternaam,Tussenvoegsel,Voornaam,Adres,Woonplaats) VALUES(@Gebruiker_ID,@Achternaam,@Tussenvoegsel,@Voornaam,@Adres,@Woonplaats)",
                    con);
            con.Open();
            cmd.Parameters.AddWithValue("@Gebruiker_ID", userID);
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