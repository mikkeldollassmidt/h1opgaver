using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperaturberegneren
{
    internal class Program
    {a
        static void Main(string[] args)
        {
            // Console will write a line with the text in the ellipsis
            Console.WriteLine("Enter temperature in celcius:");
            /* I made a double, variable named celsius with a convert to double and a readline, so the program remembers it.
            Double is being used cause of the precision. */
            double celsius = Convert.ToDouble(Console.ReadLine());

            // Here i made two doubles with the calculation to convert.

            double fahrenheit = (celsius * 1.8) + 32;
            double reamur = celsius * 0.8;

            // Clear the whole console. (Just for a cleaner look)
            Console.Clear();

            // Here it writes out in console what the converter has calculated.
            Console.WriteLine(celsius + "°C (Celsius)");
            Console.WriteLine(fahrenheit + "°F (Fahrenheit)");
            Console.WriteLine(reamur + "°R (Reamur)");

            Console.ReadLine();
        }
    }
}
