using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm2
{
    internal class SalesManager: ProjectManager
    {
            private bool _canManageSales;

            public bool CanManageSales
            {
                get { return _canManageSales; }
                set { _canManageSales = value; }
            }
    }
}
