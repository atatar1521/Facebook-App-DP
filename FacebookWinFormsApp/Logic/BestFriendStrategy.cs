using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures.Logic
{
    public class BestFriendStrategy
    {
        public IBestFriendFilterStrategy m_Strategy { get; set; }

        public BestFriendStrategy(IBestFriendFilterStrategy i_Strategy)
        {
            m_Strategy = i_Strategy;
        }
    }
}
