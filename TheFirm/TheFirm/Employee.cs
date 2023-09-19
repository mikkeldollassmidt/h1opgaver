using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TheFirm
{
    public class Employee
    {
        // Attributes
        private string _firstName;
        private string _lastName;
        private string _cprNo;

        // Properties
        public string firstName 
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string lastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public string cprNo
        {
            get { return _cprNo; }
            set { _cprNo = value; }
        }
        // Method to display employee's data
        public void DisplayEmployee()
        {
            Console.WriteLine("Employee:");
            Console.WriteLine($"Firstname: {firstName}\nLastname: {lastName}\nCpr no: {cprNo}\n");
        }
    }
}
