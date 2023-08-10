using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarsAndStripes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Sets the background color to red.
            Console.BackgroundColor = ConsoleColor.Red;
            //Using foreach to make 2 red lines and go down 4. The foreach is doing that 7 times
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 38 * 2; j++)
                {
                    Console.SetCursorPosition(j, i * 4);
                    Console.WriteLine(" ");
                    Console.SetCursorPosition(j, i * 4 + 1);
                    Console.WriteLine(" ");
                }
            }

            // Sets the background color to white.
            Console.BackgroundColor = ConsoleColor.White;

            //Using foreach to make 2 white lines and go down 4. The foreach is doing that 7 times
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 38 * 2; j++)
                {
                    Console.SetCursorPosition(j, (i * 4) + 2);
                    Console.WriteLine(" ");
                    Console.SetCursorPosition(j, (i * 4) + 3);
                    Console.WriteLine(" ");
                }
            }

            // Sets the background color to blue.
            Console.BackgroundColor = ConsoleColor.Blue;

            //Using foreach to make a blue box 12 x 46.
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 23 * 2; j++)
                {
                    Console.SetCursorPosition(j, i);
                    Console.WriteLine(" ");
                    Console.SetCursorPosition(j, i);
                    Console.WriteLine(" ");
                }
            }

            //The foreach are making 6 rows of stars with a gap of 4 in the x axis and 2 in the y axis.
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6 * 2; j++)
                {
                    Console.SetCursorPosition(j * 4, (i * 2));
                    Console.WriteLine("*");
                }
            }

            Console.ReadLine();
        }
    }
}
