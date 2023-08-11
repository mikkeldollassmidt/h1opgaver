using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terningen
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Generate a random object to generate something random
            Random random = new Random();
            // Integer to create a variable called dice.
            int dice;
            // While loop set to true, so it always will run. It's also so we can start the program over again.
            while (true)
            {
                // Clearing the console for a cleaner view
                Console.Clear();
                // Assigning a random.Next from the number 1-6 to the integer "dice".
                dice = random.Next(1, 7);
                // Setting cursor a little longer out in the console field. (just for looks)
                Console.SetCursorPosition(4,2);

                // If random number is == the random number chosen by the object, then execute a writeline.
                if (dice == 1)
                {
                    // Here we change the foreground and background color.
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Rolled " + dice);
                }
                else if (dice == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("Rolled " + dice);
                }
                else if (dice == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Rolled " + dice);
                }
                else if (dice == 4)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Rolled " + dice);
                }
                else if (dice == 5)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Rolled " + dice);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Rolled " + dice);
                }

                // Switch for closing and re-rolling.
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.Escape:
                        return;
                    case ConsoleKey.Enter:
                        continue;
                }
            }
        }
    }
}
