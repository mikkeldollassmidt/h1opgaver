using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdrætterstation
{
    internal class Rabbit: Animal
    {
        public Rabbit()
        {
            animalType = "Rabbit";
            sex = "She";
            reproduction = "Mammal";
            hasLegs = true;
            numberOfLegs = 4;
            hasFur = true;
            furType = "White fuzzy fur.";
            departingAge = 2;
        }
    }
}
