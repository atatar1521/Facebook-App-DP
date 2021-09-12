using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System.Threading;
using BasicFacebookFeatures.UI;
using BasicFacebookFeatures.Logic;

namespace BasicFacebookFeatures
{
    public partial class FormHomePage : Form
    {
        private User m_LoggedInUser;
        private LoginResult m_LoginResult;
        private FormMostAttractive m_FormMostAttractiveItems;
        private ProxyPosts m_ProxyPost;
        private FormBestFriend m_FormBestFriend;
        private FormEventComposer m_FormEvents;
        private IDecoratedButton m_LogoutButton;
        private IDecoratedButton m_PostButton;
        private PostNotifier m_PostNotifier;

        public FormHomePage(LoginResult i_LoggedInResult, User i_LoggedInUser = null)
        {
            m_LoggedInUser = i_LoggedInUser;
            m_LoginResult = i_LoggedInResult;
            m_PostNotifier = new PostNotifier();
            m_PostNotifier.UpdatingReplyPostID += this.showReplyPostIdOrUpdatingReplyPostID;
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            firstPart();
            secondPart();
            fetchAllPosts();
            new Thread(fetchUserInfo).Start();
            new Thread(fetchAllFriends).Start();
            new Thread(fetchAllAlbums).Start();
        }

        private void firstPart()
        {
            m_ProxyPost = new ProxyPosts(m_LoggedInUser);
            m_FormMostAttractiveItems = new FormMostAttractive(m_ProxyPost, m_LoggedInUser);
            m_FormEvents = new FormEventComposer(m_LoggedInUser);
        }

        private void secondPart()
        {
            m_FormBestFriend = new FormBestFriend(m_LoggedInUser);
        }

        private void fetchUserInfo()
        {
            pictureBoxProfile.LoadAsync(m_LoggedInUser.PictureNormalURL);
            labelProfileName.Invoke(new Action(() => labelProfileName.Text = $"{m_LoginResult.LoggedInUser.Name}"));
            labelBirthday.Invoke(new Action(() => labelBirthday.Text = $"Your Birthday : {m_LoginResult.LoggedInUser.Birthday}"));
            labelGender.Invoke(new Action(() => labelGender.Text = $"Gender : {m_LoginResult.LoggedInUser.Gender}"));
        }

        private void fetchAllFriends()
        {
            friendsListBox.Invoke(new Action(() => friendsListBox.Items.Clear()));
            friendsListBox.Invoke(new Action (() => friendsListBox.DisplayMember = "Name"));
            foreach (User friend in m_LoggedInUser.Friends)
            {
                friendsListBox.Invoke(new Action(() => friendsListBox.Items.Add(friend)));
            }

            if (friendsListBox.Items.Count == 0)
            {
                MessageBox.Show("No Friends to retrieve :(");
            }
        }

        private void fetchFriendsHaveBirthday()
        {
            try
            {
                DateTime today = DateTime.Now;
                listBoxBirthday.Items.Clear();
                if (m_LoggedInUser.Friends.Count > 0)
                {
                    foreach (User friend in m_LoggedInUser.Friends)
                    {
                        if (DateTime.Parse(friend.Birthday) == today)
                        {
                            listBoxBirthday.Items.Add(friend.Name);
                        }
                    }

                    if (listBoxBirthday.Items.Count == 0)
                    {
                        listBoxBirthday.Items.Add("None of your friends" + Environment.NewLine + "have a birthday today");
                    }
                }
                else
                {
                    listBoxBirthday.Items.Add("The friends list is empty");
                }
            }
            catch (Exception)
            {
                listBoxBirthday.Items.Add("Permission error !!!!");
            }
        }

        private void fetchAllAlbums()
        {
            listBoxAlbums.Invoke(new Action(() => listBoxAlbums.Items.Clear()));
            listBoxAlbums.Invoke(new Action(() => listBoxAlbums.DisplayMember = "Name"));
            foreach (Album album in m_LoggedInUser.Albums)
            {
                listBoxAlbums.Invoke(new Action(() => listBoxAlbums.Items.Add(album)));
            }

            if (listBoxAlbums.Items.Count == 0)
            {
                MessageBox.Show("No albums to retrieve :(");
            }
        }

        private void fetchAllPosts()
        {
            postBindingSource.DataSource = m_ProxyPost.AllPosts;
        }

        private void buttonMostAttractiveFeature_Click(object sender, EventArgs e)
        {
            if (m_FormMostAttractiveItems != null)
            {
                m_FormMostAttractiveItems.ShowDialog();
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookService.LogoutWithUI();
            this.Close();
            m_LoginResult = null;
        }

        private void buttonBestFriend_Click(object sender, EventArgs e)
        {
            if (m_FormBestFriend != null)
            {
                m_FormBestFriend.ShowDialog();
            }
        }


        private void friendsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            displaySelectedFriend();
        }

        private void displaySelectedFriend()
        {
            if (friendsListBox.SelectedItems.Count == 1)
            {
                User selectedFriend = friendsListBox.SelectedItem as User;
                if (selectedFriend.PictureNormalURL != null)
                {
                    pictureBoxSelectedFriend.LoadAsync(selectedFriend.PictureNormalURL);
                }
                else
                {
                    pictureBoxSelectedFriend.Image = null;
                }
            }
        }

        private void buttonPostStatus_Click(object sender, EventArgs e)
        {
            this.postStatus(this.textBoxPostStatus.Text);
            textBoxPostStatus.Invoke(new Action(() => textBoxPostStatus.Clear()));
        }

        public void showReplyPostIdOrUpdatingReplyPostID(string i_ReplyPostID)
        {
            if (i_ReplyPostID != "ERROR")
            {
                MessageBox.Show(string.Format("Status Post succeed (ID: {0})", i_ReplyPostID));
            }
            else
            {
                MessageBox.Show(string.Format("Status Post NOT succeed (ID: {0})", i_ReplyPostID));
            }
        }

        private void postStatus(string i_Status)
        {
            try
            {
                var replyPostID = m_LoggedInUser.PostStatus(i_Status);
                m_PostNotifier.onUpdateReplyPostID(replyPostID.ToString());
            }
            catch
            {
                m_PostNotifier.onUpdateReplyPostID("ERROR");
            }

        }

        private void buttonEvents_Click(object sender, EventArgs e)
        {
            if (m_FormEvents != null)
            {
                m_FormEvents.ShowDialog();
            }
        }

        private void FormHomePage_Load(object sender, EventArgs e)
        {
            m_LogoutButton = new DecoratorText(new DecoratorSetBackground(new DecoratorFont(new CoreButton(buttonLogout)), Color.IndianRed), "Logout");
            m_LogoutButton.Execute();
            m_PostButton = new DecoratorText(new DecoratorSetBackground(new DecoratorFont(new CoreButton(buttonPostStatus)), Color.LightSalmon), "Post");
            m_PostButton.Execute();
        }

        private void linkLabelBirthday_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fetchFriendsHaveBirthday();
        }
    }
}
