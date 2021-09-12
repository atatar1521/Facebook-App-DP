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
    public class BestFriendCommentFilter : IBestFriendFilterStrategy
    {
        private User m_LoggedInUser;

        public BestFriendCommentFilter(User i_LoggedInUser)
        {
            m_LoggedInUser = i_LoggedInUser;
        }

        public void updateFriendsCounter(Dictionary<string, FacebookUserWrapper> i_FbFriendsCollection)
        {
            foreach (Post post in m_LoggedInUser.Posts)
            {
                foreach (Comment comment in post.Comments)
                {
                    if (i_FbFriendsCollection.ContainsKey(comment.From.Id))
                    {
                        i_FbFriendsCollection[comment.From.Id].m_Counter++;
                    }
                }
            }
        }

    }
}
