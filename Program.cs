using System;
using System.Collections;
using System.Collections.Generic;

namespace ACA.Lesson8.HelloCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            

            SortedSet<Airport> airports = new SortedSet<Airport>(new MaxSize())
           {
               new Airport ("Domodedovo", " RUS","Medium"),
               new Airport ("Zvartnots", " ARM", "Small"),
               new Airport ("Barajas", "ESP", "Large"),
               new Airport ("Shenefeld"," GER", "SuperMega"),
               new Airport ("Charles_DE_Goll", "FR", "Mega"),
           };
            PrintAirports(airports);
            Console.Read();

          

     

        }

    
         static void PrintAirports(IEnumerable<Airport> airs)
        {
            foreach (Airport x in airs)
                Console.WriteLine(x.CountryCode + "  " + x.Name + "   " + x.Size);


        }

    }
}
