using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace Opdrætterstation
{
    internal abstract class Animal
    {
        protected string animalType;
        protected string sex;
        protected string reproduction;
        protected bool hasLegs;
        protected byte numberOfLegs;
        protected bool hasFur;
        protected string furType;
        protected byte departingAge;

        internal string AnimalType
        {
            get { return animalType; }
            private set { animalType = value; }
        }
        internal string Sex
        {
            get { return sex; }
            private set { sex = value; }
        }
        internal string Reproduction
        {
            get { return reproduction; }
            private set { reproduction = value; }
        }
        internal bool HasLegs
        {
            get { return hasLegs; }
            private set { hasLegs = value; }
        }
        internal byte NumberOfLegs
        {
            get { return numberOfLegs; }
            private set { numberOfLegs = value; }
        }
        internal bool HasFur
        {
            get { return hasFur; }
            private set { hasFur = value; }
        }
        internal string FurType
        {
            get { return furType; }
            private set { furType = value; }
        }
        internal byte DepartingAge
        {
            get { return departingAge; }
            private set { departingAge = value; }
        }
    }
}
