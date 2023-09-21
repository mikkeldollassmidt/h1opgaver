using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdrætterstation
{
    internal class Dog : Animal
    {
        public Dog()
        {
            animalType = "Dog";
            sex = "He";
            reproduction = "Mammal";
            hasLegs = true;
            numberOfLegs = 4;
            hasFur = true;
            furType = "Short";
            departingAge = 1;
        }
    }
}
