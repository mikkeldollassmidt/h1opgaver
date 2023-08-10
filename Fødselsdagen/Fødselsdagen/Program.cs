using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fødselsdagen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Here te console writes whats inside of the ellipsis
            Console.WriteLine("Enter your birthday: (dd-MM-yyyy)");
            // Here we make a string to capture what's typed by the user.
            string readin = Convert.ToString(Console.ReadLine());
            // Here we make a DateTime datatype called birthday and converts it to datetime and formats it to the format given in the code.
            DateTime birthday = DateTime.ParseExact(readin, "dd-MM-yyyy", null);

            // Make a DateTime datatype called now and gets the datetime at the moment.
            DateTime now = DateTime.Now;

            // This TimeSpan checks the difference between time now and the birthday given.
            TimeSpan difference = now - birthday;

            // Here we make integeres to calculate years and days apart. We also use a math.floor to round off.
            int years = (int)Math.Floor(difference.TotalDays / 365.2425);
            int days = (int)Math.Floor(difference.TotalDays);

            // Console writes a line with the exact calculation.
            Console.WriteLine("You are " + years + " years old and " + days + " days.");

            Console.ReadLine();
        }
    }
}
