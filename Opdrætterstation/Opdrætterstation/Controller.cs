using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdrætterstation
{
    internal class Controller
    {
        public void CompleteMenu()
        {
            // Creating objects for breedingstation and view.
            BreedingStation bs = new BreedingStation();
            View v = new View();

            // While to keep the program running
            while(true)
            {
                Console.Clear();
                // Displays the menu
                v.DisplayMenu();
                switch(Console.ReadKey(true).Key)
                {
                    case ConsoleKey.D1: // Show all animals
                        Console.Clear();
                        bs.ListAllAnimals(bs.AllAnimals);
                        Console.ReadLine();
                        break;
                    case ConsoleKey.D2: // Add new animal
                        Console.Clear();
                        bs.DisplayAddAnimalMenu();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
