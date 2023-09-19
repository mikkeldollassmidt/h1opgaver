using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm2
{
    internal class Accountant: CustomerService
    {
        private bool _canCountMoney;

        public bool CanCountMoney
        {
            get { return _canCountMoney; }
            set { _canCountMoney = value; }
        }
    }
}
