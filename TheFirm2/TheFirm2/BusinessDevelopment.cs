using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm2
{
    internal class BusinessDevelopment: LegalCounsel
    {
        private bool _canDevelopBusiness;

        public bool CanDevelopBusiness
        {
            get { return _canDevelopBusiness; }
            set { _canDevelopBusiness = value; }
        }
    }
}
