using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System.Threading;
using BasicFacebookFeatures.Logic;

namespace BasicFacebookFeatures
{
    public partial class FormBestFriend : Form
    {
        private User m_LoggedInUser;

        private BestFriendLogic m_BestFriend;
        public BestFriendStrategy m_FilterStrategy;

        public FormBestFriend(User i_LoggedInUser = null)
        {
            m_LoggedInUser = i_LoggedInUser;
            m_BestFriend = new BestFriendLogic(m_LoggedInUser);
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            textBoxFriendFilter.Text = string.Empty;
        }

        public void fetchTheFriendByFilter()
        {
            try
            {
                if (m_BestFriend.FetchTheFriendByFilter(m_FilterStrategy) != null)
                {
                    textBoxFriendFilter.Invoke(new Action(() =>
                    textBoxFriendFilter.Text = m_BestFriend.FetchTheFriendByFilter(m_FilterStrategy)));
                }
            }
            catch (Exception)
            {
                textBoxFriendFilter.Invoke(new Action(() =>
                textBoxFriendFilter.Text = "no permissions!!!"));
            }
        }

        private void buttonFriendCommetYouTheMost_Click(object sender, EventArgs e)
        {
            m_FilterStrategy = new BestFriendStrategy(new BestFriendCommentFilter(m_LoggedInUser));
            fetchTheFriendByFilter();
        }

        private void buttonFriendLikesYouTheMost_Click(object sender, EventArgs e)
        {
            m_FilterStrategy = new BestFriendStrategy(new BestFriendLikesFilter(m_LoggedInUser));
            fetchTheFriendByFilter();
        }
    }
}
