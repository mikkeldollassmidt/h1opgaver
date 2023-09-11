using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ElonMusk
{
    internal class Program
    {
        public Car car1 = new Car();

        static void Main(string[] args)
        {
            // Creating an object
            Car car1 = new Car();
            Car car2 = new Car();

            //Creating choose color GUI for car 1.
            Console.Clear();
            Console.WriteLine("Choose a color for car: \r\n1. Red\r\n2. Yellow\r\n3. Green");
            car1.ColorChoose();
            Console.WriteLine("Car is painted: " + car1.Color);
            Thread.Sleep(1000);

            //Creating choose color GUI for car 2.
            Console.Clear();
            Console.WriteLine("Choose a color for car: \r\n1. Red\r\n2. Yellow\r\n3. Green");
            car2.ColorChoose();
            Console.WriteLine("Car is painted: " + car2.Color);
            Thread.Sleep(1000);

            // Controls run and charge.
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Car 1:");
                car1.Display();
                Console.WriteLine("Car 2:");
                car2.Display();
                Console.WriteLine("Keys:\r\nRun: Car 1 = W, Car 2 = Y\r\nCharge: Car 1 = E, Car 2 = U");

                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.W:
                        car1.Run();
                        break;
                    case ConsoleKey.Y:
                        car2.Run();
                        break;
                    case ConsoleKey.E:
                        car1.ChargeCar();
                        break;
                    case ConsoleKey.U:
                        car2.ChargeCar();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
