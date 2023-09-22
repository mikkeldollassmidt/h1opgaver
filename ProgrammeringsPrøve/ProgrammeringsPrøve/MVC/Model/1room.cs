using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammeringsPrøve.MVC.Model
{
    internal class _1room : Apartments
    {
        public _1room() 
        {
            livingRoom = true;
            kitchen = true;
            bathroom = true;
            room = 0;
            squareMeter = 40;
            normalWindow = 2;
            windowsWithMatte = 1;
            door = 3;
        }
        public override void ShowApartmentInformation()
        {
            Console.WriteLine($"This is a 1 room apartment within {squareMeter}m². And includes:\nA livingroom: {livingRoom}\nA kitchen: {kitchen}\nA bathroom: {bathroom}\nRoom count: {room}\nNormal windows: {normalWindow}\nMatte windows (bathroom): {windowsWithMatte}\nDoors: {door}\n");
        }
    }
}
