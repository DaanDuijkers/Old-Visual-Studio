using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissionControl
{
    public class AstronautAlreadyAssignedException : ArgumentException
    {
        public AstronautAlreadyAssignedException(string message, string parameterName) : base(message, parameterName)
        {

        }
    }
}