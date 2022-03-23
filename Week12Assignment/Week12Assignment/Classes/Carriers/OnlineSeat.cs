using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week12Assignment
{
    public class OnlineSeat : Seat
    {
        private string loginCode;

        public string LoginCode { get { return loginCode; } }

        public OnlineSeat ()
        {
            char[] letters = "acbdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890".ToCharArray();
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                this.loginCode += letters[random.Next(0, 61)].ToString();
            }
        }
    }
}