using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm2
{
    internal class ProductManager: ITSupportSpecialist
    {
        private bool _canManageProducts;

        public bool CanManageProducts
        {
            get { return _canManageProducts; }
            set { _canManageProducts = value; }
        }
    }
}
