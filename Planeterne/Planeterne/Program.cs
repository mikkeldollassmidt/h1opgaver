using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Planeterne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Controller p = new Controller();

            p.CreateAllPlanets();
            p.PrintAllPlanets();
            p.CreatePlanetsSpecificMT();
            p.PrintPlanetsSpecificMT();
            p.CreatePlanetsSpecificDiameter();
            p.PrintPlanetsSpecificDiameter();
            p.CountLines();
            Console.ReadLine();

        }
    }
}
