using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace aspLogin
{
    public class Login : GlobalDBMediator
    {
        [BindProperty]
        public Person Person { get; set; }
        [BindProperty]
        private LoginSQL loginSQL { get; set; }

        Login()
        { }

        public List<Claim> CheckIn(Person person)
        {
            Person exists = loginSQL.Login(person);

            if (exists != null)
            {
                List<Claim> claims = new List<Claim>();
                claims.Add(new Claim(ClaimTypes.Name, exists.Username));
                claims.Add(new Claim("ID", exists.ID.ToString()));

                if (exists.IsAdmin == true)
                {
                    claims.Add(new Claim(ClaimTypes.Role, "Admin"));
                }
                else
                {
                    claims.Add(new Claim(ClaimTypes.Role, "User"));
                }

                return claims;
            }

            return null;
        }

        public void CheckOut()
        {

        }
    }
}