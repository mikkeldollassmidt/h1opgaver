using ProgrammeringsPrøve.MVC.Controller;
using ProgrammeringsPrøve.MVC.Model;
using ProgrammeringsPrøve.MVC.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammeringsPrøve
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu m = new Menu();
            m.DisplayMenu();
        }
    }
}
