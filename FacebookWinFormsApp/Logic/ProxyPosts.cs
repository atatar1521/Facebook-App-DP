using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using BasicFacebookFeatures.UI;
using BasicFacebookFeatures.Logic;
using System.Windows.Forms;

namespace BasicFacebookFeatures.Logic
{
    public enum eColor
    {
        Red = 0,
        Yellow,
        Green
    }

    public sealed class ProxyPosts : MostAttractiveLogic
    {
        private User m_LoggedInUser;

        public ProxyPosts(User i_LoggedInUser = null)
            : base(i_LoggedInUser)
        {
            m_LoggedInUser = i_LoggedInUser;
            AllPosts = new List<Post>();
            fetchPosts();
        }

        public List<Post> AllPosts
        {
            get;
            private set;
        }

        private void fetchPosts()
        {
            try
            {
                if (m_LoggedInUser.Posts.Count > 0 && m_LoggedInUser.Posts.Count > AllPosts.Count)
                {
                    foreach (Post fbPost in m_LoggedInUser.Posts)
                    {
                        AllPosts.Add(fbPost);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Posts List - permission error !!!!");
            }
        }

        public bool IsChanged
        {
            get
            {
                bool v_IsChanged = AllPosts.Count != m_LoggedInUser.Posts.Count;
                return v_IsChanged;
            }
        }

        public void UpdatePostsList()
        {
            if (IsChanged)
            {
                fetchPosts();
            }
        }

        public string fetchMostLikedPost()
        {
            string msg = string.Empty;
            Post mostLikedPost = null;
            int maxLikes = 0;
            try
            {
                UpdatePostsList();
                foreach (Post ProxyPost in AllPosts)
                {
                    if (ProxyPost.LikedBy.Count > maxLikes)
                    {
                        maxLikes = ProxyPost.LikedBy.Count;
                        mostLikedPost = ProxyPost;
                    }
                }

                if (maxLikes > 0)
                {
                    msg = mostLikedPost.Message;
                }

                if (maxLikes == 0)
                {
                    msg = "You have zero likes :(";
                }

                return msg;
            }
            catch
            {
                return "There are no permissions to access the Likes list of your posts";
            }
        }

        public string fetchPostWithMostComments()
        {
            string msg = string.Empty;
            Post mostCommented = null;
            int maxComments = 0;
            try
            {
                UpdatePostsList();
                foreach (Post ProxyPost in AllPosts)
                {
                    if (ProxyPost.Comments.Count > maxComments)
                    {
                        maxComments = ProxyPost.Comments.Count;
                        mostCommented = ProxyPost;
                    }
                }

                if (maxComments > 0)
                {
                    msg = mostCommented.Message;
                }

                if (maxComments == 0)
                {
                    msg = "You have zero likes :(";
                }

                return msg;
            }
            catch
            {
                return "There are no permissions to access the Comments list of your posts";
            }
        }
    }
}