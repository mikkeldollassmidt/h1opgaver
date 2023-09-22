using ProgrammeringsPrøve.MVC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammeringsPrøve.MVC.Controller
{
    internal class ApartmentDetails
    {
        /// <summary>
        /// ShowAllApartmentDetails is made to show all the apartments details.
        /// </summary>
        public void ShowAllApartmentDetails()
        {
            _1room one = new _1room();
            _2room two = new _2room();
            _3room three = new _3room();
            _4room four = new _4room();
            _5room five = new _5room();

            Console.ForegroundColor= ConsoleColor.Black;
            Console.BackgroundColor= ConsoleColor.White;
            one.ShowApartmentInformation();
            two.ShowApartmentInformation();
            three.ShowApartmentInformation();
            four.ShowApartmentInformation();    
            five.ShowApartmentInformation();
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
