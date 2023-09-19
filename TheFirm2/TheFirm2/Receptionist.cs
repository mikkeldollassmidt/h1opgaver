using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm2
{
    internal class Receptionist: Employee
    {
        private string _name;
        public string Name 
        {
            get { return _name; } 
            set { _name = value; } 
        }
    }
}
