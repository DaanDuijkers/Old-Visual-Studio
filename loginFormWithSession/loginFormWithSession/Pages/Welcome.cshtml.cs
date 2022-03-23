using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace loginFormWithSession.Pages
{
    public class WelcomeModel : PageModel
    {
        public string Username;

        public void OnGet()
        {
            this.Username = HttpContext.Session.GetString("username");
        }
    }
}