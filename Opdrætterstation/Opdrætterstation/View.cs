using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Opdrætterstation
{
    internal class View
    {
        public void DisplayMenu()
        {
            Console.WriteLine("1) See all animals.\n" +
                              "2) Add new animal.\n\nUse (1, 2) on your keyboard...");
        }
    }
}
