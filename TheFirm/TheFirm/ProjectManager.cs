using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm
{
    public class ProjectManager:Manager
    {
        // Attribute
        private string _email;

        // Property
        public string email
        {
            get { return _email; }
            set { _email = value; }
        }
        // Method to display project manager's data
        public void DisplayProjectManager()
        {
            Console.WriteLine("Project Manager:");
            Console.WriteLine($"Firstname: {firstName}\nLastname: {lastName}\nCpr no: {cprNo}\nPhone no.: {phoneNo}\n Email: {email}\n");
        }
    }
}
