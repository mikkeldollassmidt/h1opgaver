using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammeringsPrøve.MVC.Model
{
    internal class _5room: Apartments
    {
        public _5room()
        {
            livingRoom = true;
            kitchen = true;
            bathroom = true;
            room = 4;
            squareMeter = 110;
            normalWindow = 6;
            windowsWithMatte = 1;
            door = 7;
        }
        public override void ShowApartmentInformation()
        {
            Console.WriteLine($"This is a 5 room apartment within {squareMeter}m². And includes:\nA livingroom: {livingRoom}\nA kitchen: {kitchen}\nA bathroom: {bathroom}\nRoom count: {room}\nNormal windows: {normalWindow}\nMatte windows (bathroom): {windowsWithMatte}\nDoors: {door}\n");
        }
    }
}
