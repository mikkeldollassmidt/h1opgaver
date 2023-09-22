using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammeringsPrøve.MVC.Model
{
    internal class BoGodtBudget
    {
        private double bgBudget = 550000000;
        public double BgBudget 
        { 
            get { return bgBudget; }
            set { bgBudget = value; }
        }
    }
}
