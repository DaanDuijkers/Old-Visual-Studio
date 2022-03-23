using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace privateMessenger
{
    class db
    {
        const string connectionString = @"Data Source=DESKTOP-R332FA0\MSSQLSERVER2;Initial Catalog=proftaakopdracht;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private SqlConnection conn = new SqlConnection(connectionString);
        private List<Beheerder> beheerders = new List<Beheerder>();
        private List<Post> posts = new List<Post>();
        private List<Gebruiker> gebruikers = new List<Gebruiker>();


        public void AddGebruiker(Gebruiker gebruikerToevoegen)
        {
            // Open de DB verbinding.
            conn.Open();
            string query = "INSERT INTO gebruiker (gebruikerid) VALUES ('" + gebruikerToevoegen.Gebruikerid + "')";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void AddBeheerder(Post postbeheerderToevoegen)
        {
            // Open de DB verbinding.
            conn.Open();
            string query = "INSERT INTO Berichten (beheerderid, postbeheerder, datum) VALUES ('" + postbeheerderToevoegen.Beheerderid + "', '" + postbeheerderToevoegen.Postbeheerder + "',  '" + postbeheerderToevoegen.Date + "')";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void AddChat(Chat chatToevoegen)
        {
            // Open de DB verbinding.
            conn.Open();
            string query = "INSERT INTO chat (beheerderid, gebruikerid, datum, actief ) VALUES ('" + chatToevoegen.Beheerid + "', '" + chatToevoegen.Gebruikerid + "',  '" + chatToevoegen.Datum + "' ,  '" + chatToevoegen.Actief + "')";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }


        public void UpdatePostBeheerder(Post postbeheerderToevoegen)
        {

            // Open de DB verbinding.
            using (SqlCommand command = conn.CreateCommand())
            {
                conn.Open();

                string query = "UPDATE Berichten  SET  gebruikertekst = ('" + postbeheerderToevoegen.Beheerderid + "" + postbeheerderToevoegen.Postbeheerder + "')";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

       
        public List<Beheerder> GetBeheerder()
        {
            beheerders = new List<Beheerder>();

            string q = "SELECT * FROM beheerder";

            conn.Open();
            SqlCommand cmd = new SqlCommand(q, conn);

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string naam = reader.GetString(1);

                    Beheerder beheerder = new Beheerder(id, naam);

                    beheerders.Add(beheerder);
                }
                conn.Close();
                return beheerders;
            }
        }

        public List<Gebruiker> GetGebruikers()
        {
            gebruikers = new List<Gebruiker>();

            string q = "SELECT gebruikersid FROM gebruiker";

            conn.Open();
            SqlCommand cmd = new SqlCommand(q, conn);

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    string id = reader.GetString(0);
               

                    Gebruiker gebruiker = new Gebruiker(id);

                    gebruikers.Add(gebruiker);
                }
                conn.Close();
                return gebruikers;
            }
        }

        public List<Post> GetPosts()
        {
            posts = new List<Post>();

            string q = "SELECT gebruikerid, gebruikertekst FROM Berichten";

            conn.Open();
            SqlCommand cmd = new SqlCommand(q, conn);

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    //string gebruikersid = reader["gebruikerid"].ToString();
                    //string gebruikertekst = reader["gebruikertekst"].ToString();

                    string gebruikersid = reader.GetString(0);
                    string gebruikertekst = reader.GetString(1);

                    Post berichten = new Post(gebruikersid, gebruikertekst);

                    posts.Add(berichten);
                }
                conn.Close();
                return posts;
            }
        }
    }
}
