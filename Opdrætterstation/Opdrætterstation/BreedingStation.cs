using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Opdrætterstation
{
    internal class BreedingStation
    {
        // Creates queue attribute
        private Queue<Animal> allAnimals;

        //Makes a property for the attribute
        public Queue<Animal> AllAnimals
        {
            get { return allAnimals; }
            private set { allAnimals = value; }
        }

        // Constructor for the attribute
        public BreedingStation()
        {
            allAnimals = new Queue<Animal>();
            InitializeAnimals();
        }

        // Startup animals added to queue
        public void InitializeAnimals()
        {
            allAnimals.Enqueue(new Animal("Dog", "He", "Mammal", true, 4, true, "Long", 3));
            allAnimals.Enqueue(new Animal("Cock", "She", "Ovipositor", true, 2, true, "Short", 2));
        }

        // Method to add animals with parameters
        public void AddAnimal(string animalType, string sex, string reproduction, bool hasLegs, byte numberOfLegs, bool hasFur, string furType, byte departingAge)
        {
            allAnimals.Enqueue(new Animal(animalType, sex, reproduction, hasLegs, numberOfLegs, hasFur, furType, departingAge));
        }

        // Displays add animal menu.
        public void DisplayAddAnimalMenu()
        {
            Console.WriteLine("Animal type: (Dog, Rabbit, Cock...)");
            string animalType = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Animals sex: (He, She)");
            string sex = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Animals reproduction: (Ovipositor, Mammal...)");
            string reproduction = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Does the animal have legs: (Type y or n...)");
            string stringToBoolHasLegs = Console.ReadLine();
            Console.Clear();
            bool hasLegs;
            byte numberOfLegs;
            if (stringToBoolHasLegs == "y" || stringToBoolHasLegs == "Y")
            {
                hasLegs = true;
                Console.WriteLine("How many legs: (1-255)");
                numberOfLegs = Convert.ToByte(Console.ReadLine());
                Console.Clear();
            }
            else
            {
                hasLegs = false;
                numberOfLegs = 0;
            }

            Console.WriteLine("Does the animal has fur: (Type y or n...)");
            string stringToBoolHasFur = Console.ReadLine();
            Console.Clear();
            bool hasFur;
            string furType;
            if (stringToBoolHasFur == "y" || stringToBoolHasFur == "Y")
            {
                hasFur = true;
                Console.WriteLine("Whats the fur type: (Short, Long, Curly...)");
                furType = Console.ReadLine();
                Console.Clear();
            }
            else
            {
                hasFur = false;
                furType = "No fur.";
            }

            Console.WriteLine("The animal departs when aged: (1, 2 ,3 (In years))");
            byte departingAge = Convert.ToByte(Console.ReadLine());

            AddAnimal(animalType, sex, reproduction, hasLegs, numberOfLegs, hasFur, furType, departingAge);

            Console.Clear();
            Console.WriteLine("The animal is now added.");
            Thread.Sleep(2000);


        }

        // Shows all animals with foreach
        public void ListAllAnimals(Queue<Animal> allAnimals)
        {
            Console.WriteLine("List of all animals in the Breeding station:\n");
            foreach (var animal in allAnimals)
            {
                Console.WriteLine($"{animal.AnimalType}:\nSex: {animal.Sex}\nReproduction: {animal.Reproduction}\nHas legs: {animal.HasLegs}\nNumber of legs: {animal.NumberOfLegs}\nHas fur: {animal.HasFur}\nFur type: {animal.FurType}\nDeparting age: {animal.DepartingAge}\n");
            }
            Console.WriteLine("Press ENTER to go back.");
        }
    }
}
