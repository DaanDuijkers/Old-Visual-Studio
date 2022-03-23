using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnASPNETCoreRazorPagesWithRealApps
{
    public class AccountModel
    {
        private List<Account> accounts;

        public AccountModel ()
        {
            this.accounts = new List<Account>()
            {
                new Account("acc1", "123", new string[]{ "superadmin", "admin", "employee" }),
                new Account("acc2", "123", new string[]{ "admin", "employee" }),
                new Account("acc3", "123", new string[]{ "employee" })
            };
        }

        public Account Find (string username)
        {
            return accounts.SingleOrDefault(a => a.Username.Equals(username));
        }

        public Account Login (string username, string password)
        {
            return accounts.SingleOrDefault(a => a.Username.Equals(username) && a.Password.Equals(password));
        }
    }
}