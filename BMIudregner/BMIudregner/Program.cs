using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMIudregner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console writes a line inside of the ellipsis.
            Console.WriteLine("Write your weight(kg):");
            // Captures with readline in a double called weight.
            double weight = Convert.ToDouble(Console.ReadLine());
            // Clear console for a cleaner view.
            Console.Clear();
            Console.WriteLine("Write your height(m):");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.Clear();

            // Double to calculate bmi.
            double bmicalculation = weight / (height * height);

            // bmigroups string with value = null, is used to change at if statements.
            string bmigroups;

            // If to find bmi groups.
            if (bmicalculation < 40)
            {
                bmigroups = "obesity second degree";
                if (bmicalculation < 35)
                {
                    bmigroups = "obesity first degree";
                    if (bmicalculation < 30)
                    {
                        bmigroups = "weigth over";
                        if (bmicalculation < 24)
                        {
                            bmigroups = "norm";
                            if (bmicalculation < 18.5)
                            {
                                bmigroups = "body weight dificit";
                                if (bmicalculation < 16)
                                {
                                    bmigroups = "very underweight";
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                bmigroups = "very overweight";
            }

            // Writes te result with rounded down bmi calculation.
            Console.WriteLine("Your bmi is: " + Math.Floor(bmicalculation));
            Console.WriteLine("Your grouped as:");

            // If statements to change color with the bmigroups.
            if (bmicalculation < 40)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                if (bmicalculation < 35)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    if (bmicalculation < 30)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        if (bmicalculation < 24)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            if (bmicalculation < 18.5)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                if (bmicalculation < 16)
                                {
                                    Console.ForegroundColor = ConsoleColor.Magenta;
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            Console.WriteLine(bmigroups);
            Console.ReadLine();
        }
    }
}
