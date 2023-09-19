using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm
{
    public class Display
    {
        Controller c = new Controller();
        public void WhileReadKey()
        {
            // While to keep the program running.
            while (true)
            {
                // Switch to read key from users input. Checks for 1, 2, 3 and 4.
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        c.AddDefaultEmployee();
                        break;
                    case ConsoleKey.D2:
                        Console.Clear();
                        c.AddDefaultManager();
                        break;
                    case ConsoleKey.D3:
                        Console.Clear();
                        c.AddDefaultProjectManager();
                        break;
                    case ConsoleKey.D4:
                        Console.Clear();
                        c.AddDefaultSweeper();
                        break;
                    default: 
                        break;
                }
            }
        }

    }
}
