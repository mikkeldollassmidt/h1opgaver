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
        private List<Animal> allAnimals;

        //Makes a property for the attribute
        public List<Animal> AllAnimals
        {
            get { return allAnimals; }
            private set { allAnimals = value; }
        }

        // Constructor for the attribute
        public BreedingStation()
        {
            allAnimals = new List<Animal>();
            InitializeAnimals();
        }

        // Startup animals added to queue
        public void InitializeAnimals()
        {
            allAnimals.Add(new Dog());
            allAnimals.Add(new Rabbit());
            allAnimals.Add(new Hen());
        }
        // Shows all animals with foreach
        public void ListAllAnimals(List<Animal> allAnimals)
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
