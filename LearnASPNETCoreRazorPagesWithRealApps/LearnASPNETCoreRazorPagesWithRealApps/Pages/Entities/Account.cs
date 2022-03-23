using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnASPNETCoreRazorPagesWithRealApps
{
    public class Account
    {
        public string Username { get; private set; }
        public string Password { get; private set; }
        public string[] Roles { get; private set; }

        public Account(string username, string password, string[] roles)
        {
            this.Username = username;
            this.Password = password;
            this.Roles = roles;
        }
    }
}