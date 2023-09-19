using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm2
{
    internal class LegalCounsel: GraphicDesigner
    {
        private bool _canLegalize;

        public bool CanLegalize
        {
            get { return _canLegalize; }
            set { _canLegalize = value; }
        }
    }
}
