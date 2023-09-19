using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm
{
    public class Manager:Employee
    {
        // Attribute
        private string _phoneNo;

        // Property
        public string phoneNo
        {
            get { return _phoneNo; }
            set { _phoneNo = value; }
        }
        // Method to display managers's data
        public void DisplayManager()
        {
            Console.WriteLine("Manager:");
            Console.WriteLine($"Firstname: {firstName}\nLastname: {lastName}\nCpr no: {cprNo}\nPhone no.: {phoneNo}\n");
        }
    }
}
