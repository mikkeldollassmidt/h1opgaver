using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm2
{
    internal class ContentWriter: SocialMediaManager
    {
            private bool _canWriteContent;

            public bool CanWriteContent
            {
                get { return _canWriteContent; }
                set { _canWriteContent = value; }
            }
    }
}
