using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPageTest.Models;

namespace RazorPageTest.Pages
{
    public class FormModel : PageModel
    {
        [BindProperty]
        public Contact Contact { get; set; }

        public void OnGet()
        {

        }

        public void OnPost()
        {
            string message = "Hello " + Contact.Name + ", thank you for contacting us!";
            message += "You live in  " + Contact.Country;
            message += "We will respond within two working days to " + Contact.Email;
            message += ". The subject of your message was: " + Contact.Subject;
            ViewData["Message"] = message;
        }
    }
}