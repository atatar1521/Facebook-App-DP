using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.Logic
{
    public interface IBestFriendFilterStrategy
    {
        void updateFriendsCounter(Dictionary<string, FacebookUserWrapper> i_FbFriendsCollection);
    }

}
