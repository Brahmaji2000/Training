//4. Create a simple Stationery application to add items and display added items using Generic List collections.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass6
{
    class Stationery
    {
        static void main()
        {
            List<string> Stationery = new List<string>();
            Stationery.Add("Stapler");
            Stationery.Add("Stamp Pad");
            Stationery.Add("Box file");
            Stationery.Add("Office file");

            Console.WriteLine("Accessing Generic List using For Each Loop");
            foreach (var item in Stationery)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();

        }

    }
}
