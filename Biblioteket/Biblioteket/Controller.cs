using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteket
{
    public class Controller
    {
        public void MenuReadKey()
        {
            Library l = new Library();
            View v = new View();
            Book commands = new Book();
            Book cook = new Book("COOKING TO KILL: THE POISON COOK-BOOK", 1);
            Book gallop = new Book("GALLOP YOUR MAGGOT: THE ULTIMATE BOOK OF SEXUAL SLANG", 2);
            Book hookers = new Book("HOOKERS OR CAKE: ANIMAL SPIRITS, POP CULTURE, GOD AND ROBOTS", 3);
            Book how = new Book("HOW TO COOK HUSBANDS", 4);
            Book weeds = new Book("HOW TO ENJOY YOUR WEEDS", 5);
            List<Book> books = new List<Book>()
            {
                cook, gallop, hookers, how, weeds
            };
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.D1:
                    commands.ListAllBooks(books);
                    break;

                case ConsoleKey.D2:
                    v.BorrowBookMenu();
                    break;

                case ConsoleKey.D3:
                    // Return boko
                    break;

                case ConsoleKey.D4:
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
