using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteket
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            View v = new View();
            Model m = new Model();

            v.Display();
        }
    }
}
