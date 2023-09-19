using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm2
{
    internal class HRManager: SalesManager
    {
        private bool _canManageHR;

        public bool CanManageHR
        {
            get { return _canManageHR; }
            set { _canManageHR = value; }
        }
    }
}
