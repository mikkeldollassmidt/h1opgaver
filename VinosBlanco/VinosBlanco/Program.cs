using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinosBlanco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Grabs method View's code.
            Program.View();
        }
        static int[,] Model()
        {
            int[,] vinos = new int[11, 2]
            { 
                { 175134, 2009 }, { 175388, 2010 },
                { 172818, 2011 }, { 142709, 2012 },
                { 151437, 2013 }, { 188052, 2014 },
                { 150979, 2015 }, { 152210, 2016 },
                { 149450, 2017 }, { 154398, 2018 },
                { 150160, 2019 } 
            };

            return vinos;

        }

        static void Controller()
        {
            // Integer star to calculate stars to be placed.
            int star;

            // MAX with the MAX value on the chart.
            const int MAX = 175388;
            // MAX_STAR with the highest stars to be used.
            const byte MAX_STAR = 100;

            // This array goes to program.model and grabs the code which are gonna get returned in a new array called vinos.
            int[,] vinos = Program.Model();

            // For to write 11 rows.
            for (int i = 0; i < 11; i++)
            {
                // Calculating how many stars to be placed.
                star = MAX_STAR * vinos[i,0] / MAX;

                // Placing the year and ":" in front of the stars.
                Console.WriteLine(vinos[i, 1] + ":");

                // For to place the stars.
                for (int j = 0; j < star; j++)
                {
                    Console.SetCursorPosition(j + 5, i);
                    Console.WriteLine("*");
                }
            }

            Console.ReadLine();
        }
        static void View()
        {
            Program.Controller();
        }
    }
}
