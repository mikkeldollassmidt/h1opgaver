using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdrætterstation
{
    internal class Hen : Animal
    {
        public Hen()
        {
            animalType = "Hen";
            sex = "She";
            reproduction = "Oviparous";
            hasLegs = true;
            numberOfLegs = 2;
            hasFur = false;
            furType = "No fur";
            departingAge = 2;
        }
    }
}
