using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Home : System.Web.UI.Page
    {
        frmHome frmHome = new frmHome();
        frmLogin frmLogin;
        frmRegistreren frmRegistreren;
        frmAanpassen frmAanpassen;
        clsSecure objSecure = new clsSecure();
        clsSession objSession = new clsSession();
        clsLogin objLogin = new clsLogin();
        clsRegistreren objRegistreren = new clsRegistreren();
        clsAanpassen objAanpassen = new clsAanpassen();

        public frmMain()
        {
            InitializeComponent();
            frmLogin = new frmLogin(this);
            frmRegistreren = new frmRegistreren(this);
            frmAanpassen = new frmAanpassen(this);

            frmHome.TopLevel = false;
            frmHome.AutoScroll = true;
            pnlPagina.Controls.Add(frmHome);
            frmHome.Show();
        }

        private void afsluitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHome.TopLevel = false;
            frmHome.AutoScroll = true;
            pnlPagina.Controls.Clear();
            pnlPagina.Controls.Add(frmHome);
            frmHome.Show();
        }

        private bool showLoginForm()
        {
            bool check = objSession.getLoggedIn();
            if (check == false)
            {
                pnlPagina.Controls.Clear();
                frmLogin.TopLevel = false;
                frmLogin.AutoScroll = true;
                pnlPagina.Controls.Add(frmLogin);
                frmLogin.Show();
                return true;
            }
            else
            {
                return false;
            }
        }

        private void registrerenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistreren.TopLevel = false;
            frmRegistreren.AutoScroll = true;
            pnlPagina.Controls.Clear();
            pnlPagina.Controls.Add(frmRegistreren);
            frmRegistreren.Show();
        }

        private void aanpassenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.aanpassen();
        }

        private void aanpassen()
        {
            bool check = objSecure.checkPage("home");
            if (check == true)
            {
                frmAccount.TopLevel = false;
                frmAccount.AutoScroll = true;
                pnlPagina.Controls.Clear();
                pnlPagina.Controls.Add(frmAccount);
                frmAccount.Show();
            }
            else
            {
                bool check2 = objSession.getLoggedIn();
                if (check2 == true)
                {
                    frmAanpassen.TopLevel = false;
                    frmAanpassen.AutoScroll = true;
                    pnlPagina.Controls.Clear();
                    pnlPagina.Controls.Add(frmAanpassen);
                    frmAanpassen.Show();
                }
                else
                {
                    showLoginForm();
                }
            }
        }

        private void inloggenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin.TopLevel = false;
            frmLogin.AutoScroll = true;
            pnlPagina.Controls.Clear();
            pnlPagina.Controls.Add(frmLogin);
            frmLogin.Show();
        }

        public void checkCredentials(string username, string password)
        {
            bool check = objLogin.checkCredentials(username, password);
            if (check == true)
            {
                MessageBox.Show("U bent ingelogd");
                objSession.setIsLoggedIn(true);
                this.aanpassen();
            }
            else
            {
                MessageBox.Show("Ongeldige gebruikersnaam en/of wachtwoord");
            }
        }

        public void checkRegistrationCredentials(string username, string password, string lastName, string insertion, string firstName, string addres, string homeTown, string email)
        {
            bool check = objRegistreren.checkRegistrationCredentials(username, password, lastName, insertion, firstName, addres, homeTown, email);
            check = objLogin.checkCredentials(username, password);
            if (check == true)
            {
                MessageBox.Show("U bent geregistreert");
                objSession.setIsLoggedIn(true);
                this.aanpassen();
            }
            else
            {
                MessageBox.Show("U moet minstens een gebruikersnaam invoeren, een wachtwoord van minstens acht karacters hebben en uw E-Mail adres moet een @ bevatten.");
            }
        }

        public void checkAanpassenCredentials(string username, string password, string lastName, string insertion, string firstName, string addres, string homeTown, string email)
        {
            bool check = objAanpassen.checkAanpassenCredentials(username, password, lastName, insertion, firstName, addres, homeTown, email);
            if (check == true)
            {
                MessageBox.Show("Uw gegevens zijn aangepast");
                objSession.setIsLoggedIn(true);
                this.aanpassen();
            }
            else
            {
                MessageBox.Show("U moet minstens een gebruikersnaam invoeren, een wachtwoord van minstens acht karacters hebben en uw E-Mail adres moet een @ bevatten.");
            }
        }

        private void uitloggenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool loggedin = objSession.getLoggedIn();
            if (loggedin == true)
            {
                objSession.setIsLoggedIn(false);
                frmHome.TopLevel = false;
                frmHome.AutoScroll = true;
                pnlPagina.Controls.Clear();
                pnlPagina.Controls.Add(frmHome);
                frmHome.Show();
                MessageBox.Show("U bent uitgelogd!");
            }
        }
    }
}