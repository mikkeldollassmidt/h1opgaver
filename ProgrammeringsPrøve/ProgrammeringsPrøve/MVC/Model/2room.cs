using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammeringsPrøve.MVC.Model
{
    internal class _2room : Apartments
    {
        public _2room()
        {
            livingRoom = true;
            kitchen = true;
            bathroom = true;
            room = 1;
            squareMeter = 55;
            normalWindow = 3;
            windowsWithMatte = 1;
            door = 4;
        }
        public override void ShowApartmentInformation()
        {
            Console.WriteLine($"This is a 2 room apartment within {squareMeter}m². And includes:\nA livingroom: {livingRoom}\nA kitchen: {kitchen}\nA bathroom: {bathroom}\nRoom count: {room}\nNormal windows: {normalWindow}\nMatte windows (bathroom): {windowsWithMatte}\nDoors: {door}\n");
        }
    }
}
