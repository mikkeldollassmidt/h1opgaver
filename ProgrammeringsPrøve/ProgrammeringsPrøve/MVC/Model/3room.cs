using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammeringsPrøve.MVC.Model
{
    internal class _3room: Apartments
    {
        public _3room()
        {
            livingRoom = true;
            kitchen = true;
            bathroom = true;
            room = 2;
            squareMeter = 70;
            normalWindow = 4;
            windowsWithMatte = 1;
            door = 5;
        }
        public override void ShowApartmentInformation()
        {
            Console.WriteLine($"This is a 3 room apartment within {squareMeter}m². And includes:\nA livingroom: {livingRoom}\nA kitchen: {kitchen}\nA bathroom: {bathroom}\nRoom count: {room}\nNormal windows: {normalWindow}\nMatte windows (bathroom): {windowsWithMatte}\nDoors: {door}\n");
        }
    }
}
