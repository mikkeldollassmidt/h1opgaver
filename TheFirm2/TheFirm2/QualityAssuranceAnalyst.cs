using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm2
{
    internal class QualityAssuranceAnalyst: SocialMediaManager
    {
        private bool _canAnylize;

        public bool CanWriteContent
        {
            get { return _canAnylize; }
            set { _canAnylize = value; }
        }
    }
}
