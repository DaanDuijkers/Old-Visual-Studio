using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoStreetApp
{
    public interface IMapClient
    {
        void StreetAdded(Street s);
        void StreetRemoved(Street s);
    }
}
