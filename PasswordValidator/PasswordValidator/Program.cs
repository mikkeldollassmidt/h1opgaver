using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace PasswordValidator
{
    internal class Program
    {
        public static string specialCharacterList = @"!#$%&'()*+,-./:;<=>?@[\]^_`{|}~"; // 31 // 0-30 possible characters.
        public static bool userInputContainsSpecialCharacter = false;
        public static bool userInputConsecutive = false;
        static void Main(string[] args)
        {
            Program.Controller();
        }

        #region Model
        #endregion

        #region View
        static void WritePasswordRules()
        {
            // Clear console for better view. Writes rules in writeline
            Console.Clear();
            Console.Write("You will now make a password. Your password need to have some rules to be perfect.\r\n\r\nRules for password to be: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("STRONG");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("- Password has to be inbetween 12-64 characters.\r\n- There has to be at least 1 upper and lower case character.\r\n- Password has to unclude numbers.\r\n- Include a special character.\r\n\r\nRules for password to be: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("WEAK");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("- If the password has 4 characters of the same in a row.\r\n- The password can't include number rows like: 1234 or 3456.\r\n\r\nRules for password to be: ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("NOT VALID");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("- If the rules above doesn't include your password is not valid.\r\n\r\nWrite your password:");
        }
        static void WritePasswordValid()
        {
            // If password is valid write this.
            Console.Clear();
            Console.Write("Your password is: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("STRONG");
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine("We recommend you to use that password! Press 'ENTER' button to close.");
            Console.ReadLine();
            Environment.Exit(0);
        }
        static void WritePasswordWeak()
        {
            // If password is weak write this.
            Console.Clear();
            Console.Write("Your password is: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("WEAK");
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Try again in 3 seconds.");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Try again in 2 seconds.");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Try again in 1 seconds.");
            Thread.Sleep(1000);
            Program.WritePasswordRules();
        }
        // If password is not valid write this.
        static void WritePasswordNotValid()
        {
            Console.Clear();
            Console.Write("Your password is: ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("NOT VALID");
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Try again in 3 seconds.");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Try again in 2 seconds.");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Try again in 1 seconds.");
            Thread.Sleep(1000);
            Program.WritePasswordRules();
        }
        #endregion

        #region Controller
        static void Controller()
        {
            // WHile loop to keep program and calculations in one place.
            while (true)
            {
                // Write passwordrules
                Program.WritePasswordRules();
                // Capture password
                string userInput = Console.ReadLine();
                int getLengthUserInput = userInput.Length;

                /// Consecutive characters / numbers
                /// Check for consecutive in the alphabet with the ASCII table 
                for (int i = 0; i < getLengthUserInput - 4; i++)
                {
                    int checkAsciiCharacterOne = (int)userInput[i];
                    int checkAsciiCharacterTwo = (int)userInput[i + 1];
                    int checkAsciiCharacterThree = (int)userInput[i + 2];
                    int checkAsciiCharacterFour = (int)userInput[i + 3];
                    if (Char.IsLetter(userInput[i]) && Char.IsLetter(userInput[i + 1]) &&
                       Char.IsLetter(userInput[i + 2]) && Char.IsLetter(userInput[i + 3]))
                    {
                        if (checkAsciiCharacterOne + 1 == checkAsciiCharacterTwo && checkAsciiCharacterTwo + 1 == checkAsciiCharacterThree && checkAsciiCharacterThree + 1 == checkAsciiCharacterFour)
                        {
                            userInputConsecutive = true;
                        }
                    }
                }

                /* For loop to check for special characters.
                Take the length of the special characters (31) and loop through the whole string
                until something is found in the userInput and make userInputContainsSpecialCharacter true. */

                for (int i = 0; i < specialCharacterList.Length; i++)
                {
                    char c = specialCharacterList[i];
                    if (userInput.Contains(c))
                    {
                        userInputContainsSpecialCharacter = true;
                    }
                }

                // If to check if all credentials is correct to check if password is weak, not valid or strong!

                if (getLengthUserInput > 11 && getLengthUserInput < 65)
                {
                    if (userInput.Any(char.IsUpper) && userInput.Any(char.IsLower) && userInput.Any(char.IsDigit))
                    {
                        if (userInputContainsSpecialCharacter == true)
                        {
                            if (userInputConsecutive == false)
                            {
                                Program.WritePasswordValid();
                            }
                            else
                            {
                                Program.WritePasswordWeak();
                            }
                        }
                        else
                        {
                            Program.WritePasswordWeak();
                        }
                    }
                    else
                    {
                        Program.WritePasswordWeak();
                    }
                }
                else
                {
                    Program.WritePasswordNotValid();
                }
            }
        }
            #endregion
    }
}
