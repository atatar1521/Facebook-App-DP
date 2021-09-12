namespace BasicFacebookFeatures
{
    partial class FormHomePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label createdTimeLabel;
            System.Windows.Forms.Label updateTimeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHomePage));
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.postBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listBoxAlbums = new System.Windows.Forms.ListBox();
            this.listBoxBirthday = new System.Windows.Forms.ListBox();
            this.linkLabelBirthday = new System.Windows.Forms.LinkLabel();
            this.friendsListBox = new System.Windows.Forms.ListBox();
            this.labelProfileName = new System.Windows.Forms.Label();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.textBoxPostStatus = new System.Windows.Forms.TextBox();
            this.buttonPostStatus = new System.Windows.Forms.Button();
            this.buttonBestFriend = new System.Windows.Forms.Button();
            this.pictureBoxSelectedFriend = new System.Windows.Forms.PictureBox();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.buttonMostAttractiveFeature = new System.Windows.Forms.Button();
            this.buttonEvents = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.createdTimeLabel1 = new System.Windows.Forms.Label();
            this.updateTimeLabel1 = new System.Windows.Forms.Label();
            this.taggedUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.commentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelPosts = new System.Windows.Forms.Label();
            this.labelAlbums = new System.Windows.Forms.Label();
            this.labelFriends = new System.Windows.Forms.Label();
            createdTimeLabel = new System.Windows.Forms.Label();
            updateTimeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedFriend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taggedUsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // createdTimeLabel
            // 
            createdTimeLabel.AutoSize = true;
            createdTimeLabel.Location = new System.Drawing.Point(16, 17);
            createdTimeLabel.Name = "createdTimeLabel";
            createdTimeLabel.Size = new System.Drawing.Size(73, 13);
            createdTimeLabel.TabIndex = 0;
            createdTimeLabel.Text = "Created Time:";
            // 
            // updateTimeLabel
            // 
            updateTimeLabel.AutoSize = true;
            updateTimeLabel.Location = new System.Drawing.Point(16, 40);
            updateTimeLabel.Name = "updateTimeLabel";
            updateTimeLabel.Size = new System.Drawing.Size(71, 13);
            updateTimeLabel.TabIndex = 2;
            updateTimeLabel.Text = "Update Time:";
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.DataSource = this.postBindingSource;
            this.listBoxPosts.DisplayMember = "Message";
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.Location = new System.Drawing.Point(432, 192);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(187, 95);
            this.listBoxPosts.TabIndex = 71;
            // 
            // postBindingSource
            // 
            this.postBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Post);
            // 
            // listBoxAlbums
            // 
            this.listBoxAlbums.FormattingEnabled = true;
            this.listBoxAlbums.Location = new System.Drawing.Point(222, 192);
            this.listBoxAlbums.Name = "listBoxAlbums";
            this.listBoxAlbums.Size = new System.Drawing.Size(187, 173);
            this.listBoxAlbums.TabIndex = 70;
            // 
            // listBoxBirthday
            // 
            this.listBoxBirthday.FormattingEnabled = true;
            this.listBoxBirthday.Location = new System.Drawing.Point(411, 402);
            this.listBoxBirthday.Name = "listBoxBirthday";
            this.listBoxBirthday.Size = new System.Drawing.Size(208, 56);
            this.listBoxBirthday.TabIndex = 68;
            // 
            // linkLabelBirthday
            // 
            this.linkLabelBirthday.AutoSize = true;
            this.linkLabelBirthday.Location = new System.Drawing.Point(409, 389);
            this.linkLabelBirthday.Name = "linkLabelBirthday";
            this.linkLabelBirthday.Size = new System.Drawing.Size(93, 13);
            this.linkLabelBirthday.TabIndex = 67;
            this.linkLabelBirthday.TabStop = true;
            this.linkLabelBirthday.Text = "who has birthday?";
            this.linkLabelBirthday.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelBirthday_LinkClicked);
            // 
            // friendsListBox
            // 
            this.friendsListBox.FormattingEnabled = true;
            this.friendsListBox.Location = new System.Drawing.Point(12, 192);
            this.friendsListBox.Name = "friendsListBox";
            this.friendsListBox.Size = new System.Drawing.Size(187, 173);
            this.friendsListBox.TabIndex = 65;
            this.friendsListBox.SelectedIndexChanged += new System.EventHandler(this.friendsListBox_SelectedIndexChanged);
            // 
            // labelProfileName
            // 
            this.labelProfileName.AutoSize = true;
            this.labelProfileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProfileName.Location = new System.Drawing.Point(142, 12);
            this.labelProfileName.Name = "labelProfileName";
            this.labelProfileName.Size = new System.Drawing.Size(106, 24);
            this.labelProfileName.TabIndex = 75;
            this.labelProfileName.Text = "label Name";
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(734, 425);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(128, 33);
            this.buttonLogout.TabIndex = 73;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // labelBirthday
            // 
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBirthday.Location = new System.Drawing.Point(142, 53);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(122, 24);
            this.labelBirthday.TabIndex = 76;
            this.labelBirthday.Text = "label Birthday";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGender.Location = new System.Drawing.Point(142, 100);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(119, 24);
            this.labelGender.TabIndex = 77;
            this.labelGender.Text = "label Gender";
            // 
            // textBoxPostStatus
            // 
            this.textBoxPostStatus.Location = new System.Drawing.Point(85, 402);
            this.textBoxPostStatus.Multiline = true;
            this.textBoxPostStatus.Name = "textBoxPostStatus";
            this.textBoxPostStatus.Size = new System.Drawing.Size(271, 56);
            this.textBoxPostStatus.TabIndex = 87;
            // 
            // buttonPostStatus
            // 
            this.buttonPostStatus.Location = new System.Drawing.Point(0, 402);
            this.buttonPostStatus.Name = "buttonPostStatus";
            this.buttonPostStatus.Size = new System.Drawing.Size(79, 28);
            this.buttonPostStatus.TabIndex = 86;
            this.buttonPostStatus.Text = "Post";
            this.buttonPostStatus.UseVisualStyleBackColor = true;
            this.buttonPostStatus.Click += new System.EventHandler(this.buttonPostStatus_Click);
            // 
            // buttonBestFriend
            // 
            this.buttonBestFriend.BackColor = System.Drawing.SystemColors.Window;
            this.buttonBestFriend.BackgroundImage = global::BasicFacebookFeatures.Properties.Resources._20;
            this.buttonBestFriend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonBestFriend.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonBestFriend.Location = new System.Drawing.Point(471, 12);
            this.buttonBestFriend.Name = "buttonBestFriend";
            this.buttonBestFriend.Size = new System.Drawing.Size(180, 142);
            this.buttonBestFriend.TabIndex = 88;
            this.buttonBestFriend.Text = "Best Friend Feature";
            this.buttonBestFriend.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonBestFriend.UseVisualStyleBackColor = false;
            this.buttonBestFriend.Click += new System.EventHandler(this.buttonBestFriend_Click);
            // 
            // pictureBoxSelectedFriend
            // 
            this.pictureBoxSelectedFriend.Location = new System.Drawing.Point(121, 282);
            this.pictureBoxSelectedFriend.Name = "pictureBoxSelectedFriend";
            this.pictureBoxSelectedFriend.Size = new System.Drawing.Size(78, 83);
            this.pictureBoxSelectedFriend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSelectedFriend.TabIndex = 85;
            this.pictureBoxSelectedFriend.TabStop = false;
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(20, 12);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(125, 112);
            this.pictureBoxProfile.TabIndex = 74;
            this.pictureBoxProfile.TabStop = false;
            // 
            // buttonMostAttractiveFeature
            // 
            this.buttonMostAttractiveFeature.BackColor = System.Drawing.SystemColors.Window;
            this.buttonMostAttractiveFeature.BackgroundImage = global::BasicFacebookFeatures.Properties.Resources.Social_media_likes_e1548412432379;
            this.buttonMostAttractiveFeature.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMostAttractiveFeature.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonMostAttractiveFeature.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonMostAttractiveFeature.Location = new System.Drawing.Point(657, 12);
            this.buttonMostAttractiveFeature.Name = "buttonMostAttractiveFeature";
            this.buttonMostAttractiveFeature.Size = new System.Drawing.Size(180, 142);
            this.buttonMostAttractiveFeature.TabIndex = 66;
            this.buttonMostAttractiveFeature.Text = "Most Attractive Feature";
            this.buttonMostAttractiveFeature.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonMostAttractiveFeature.UseVisualStyleBackColor = false;
            this.buttonMostAttractiveFeature.Click += new System.EventHandler(this.buttonMostAttractiveFeature_Click);
            // 
            // buttonEvents
            // 
            this.buttonEvents.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonEvents.BackgroundImage")));
            this.buttonEvents.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEvents.Location = new System.Drawing.Point(634, 192);
            this.buttonEvents.Name = "buttonEvents";
            this.buttonEvents.Size = new System.Drawing.Size(228, 169);
            this.buttonEvents.TabIndex = 91;
            this.buttonEvents.Text = "Events ";
            this.buttonEvents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEvents.UseVisualStyleBackColor = true;
            this.buttonEvents.Click += new System.EventHandler(this.buttonEvents_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(createdTimeLabel);
            this.panel1.Controls.Add(this.createdTimeLabel1);
            this.panel1.Controls.Add(updateTimeLabel);
            this.panel1.Controls.Add(this.updateTimeLabel1);
            this.panel1.Location = new System.Drawing.Point(433, 290);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 75);
            this.panel1.TabIndex = 92;
            // 
            // createdTimeLabel1
            // 
            this.createdTimeLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postBindingSource, "CreatedTime", true));
            this.createdTimeLabel1.Location = new System.Drawing.Point(95, 17);
            this.createdTimeLabel1.Name = "createdTimeLabel1";
            this.createdTimeLabel1.Size = new System.Drawing.Size(100, 23);
            this.createdTimeLabel1.TabIndex = 1;
            this.createdTimeLabel1.Text = "label1";
            // 
            // updateTimeLabel1
            // 
            this.updateTimeLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postBindingSource, "UpdateTime", true));
            this.updateTimeLabel1.Location = new System.Drawing.Point(95, 40);
            this.updateTimeLabel1.Name = "updateTimeLabel1";
            this.updateTimeLabel1.Size = new System.Drawing.Size(100, 23);
            this.updateTimeLabel1.TabIndex = 3;
            this.updateTimeLabel1.Text = "label1";
            // 
            // taggedUsersBindingSource
            // 
            this.taggedUsersBindingSource.DataMember = "TaggedUsers";
            this.taggedUsersBindingSource.DataSource = this.postBindingSource;
            // 
            // commentsBindingSource
            // 
            this.commentsBindingSource.DataMember = "Comments";
            this.commentsBindingSource.DataSource = this.postBindingSource;
            // 
            // labelPosts
            // 
            this.labelPosts.AutoSize = true;
            this.labelPosts.Location = new System.Drawing.Point(430, 176);
            this.labelPosts.Name = "labelPosts";
            this.labelPosts.Size = new System.Drawing.Size(33, 13);
            this.labelPosts.TabIndex = 93;
            this.labelPosts.Text = "Posts";
            // 
            // labelAlbums
            // 
            this.labelAlbums.AutoSize = true;
            this.labelAlbums.Location = new System.Drawing.Point(219, 176);
            this.labelAlbums.Name = "labelAlbums";
            this.labelAlbums.Size = new System.Drawing.Size(41, 13);
            this.labelAlbums.TabIndex = 94;
            this.labelAlbums.Text = "Albums";
            // 
            // labelFriends
            // 
            this.labelFriends.AutoSize = true;
            this.labelFriends.Location = new System.Drawing.Point(12, 175);
            this.labelFriends.Name = "labelFriends";
            this.labelFriends.Size = new System.Drawing.Size(41, 13);
            this.labelFriends.TabIndex = 95;
            this.labelFriends.Text = "Friends";
            // 
            // FormHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(876, 470);
            this.Controls.Add(this.labelFriends);
            this.Controls.Add(this.labelAlbums);
            this.Controls.Add(this.labelPosts);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonEvents);
            this.Controls.Add(this.buttonBestFriend);
            this.Controls.Add(this.textBoxPostStatus);
            this.Controls.Add(this.buttonPostStatus);
            this.Controls.Add(this.pictureBoxSelectedFriend);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.labelBirthday);
            this.Controls.Add(this.labelProfileName);
            this.Controls.Add(this.pictureBoxProfile);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.listBoxPosts);
            this.Controls.Add(this.listBoxAlbums);
            this.Controls.Add(this.listBoxBirthday);
            this.Controls.Add(this.linkLabelBirthday);
            this.Controls.Add(this.buttonMostAttractiveFeature);
            this.Controls.Add(this.friendsListBox);
            this.DoubleBuffered = true;
            this.Name = "FormHomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormHomePage";
            this.Load += new System.EventHandler(this.FormHomePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedFriend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taggedUsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.ListBox listBoxAlbums;
        private System.Windows.Forms.ListBox listBoxBirthday;
        private System.Windows.Forms.LinkLabel linkLabelBirthday;
        private System.Windows.Forms.Button buttonMostAttractiveFeature;
        private System.Windows.Forms.ListBox friendsListBox;
        private System.Windows.Forms.Label labelProfileName;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.PictureBox pictureBoxSelectedFriend;
        private System.Windows.Forms.TextBox textBoxPostStatus;
        private System.Windows.Forms.Button buttonPostStatus;
        private System.Windows.Forms.Button buttonBestFriend;
        private System.Windows.Forms.Button buttonEvents;
        private System.Windows.Forms.BindingSource postBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource taggedUsersBindingSource;
        private System.Windows.Forms.BindingSource commentsBindingSource;
        private System.Windows.Forms.Label createdTimeLabel1;
        private System.Windows.Forms.Label updateTimeLabel1;
        private System.Windows.Forms.Label labelPosts;
        private System.Windows.Forms.Label labelAlbums;
        private System.Windows.Forms.Label labelFriends;
    }
}