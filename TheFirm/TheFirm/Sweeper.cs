using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm
{
    public class Sweeper:Employee
    {
        // Method to display sweeper's data
        public void DisplaySweeper()
        {
            Console.WriteLine("Sweeper:");
            Console.WriteLine($"Firstname: {firstName}\nLastname: {lastName}\nCpr no: {cprNo}\n");
        }
    }
}
