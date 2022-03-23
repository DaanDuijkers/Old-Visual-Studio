using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LearnASPNETCoreRazorPagesWithRealApps
{
    [Authorize(Roles = "superadmin,admin,employee")]
    public class WelcomeModel : PageModel
    {
        public string UserId;

        private SecurityManager securityManager = new SecurityManager();

        public void OnGet()
        {
            UserId = User.FindFirst(ClaimTypes.Name).Value;
        }

        public IActionResult OnGetLogout()
        {
            securityManager.SignOut(HttpContext);
            return RedirectToPage("Login");
        }
    }
}