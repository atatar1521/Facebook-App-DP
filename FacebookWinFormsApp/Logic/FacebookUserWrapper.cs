using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
     public class FacebookUserWrapper
    {
        public FacebookUserWrapper(User i_User)
        {
            m_UserWrapper = i_User;
            m_Counter = 0;
        }

        public User m_UserWrapper
        {
            get;
            set;
        }

        public int m_Counter
        {
            get;
            set;
        }
    }
}
