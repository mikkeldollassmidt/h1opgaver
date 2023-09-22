using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammeringsPrøve.MVC.Model
{
    internal class ApartmentLists
    {
        private float five = 47;
        private float four = 97;
        private float three = 167;
        private float two = 235;
        private float one = 368;

        public float Five
        {
            get { return five; }
            set { five = value; }
        }
        public float Four
        {
            get { return four; }
            set { four = value; }
        }
        public float Three
        {
            get { return three; }
            set { three = value; }
        }
        public float Two
        {
            get { return two; }
            set { two = value; }
        }
        public float One
        {
            get { return one; }
            set { one = value; }
        }

        // AddRenovations method is used to plus everytime there is a renovation.
        public void AddRenovations(string appartmentType)
        {
            if (appartmentType == "five")
            {
                Five++;
            }
            else if (appartmentType == "four")
            {
                Four++;
            }
            else if (appartmentType == "three")
            {
                Three++;
            }
            else if (appartmentType == "two")
            {
                Two++;
            }
            else
            {
                One++;
            }
        }
    }
}
