using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taxiaplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Taxi taxi = new Taxi();
            taxi.DriverName = "fahrul";
            taxi.OnDuty = false;
            taxi.NumPasangger = 10;

            taxi.TaxiInfo();
            taxi.PickUpPasangger();
            taxi.DropOffPasangger();
            Console.ReadKey();

        }
    }
}
