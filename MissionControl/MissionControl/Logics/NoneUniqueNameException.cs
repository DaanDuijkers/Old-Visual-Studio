using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissionControl
{
    public class NoneUniqueNameException : ArgumentException
    {
        public NoneUniqueNameException(string message, string parameterName) : base(message, parameterName)
        {

        }
    }
}