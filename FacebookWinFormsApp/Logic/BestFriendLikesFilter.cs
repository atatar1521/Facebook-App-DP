using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using BasicFacebookFeatures.Logic;

namespace BasicFacebookFeatures.Logic
{
    public class BestFriendLikesFilter : IBestFriendFilterStrategy
    {
        private User m_LoggedInUser;

        public BestFriendLikesFilter(User i_LoggedInUser)
        {
            m_LoggedInUser = i_LoggedInUser;
        }

        public void updateFriendsCounter(Dictionary<string, FacebookUserWrapper> i_FbFriendsCollection)
        {
            foreach (Post post in m_LoggedInUser.Posts)
            {
                foreach (User fbFriend in post.LikedBy)
                {
                    if (i_FbFriendsCollection.ContainsKey(fbFriend.Id))
                    {
                        i_FbFriendsCollection[fbFriend.Id].m_Counter++;
                    }
                }
            }
        }

    }
}
