using System.Data.SqlClient;

namespace LoginTest
{
    internal class clsDelete
    {
        private SqlConnection con = clsDatabase.Connect();
        private SqlCommand cmd = clsDatabase.Command();
        private SqlDataAdapter adapt = clsDatabase.DataAdapter();

        public bool checkDeleteCredentials(int ID)
        {
            if (ID != 0)
            {
                cmd = new SqlCommand(
                    "DELETE * FROM Persoonlijke_Gegevens WHERE Gebruiker_ID='" + ID + "'",
                    con);
                con.Open();
                    cmd.ExecuteNonQuery();
                con.Close();

                cmd = new SqlCommand(
                    "DELETE * FROM Gebruiker WHERE ID='" + clsLogin.ID + "'; SELECT SCOPE_IDENTITY()",
                    con);
                con.Open();
                    cmd.ExecuteReader();
                con.Close();
                
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}