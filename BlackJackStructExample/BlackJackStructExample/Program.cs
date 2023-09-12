using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackStructExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Model.Card decks = new Model.Card(3, 16);

            string writeDecks = decks.ToString();

            Console.WriteLine(writeDecks);
            Console.ReadLine();
        }
    }
}
