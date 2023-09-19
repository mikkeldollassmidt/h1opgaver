using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm2
{
    internal class SocialMediaManager : ResearchAnalyst
    {
        private bool _hasLoginToSocialMedia;
        public bool HasLoginToSocialMedia
        {
            get { return _hasLoginToSocialMedia; }
            set { _hasLoginToSocialMedia = value; }
        }
    }
}
