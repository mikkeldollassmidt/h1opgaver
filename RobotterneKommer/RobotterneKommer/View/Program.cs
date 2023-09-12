using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotterneKommer
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Model.Robot r = new Model.Robot(true, true, true ,true, "green");
            Console.WriteLine(r.Color);
            Console.ReadLine();
        }
    }
}
