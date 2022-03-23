using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace loginFormWithSession.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        [BindProperty]
        public string Username { get; set; }
        [BindProperty]
        public string Password { get; set; }
        public string MSG;

        public void OnGet()
        {

        }

        public IActionResult OnGetLogout()
        {
            HttpContext.Session.Remove("username");
            return Page();
        }

        public IActionResult OnPost()
        {
            if (this.Username.Equals("abc") && this.Password.Equals("def"))
            {
                HttpContext.Session.SetString("username", this.Username);
                return RedirectToPage("Welcome");
            } 
            else
            {
                this.MSG = "Invalid";
                return Page();
            }
        }
    }
}