using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morsekoden
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Writes the first line
            Console.WriteLine("Write your message and i will translate to morse code:");
            // String created to get overwrited.
            string message = "";

            // Moved cursor for a cleaner view.
            Console.SetCursorPosition(0, 2);

            // While loop to keep on writing in the same console window.
            while (true)
            {
                // Switch reads with console.readkey, which button gets pressed by the user. Then executes commands under.
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.A:
                        Console.Write("\b·— ");
                        message += "A";
                        break;
                    case ConsoleKey.B:
                        Console.Write("\b—··· ");
                        message += "B";
                        break;
                    case ConsoleKey.C:
                        Console.Write("\b—·—· ");
                        message += "C";
                        break;
                    case ConsoleKey.D:
                        Console.Write("\b—·· ");
                        message += "D";
                        break;
                    case ConsoleKey.E:
                        Console.Write("\b· ");
                        message += "E";
                        break;
                    case ConsoleKey.F:
                        Console.Write("\b··—· ");
                        message += "F";
                        break;
                    case ConsoleKey.G:
                        Console.Write("\b——· ");
                        message += "G";
                        break;
                    case ConsoleKey.H:
                        Console.Write("\b···· ");
                        message += "H";
                        break;
                    case ConsoleKey.I:
                        Console.Write("\b·· ");
                        message += "I";
                        break;
                    case ConsoleKey.J:
                        Console.Write("\b·——— ");
                        message += "J";
                        break;
                    case ConsoleKey.K:
                        Console.Write("\b—·— ");
                        message += "K";
                        break;
                    case ConsoleKey.L:
                        Console.Write("\b·—·· ");
                        message += "L";
                        break;
                    case ConsoleKey.N:
                        Console.Write("\b—· ");
                        message += "N";
                        break;
                    case ConsoleKey.M:
                        Console.Write("\b—— ");
                        message += "M";
                        break;
                    case ConsoleKey.O:
                        Console.Write("\b——— ");
                        message += "O";
                        break;
                    case ConsoleKey.P:
                        Console.Write("\b·——· ");
                        message += "P";
                        break;
                    case ConsoleKey.Q:
                        Console.Write("\b——·— ");
                        message += "Q";
                        break;
                    case ConsoleKey.R:
                        Console.Write("\b·—· ");
                        message += "R";
                        break;
                    case ConsoleKey.S:
                        Console.Write("\b··· ");
                        message += "S";
                        break;
                    case ConsoleKey.T:
                        Console.Write("\b— ");
                        message += "T";
                        break;
                    case ConsoleKey.U:
                        Console.Write("\b··— ");
                        message += "U";
                        break;
                    case ConsoleKey.D1:
                        Console.Write("\b·———— ");
                        message += "1";
                        break;
                    case ConsoleKey.D2:
                        Console.Write("\b··——— ");
                        message += "2";
                        break;
                    case ConsoleKey.D3:
                        Console.Write("\b···—— ");
                        message += "3";
                        break;
                    case ConsoleKey.D4:
                        Console.Write("\b····— ");
                        message += "4";
                        break;
                    case ConsoleKey.D5:
                        Console.Write("\b····· ");
                        message += "5";
                        break;
                    case ConsoleKey.D6:
                        Console.Write("\b—···· ");
                        message += "6";
                        break;
                    case ConsoleKey.D7:
                        Console.Write("\b——··· ");
                        message += "7";
                        break;
                    case ConsoleKey.D8:
                        Console.Write("\b———·· ");
                        message += "8";
                        break;
                    case ConsoleKey.D9:
                        Console.Write("\b———· ");
                        message += "9";
                        break;
                    case ConsoleKey.D0:
                        Console.Write("\b————— ");
                        message += "0";
                        break;
                    case ConsoleKey.OemPeriod:
                        Console.Write("\b·—·—·— ");
                        message += ".";
                        break;
                    case ConsoleKey.OemComma:
                        Console.Write("\b——··—— ");
                        message += ",";
                        break;
                    case ConsoleKey.OemMinus:
                        Console.Write("\b—····— ");
                        message += "¨-";
                        break;
                    case ConsoleKey.V:
                        Console.Write("\b···— ");
                        message += "V";
                        break;
                    case ConsoleKey.W:
                        Console.Write("\b·—— ");
                        message += "W";
                        break;
                    case ConsoleKey.X:
                        Console.Write("\b—··— ");
                        message += "X";
                        break;
                    case ConsoleKey.Y:
                        Console.Write("\b—·—— ");
                        message += "Y";
                        break;
                    case ConsoleKey.Z:
                        Console.Write("\b——·· ");
                        message += "Z";
                        break;
                    case ConsoleKey.Spacebar:
                        Console.Write("\b/");
                        message += " ";
                        break;
                    case ConsoleKey.Enter:
                        Console.WriteLine("\r\n___________________________________________________________________________________________\r\nYour message:\r\n" + message);
                        Console.ReadLine();
                        return;
                    case ConsoleKey.Escape:
                        break;

                }
            }

        }
    }
}
