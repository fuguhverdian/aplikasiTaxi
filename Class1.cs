using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taxiaplication
{
    class Taxi
    {
        public string DriverName { get; set; }
        public bool OnDuty { get; set; }
        public int NumPasangger { get; set; }

        public void TaxiInfo()
        {
            Console.WriteLine("DriverName: {0}", DriverName);
            if (OnDuty == true)
            {
                Console.WriteLine("OnDuty = Yes");
            }
            else
            {
                Console.WriteLine("OnDuty = NO");
            }
            Console.WriteLine("Number of pasangger: {0}\n\n", NumPasangger);   
        }
        public void PickUpPasangger()
        {
            if (OnDuty == true)
            {
                Console.WriteLine("{0} sedang menjemput penumpang",DriverName);
            }
            else
            {
                return;
            }
        }
        public void DropOffPasangger()
        {
            if (OnDuty == false)
            {
                Console.WriteLine("{0} selesai mengantar penumpang", DriverName);
            }
            else
            {
                return;
            }
        }
    }
 }

