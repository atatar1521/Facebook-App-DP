using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using BasicFacebookFeatures.Logic;

namespace BasicFacebookFeatures
{
    public class BestFriendLogic
    {
        private User m_LoggedInUser;

        public BestFriendStrategy m_counterStrategy;

        public BestFriendLogic(User i_LoggedInUser)
        {
            m_LoggedInUser = i_LoggedInUser;
        }

        public string FetchTheFriendByFilter(BestFriendStrategy i_Filter)
        {
            User bestFriendByFilter = null;
            Dictionary<string, FacebookUserWrapper> friendsFilterType = new Dictionary<string, FacebookUserWrapper>();
            m_counterStrategy = i_Filter;
            if (m_LoggedInUser.Friends.Count > 0)
            {
                foreach (User fbFriend in m_LoggedInUser.Friends)
                {
                    friendsFilterType.Add(fbFriend.Id, new FacebookUserWrapper(fbFriend));
                }
                m_counterStrategy.m_Strategy.updateFriendsCounter(friendsFilterType);
                bestFriendByFilter = getMaximumCounter(friendsFilterType);
            }

            return updateBestFriend(bestFriendByFilter);
        }

        public User getMaximumCounter(Dictionary<string, FacebookUserWrapper> i_FbFriendsCollection)
        {
            int maxCounter = 0;
            User friendToReturn = null;

            foreach (KeyValuePair<string, FacebookUserWrapper> friend in i_FbFriendsCollection)
            {
                if (friend.Value.m_Counter > maxCounter)
                {
                    friendToReturn = friend.Value.m_UserWrapper;
                    maxCounter = friend.Value.m_Counter;
                }
            }

            return friendToReturn;
        }

        public string updateBestFriend(User i_BestFriend)
        {
            if (i_BestFriend != null)
            {
                return i_BestFriend.UserName;
            }
            else
            {
                return "There are no Best friend";
            }
        }
    }
}