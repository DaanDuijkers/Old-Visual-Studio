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
    [Authorize(Roles = "superadmin")]
    public class Work1Model : PageModel
    {
        public string UserId;

        public void OnGet()
        {
            UserId = User.FindFirst(ClaimTypes.Name).Value;
        }
    }
}