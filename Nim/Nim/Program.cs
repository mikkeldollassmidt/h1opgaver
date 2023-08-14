using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Nim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                // Preparing datatypes.
                int totalMatches = 7;
                string visualizeMatches = " |";
                int randomMatches;
                int userInput;

                Random random = new Random();

                Console.WriteLine("A game of matches! Are you ready? (Press any button to succeed.)");
                Console.ReadLine();

                // For loop to visualize how many matches on the table.
                for (int i = 0; i < 7; i++)
                {
                    Console.Clear();
                    for (int j = 0; j < totalMatches; j++)
                    {
                        Console.Write(visualizeMatches);

                    }

                    Console.WriteLine("\r\nHow many would you like to pick?");

                    userInput = Convert.ToInt16(Console.ReadLine());

                    // The user needs to type a number between 1-3 else continue. Also a else if to see how many matches left. So you can't just take the rest.
                    if (userInput <= 3 && userInput > 0)
                    {
                        totalMatches = totalMatches - userInput;
                        for (int j = 0; j < totalMatches; j++)
                        {
                            Console.Write(visualizeMatches);

                        }
                    }
                    else if (totalMatches == userInput)
                    {
                        if (userInput == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("The computer lost. Congratulations!");
                            Thread.Sleep(3000);
                            return;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("You can't choose 2.. So you chose 1 ;) \r\nThe computer lost. Congratulations!");
                            Thread.Sleep(3000);
                            return;
                        }
                    }
                    else
                    {
                        continue;
                    }

                    //Computers turn.
                    Thread.Sleep(1000);
                    Console.Clear();
                    Console.WriteLine("Computers turn. Wait.");
                    Thread.Sleep(1000);
                    Console.Clear();
                    if (totalMatches > 2)
                    {
                        randomMatches = random.Next(1, 4);
                        totalMatches = totalMatches - randomMatches;
                        Console.WriteLine("The computer chose to pick: " + randomMatches);
                        Thread.Sleep(2000);
                    }
                    else if (totalMatches == 2)
                    {
                        Console.WriteLine("The computer chose to pick: 1");
                        totalMatches--;
                        Thread.Sleep(3000);
                        Console.Clear();
                        Console.WriteLine("You lost.");
                        return;

                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("The computer lost. Congratulations!");
                        Thread.Sleep(3000);
                        return;
                    }
                }
                // To exit with escape.
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.Escape:
                        break;
                    default:
                        continue;
                }
            }
        }
    }
}

