using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm2
{
    internal class CustomerService: BusinessDevelopment
    {
        private bool _canCustomerService;

        public bool CanCustomerSerice
        {
            get { return _canCustomerService; }
            set { _canCustomerService = value; }
        }
    }
}
