using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rumfanget
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The console is writing the words inside of the ellipsis
            Console.WriteLine("Enter length:");
            // Making a double called length to capture whats getting typed and put inside of the variable.
            double length = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter width:");
            // Making a double called width to capture whats getting typed and put inside of the variable.
            double width = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter height:");
            // Making a double called height to capture whats getting typed and put inside of the variable.
            double height = Convert.ToDouble(Console.ReadLine());

            // A double to calculate the volume.
            double volume = height * width * length;

            //Clearing the console for a cleaner view
            Console.Clear();

            // Writing the result.
            Console.WriteLine("Volume = " + volume);

            // Reads keyboard interaction to see when to stop.
            Console.ReadLine();

        }
    }
}
