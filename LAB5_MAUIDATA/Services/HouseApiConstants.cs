using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB5_MAUIDATA.Services
{
    public class HouseApiConstants
    {
        public const string BaseUrl = "api";
        public const string HousesUrl = $"{BaseUrl}/House";
        public const string AddresesUrl = $"{BaseUrl}/Address";
        public const string GaragesUrl = $"{BaseUrl}/Garage";
    }
}
