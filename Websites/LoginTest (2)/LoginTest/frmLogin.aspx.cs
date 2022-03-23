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
    public partial class Login : System.Web.UI.Page
    {
        public string username;
        public string password;
        clsLogin objLogin = new clsLogin();

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

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            username = txbGebruikersnaam.Text;
            password = Encrypt(txbWachtwoord.Text);
            objLogin.checkCredentials(username, password);

            bool check = objLogin.checkCredentials(username, password);
            if (check == true)
            {
                lblLogin.Text = "U bent ingelogd";
            }
            else
            {
                lblLogin.Text = "Ongeldige gebruikersnaam en/of wachtwoord";
            }
        }
    }
}