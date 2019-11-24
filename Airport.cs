using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACA.Lesson8.HelloCollections
{
    class Airport
    {
        public string Name { get; set; }
        public string CountryCode { get; set; }
        public string Size { get; set; }

        public Airport(string name, string countryCode, string size)
        {
            Name = name;
            CountryCode = countryCode;
            if (size == "Small" || size == "Medium" || size == "Large" || size == "Mega" ||  size == "SuperMega")
            Size = size;
              else 
                Size = "Small";
        }
    }
}
