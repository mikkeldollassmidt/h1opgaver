using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm2
{
    internal class Employee
    {
        // Attribute
        private string _salary;

        // Property
        public string salary
        {
            get { return _salary; }
            set { _salary = value; }
        }
    }
}
