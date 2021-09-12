using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System.Threading;
using BasicFacebookFeatures.UI;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        User m_LoggedInUser;
        LoginResult m_LoginResult;
        private IDecoratedButton m_LoginButton;


        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 10;
        }

        private void loginAndInit()
        {
            m_LoginResult = FacebookService.Login(
                "403397437659526",
                "public_profile",
                "email",
                "publish_to_groups",
                "user_birthday",
                "user_age_range",
                "user_gender",
                "user_link",
                "user_friends",
                "user_events",
                "user_likes",
                "user_location",
                "user_photos",
                "user_posts",
                "user_hometown");

            if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
            {
                m_LoggedInUser = m_LoginResult.LoggedInUser;
            }
            else
            {
                MessageBox.Show(m_LoginResult.ErrorMessage, "Login Failed");
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("design.patterns.c21");
            loginAndInit();
            FormHomePage homePage = new FormHomePage(m_LoginResult, m_LoggedInUser);
            homePage.ShowDialog();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            m_LoginButton = new DecoratorText(new DecoratorSetBackground(new DecoratorFont(new CoreButton(buttonLogin)), Color.LightCyan), "Login");
            m_LoginButton.Execute();
        }
    }
}