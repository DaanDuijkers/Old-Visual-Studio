using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginTest
{
    public partial class Registreren : System.Web.UI.Page
    {
        public string username;
        public string password;
        public string lastName;
        public string insertion;
        public string firstName;
        public string addres;
        public string homeTown;
        public string email;
        //private frmMain mainform;
        //callingForm as frmMain;
        clsRegistreren objRegistreren = new clsRegistreren();

        protected void Page_Load(object sender, EventArgs e)
        {

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

        protected void btnRegistreer_Click(object sender, EventArgs e)
        {
            username = txbGebruikersnaam.Text;
            password = Encrypt(txbWachtwoord.Text);
            lastName = txbVoornaam.Text;
            insertion = txbTussenvoegsel.Text;
            firstName = txbVoornaam.Text;
            addres = txbAdres.Text;
            homeTown = txbWoonplaats.Text;
            email = txbEmail.Text;
            objRegistreren.checkRegistrationCredentials(username, password, lastName, insertion, firstName, addres, homeTown, email);

            bool check = objRegistreren.checkRegistrationCredentials(username, password, lastName, insertion, firstName, addres, homeTown, email);
            if (check == true)
            {
                lblRegistreren.Text = "Uw gegevens zijn aangepast";
            }
            else
            {
                lblRegistreren.Text = "Moet minstens een gebruikersnaam, een wachtwoord van 8+ tekens en een E-Mail adres met een '@' bevatten";
            }
        }
    }
}