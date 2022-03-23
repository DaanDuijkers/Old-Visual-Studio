using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Login
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
        private frmMain mainform = null;

        public frmRegistreren(Form callingForm)
        {
            mainform = callingForm as frmMain;
            InitializeComponent();
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

        private void btnRegistreer_Click(object sender, EventArgs e)
        {
            username = txbGebruikersnaam.Text;
            password = Encrypt(txbWachtwoord.Text);
            lastName = txbVoornaam.Text;
            insertion = txbTussenvoegsel.Text;
            firstName = txbVoornaam.Text;
            addres = txbAdres.Text;
            homeTown = txbWoonplaats.Text;
            email = txbEmail.Text;
            mainform.checkRegistrationCredentials(username, password, lastName, insertion, firstName, addres, homeTown, email);
        }
    }
}