using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdrætterstation
{
    internal class Animal
    {
        private string _animalType;
        private string _sex;
        private string _reproduction;
        private bool _hasLegs;
        private byte _numberOfLegs;
        private bool _hasFur;
        private string _furType;
        private byte _departingAge;

        public string AnimalType
        {
            get { return _animalType; }
            private set { _animalType = value; }
        }
        public string Sex
        {
            get { return _sex; }
            private set { _sex = value; }
        }
        public string Reproduction
        {
            get { return _reproduction; }
            private set { _reproduction = value; }
        }
        public bool HasLegs
        {
            get { return _hasLegs; }
            private set { _hasLegs = value; }
        }
        public byte NumberOfLegs
        {
            get { return _numberOfLegs; }
            private set { _numberOfLegs = value; }
        }
        public bool HasFur
        {
            get { return _hasFur; }
            private set { _hasFur = value; }
        }
        public string FurType
        {
            get { return _furType; }
            private set { _furType = value; }
        }
        public byte DepartingAge
        {
            get { return _departingAge; }
            private set { _departingAge = value; }
        }
        public Animal(string animalType, string sex, string reproduction, bool hasLegs, byte numberOfLegs, bool hasFur, string furType, byte departingAge)
        {
            _animalType = animalType;
            _sex = sex;
            _reproduction = reproduction;
            _hasLegs = hasLegs;
            _numberOfLegs = numberOfLegs;
            _hasFur = hasFur;
            _furType = furType;
            _departingAge = departingAge;
        }
        public Animal(string animalType, string sex, string reproduction, byte departingAge)
        {
            _animalType = animalType;
            _sex = sex;
            _reproduction = reproduction;
            _departingAge = departingAge;
        }
        public Animal()
        {
            
        }
    }
}
