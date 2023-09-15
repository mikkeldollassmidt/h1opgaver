using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JediMindTricks
{
    internal class Program
    {
        public static void Main()
        {
            /*Dictionary<string, bool> people = new Dictionary<string, bool>();
            people.Add("Luke", true);
            people.Add("Leia", false);
            people.Add("Han", false);
            people.Add("Yoday", true);
            people.Add("Chewbacca", false);
            foreach (KeyValuePair<string, bool> pair in people)
            {
                // A KeyValuePair provides the string as the Key property
                // and the bool as the Value property.
                if (pair.Value)
                {
                    Console.WriteLine(pair.Key + " is a Jedi");
                }
                else
                {
                    Console.WriteLine(pair.Key + " is not a Jedi");
                }
            }
            Console.ReadLine();*/

            // Create and add things to dictionary
            Dictionary<string, int> dict = new Dictionary<string, int>()
            {
                { "Mikkel", 18 },
                { "Ole", 81 },
                { "Theodor", 3 }
            };

            // Removes the one with the key: Mikkel
            dict.Remove("Mikkel");

            // Write dictionary.
            foreach (KeyValuePair<string, int> pair in dict)
            {
                    Console.WriteLine(pair.Key);
            }

            // Write dictionary with var variable.
            foreach (var names in dict.Keys)
            {
                Console.WriteLine(names);
            }
            Console.ReadLine();
        }
    }
}
