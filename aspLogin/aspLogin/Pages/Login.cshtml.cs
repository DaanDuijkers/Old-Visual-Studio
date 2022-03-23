using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace aspLogin
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public Login Login { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost(string? returnUrl)
        {
            if (ModelState.IsValid)
            {
                List<Claim> claims = Login.CheckIn(new Person(Login.Person.Username, Login.Person.Password));

                if (claims != null)
                {
                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    HttpContext.SignInAsync(new ClaimsPrincipal(claimsIdentity));

                    // Url.IsLocalUrl is to prevent Open Redirect Attacks
                    // See 'What is an Open Redirection Attack?' @ https://docs.microsoft.com/en-us/aspnet/mvc/overview/security/preventing-open-redirection-attacks)
                    if (!String.IsNullOrWhiteSpace(returnUrl) && Url.IsLocalUrl(returnUrl))
                    {
                        return Redirect(returnUrl);
                    }

                    return RedirectToPage("User");
                }
            }

            ModelState.AddModelError("InvalidCredentials", "The supplied username and/or password is invalid");
            return Page();
        }
    }
}