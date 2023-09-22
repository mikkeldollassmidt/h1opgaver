using ProgrammeringsPrøve.MVC.Controller;
using ProgrammeringsPrøve.MVC.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammeringsPrøve.MVC.View
{
    internal class Menu
    {
        ApartmentLists al = new ApartmentLists();
        ApartmentDetails ad = new ApartmentDetails();
        BudgetHandling bh = new BudgetHandling();

        // Show the main menu with a readkey, to read inputs.
        public void DisplayMenu()
        {
            while (true)
            {
                MenuLayout();
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        ad.ShowAllApartmentDetails();
                        break;
                    case ConsoleKey.D2:
                        Console.Clear();
                        DisplayAddRenovations();
                        break;
                    default:
                        Console.Clear();
                        break;
                }
            }
        }

        // Displays the add renovation menu
        public void DisplayAddRenovations()
        {
            while (true)
            {
                bh.PrintBudget();

                Console.WriteLine($"1) - 5 rooms ({al.Five})\n" +
                    $"2) - 4 rooms ({al.Four})\n" +
                    $"3) - 3 rooms ({al.Three})\n" +
                    $"4) - 2 rooms ({al.Two})\n" +
                    $"5) - 1 rooms ({al.One})\n\n" +
                    $"Escape) - Go back.");

                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        al.AddRenovations("five");
                        // Price of renovation
                        bh.MinusBudget(64841);
                        break;
                    case ConsoleKey.D2:
                        Console.Clear();
                        al.AddRenovations("four");
                        // Price of renovation
                        bh.MinusBudget(55578);
                        break;
                    case ConsoleKey.D3:
                        Console.Clear();
                        al.AddRenovations("three");
                        // Price of renovation
                        bh.MinusBudget(46315);
                        break;
                    case ConsoleKey.D4:
                        Console.Clear();
                        al.AddRenovations("two");
                        // Price of renovation
                        bh.MinusBudget(37052);
                        break;
                    case ConsoleKey.D5:
                        Console.Clear();
                        al.AddRenovations("one");
                        // Price of renovation
                        bh.MinusBudget( 27789);
                        break;
                    case ConsoleKey.Escape:
                        Console.Clear();
                        DisplayMenu();
                        break;
                    default:
                        break;
                }
            }
        }
        public void MenuLayout()
        {
            Console.WriteLine("1) - Show apartment types" +
                            "\n2) - Add apartments to renovation");
        }
    }
}
