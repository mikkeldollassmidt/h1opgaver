using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm
{
    public class Controller
    {
        // Creates objects for every type worker.
        Employee e = new Employee();
        Manager m = new Manager();
        ProjectManager p = new ProjectManager();
        Sweeper s = new Sweeper();

        // Adds a default employee and displays.
        public void AddDefaultEmployee()
        {
            e.firstName = "Jens";
            e.lastName = "Hansen";
            e.cprNo = "210893-1234";
            e.DisplayEmployee();
        }
        // Adds a default manager and displays.
        public void AddDefaultManager()
        {
            m.firstName = "Morten";
            m.lastName = "Jensen";
            m.cprNo = "311093-1234";
            m.phoneNo= "+45 23 92 85 21";
            m.DisplayManager();
        }
        // Adds a default project manager and displays.
        public void AddDefaultProjectManager()
        {
            p.firstName = "Olaf";
            p.lastName = "Sørensen";
            p.cprNo = "241200-1234";
            p.phoneNo = "+45 92 78 61 29";
            p.email = "olaftheswag@hotmail.ok";
            p.DisplayProjectManager();
        }
        // Adds a default sweeper and displays.
        public void AddDefaultSweeper()
        {
            s.firstName = "Søs";
            s.lastName = "Lindgren";
            s.cprNo = "240805-1234";
            s.DisplaySweeper();
        }
    }
}
