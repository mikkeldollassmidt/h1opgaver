using ProgrammeringsPrøve.MVC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammeringsPrøve.MVC.Controller
{
    internal class BudgetHandling
    {
        BoGodtBudget bgb = new BoGodtBudget();
        public void PrintBudget()
        {
            BudgetMessage();
        }

        // This method minus the budget with renovation cost. The if is used to not have the budget in minus
        public void MinusBudget(double value)
        {
            if ((bgb.BgBudget - value)>0)
            {
                bgb.BgBudget = bgb.BgBudget - value;
            }
        }

        // Chooses if the budget is gonna be green, yellow or darkred according to the budgets value.
        public void CheckBudgetColor()
        {
            if (bgb.BgBudget > 100000000)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if (bgb.BgBudget > 1000000)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
            }
        }

        // Layout for showing the budget.
        public void BudgetMessage()
        {
            Console.Write("The budget is currently on: ");
            CheckBudgetColor();
            Console.WriteLine(Math.Round(bgb.BgBudget, 2));
            Console.ForegroundColor = ConsoleColor.White;
        }

    }
}
