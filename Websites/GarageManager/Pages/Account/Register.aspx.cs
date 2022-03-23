using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class Pages_Account_Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnRegister_Click(object sender, EventArgs e)
    {
        UserStore<IdentityUser> userStore = new UserStore<IdentityUser>();

        userStore.Context.Database.Connection.ConnectionString =
            ConfigurationManager.ConnectionStrings["GarageConnectionString"].ConnectionString;

        UserManager<IdentityUser> manager = new UserManager<IdentityUser>(userStore);

        IdentityUser user = new IdentityUser();
        user.UserName = txbUsername.Text;

        if (txbPassword.Text == txbConfirmPassword.Text)
        {
            try
            {
                IdentityResult result = manager.Create(user, txbPassword.Text);

                if (result.Succeeded)
                {
                    UserInformation info = new UserInformation
                    {
                        Address = txbAddress.Text,
                        FirstName = txbFirstName.Text,
                        LastName = txbLastName.Text,
                        PostalCode = Convert.ToInt32(txbPostalCode.Text),
                        GUID = user.Id
                    };

                    UserInfoModel model = new UserInfoModel();
                    model.InsertUserInformation(info);

                    var authenticationManager = HttpContext.Current.GetOwinContext().Authentication;

                    var userIdentity = manager.CreateIdentity(user, DefaultAuthenticationTypes.ApplicationCookie);

                    authenticationManager.SignIn(new AuthenticationProperties(), userIdentity);
                    Response.Redirect("~/Index.aspx");
                }
                else
                {
                    litStatus.Text = result.Errors.FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                litStatus.Text = ex.ToString();
            }
        }
        else
        {
            litStatus.Text = "Passwords must match";
        }
    }
}