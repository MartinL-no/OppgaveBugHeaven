using System;
using System.Collections.Generic;
using System.Text;

namespace BugsAndExceptions
{
    public class Address
    {
        public string StreetName { get; set; }
        public string Municipality { get; set; }
        public string City { get; set; }
        public string HouseNumber { get; set; }

        public Address(string streetName, string municipality, string city, string houseNumber)
        {
            StreetName = streetName;
            Municipality = municipality;
            City = city;
            HouseNumber = houseNumber;
        }
    }
}
