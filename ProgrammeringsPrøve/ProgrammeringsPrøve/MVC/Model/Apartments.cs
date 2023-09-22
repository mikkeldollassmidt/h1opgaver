using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammeringsPrøve.MVC.Model
{
    abstract class Apartments
    {
        protected bool livingRoom;
        protected bool kitchen;
        protected bool bathroom;
        protected byte room;
        protected byte squareMeter;
        protected byte normalWindow;
        protected byte windowsWithMatte;
        protected byte door;

        public virtual void ShowApartmentInformation()
        {
            Console.WriteLine("No information atm. Stay updated.");
        }
    }
}
