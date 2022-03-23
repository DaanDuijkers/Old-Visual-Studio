using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LearnASPNETCoreRazorPagesWithRealApps
{
    public class LoginModel : PageModel
    {
        public string Msg;

        private SecurityManager securityManager = new SecurityManager();

        public void OnGet()
        {
        }

        public IActionResult OnPost(string username, string password)
        {
            AccountModel accountModel = new AccountModel();
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || accountModel.Login(username, password) == null)
            {
                Msg = "Invalid";
                return Page();
            }
            else
            {
                securityManager.SignIn(HttpContext, accountModel.Find(username));
                return RedirectToPage("Welcome");
            }
        }
    }
}