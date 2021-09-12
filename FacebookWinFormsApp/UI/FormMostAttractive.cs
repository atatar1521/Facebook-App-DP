using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System.Threading;
using BasicFacebookFeatures.Logic;


namespace BasicFacebookFeatures
{
    public partial class FormMostAttractive : Form
    {
        private User m_LoggedInUser;
        public ProxyPosts m_MostAttractive;

        public FormMostAttractive(ProxyPosts i_ProxyPost,User i_LoggedInUser = null)
        {
            m_LoggedInUser = i_LoggedInUser;
            m_MostAttractive = i_ProxyPost;
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            new Thread(fetchMostLikedPost).Start();
            new Thread(fetchPostWithMostComments).Start();
            new Thread (fetchMostCommentedPicture).Start();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            textBoxMostAttractivePostByComments.Text = string.Empty;
            textBoxMostLikePost.Text = string.Empty;
            pictureBoxMostCommentedPic.Image = null;
        }

        private void fetchMostCommentedPicture()
        {
            try
            {
                if (m_MostAttractive.FetchMostCommentedPicture() != null)
                {
                    pictureBoxMostCommentedPic.Invoke(new Action(() =>
                    pictureBoxMostCommentedPic.LoadAsync(m_MostAttractive.FetchMostCommentedPicture())));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No permission exception:(");
            }
        }

        private void fetchMostLikedPost()
        {
            try
            {
                if (m_MostAttractive.fetchMostLikedPost() != null)
                {
                    textBoxMostLikePost.Invoke(new Action(() =>
                    textBoxMostLikePost.Text = m_MostAttractive.fetchMostLikedPost()));
                }
            }
            catch (Exception)
            {
                textBoxMostLikePost.Invoke(new Action(() => 
                textBoxMostLikePost.Text = "No one Liked Your Post"));
            }
        }

        private void fetchPostWithMostComments()
        {
            try
            {
                if (m_MostAttractive.fetchPostWithMostComments() != null)
                {
                    textBoxMostAttractivePostByComments.Invoke(new Action(() =>
                    textBoxMostAttractivePostByComments.Text = m_MostAttractive.fetchPostWithMostComments()));
                }
            }
            catch (Exception)
            {
                textBoxMostAttractivePostByComments.Invoke(new Action(() =>
                textBoxMostAttractivePostByComments.Text = "No one comment on your posts"));
            }
        }
    }
}
