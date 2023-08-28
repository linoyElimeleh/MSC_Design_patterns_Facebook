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
using System.Collections;

namespace BasicFacebookFeatures
{
    public partial class MainAppForm : Form
    {
        private User m_LoggedInUser;
        private LoginResult m_LoginResult;
        private bool m_RememberUser;
        private AppSettings m_AppSetings;
        private FormMain m_FormMain;
        private Dictionary<string, string> m_CurrentFriendsList = new Dictionary<string, string>();

        public MainAppForm(FormMain i_FormMain, LoginResult i_LoginResult, bool i_RememberUser, AppSettings i_AppSetings)
        {
            m_FormMain = i_FormMain;
            m_LoginResult = i_LoginResult;
            m_LoggedInUser = m_LoginResult.LoggedInUser;
            m_RememberUser = i_RememberUser;
            m_AppSetings = i_AppSetings;
            this.Size = m_AppSetings.LastWindowsSize;
            this.Location = m_AppSetings.LastWindowsLocation;
            InitializeComponent();
        }
       
        protected override void OnShown(EventArgs i_)
        {
            this.FetchUserInfo();
            base.OnShown(i_);
        }

        protected override void OnFormClosing(FormClosingEventArgs i_)
        { 
            m_AppSetings.LastWindowsSize = this.Size;
            m_AppSetings.LastWindowsLocation = this.Location;
            m_AppSetings.RememberUser = m_RememberUser;
            List<Entry> friendsList = new List<Entry>();

            foreach (User user in m_LoggedInUser.Friends)
            {
                friendsList.Add(new Entry(user.Id, user.Name));
            }

            m_AppSetings.LastFriendList = friendsList;
            m_AppSetings.LastAccessToken = m_AppSetings.RememberUser ? m_LoginResult.AccessToken : null;
            m_AppSetings.SaveToFile();
            m_FormMain.Show();
            base.OnFormClosing(i_);
        }

        private void buttonLogout_Click(object i_Sender, EventArgs i_)
        {
            FacebookService.LogoutWithUI();
            m_AppSetings.LastWindowsSize = this.Size;
            m_AppSetings.LastWindowsLocation = this.Location;
            m_AppSetings.RememberUser = m_RememberUser;
            List<Entry> friendsList = new List<Entry>();

            foreach (User user in m_LoggedInUser.Friends)
            {
                friendsList.Add(new Entry(user.Id, user.Name));
            }

            m_AppSetings.LastFriendList = friendsList;
            m_AppSetings.LastAccessToken = m_AppSetings.RememberUser ? m_LoginResult.AccessToken : null;
            m_AppSetings.SaveToFile();
            this.Close();
            m_FormMain.Show();
        }

        public void FetchUserInfo()
        {
            Post lastPost;
            StringBuilder lastPostData = new StringBuilder();
            UserName.Text = m_LoggedInUser.UserName;

            OvalProfilePictureBox1.LoadAsync(m_LoggedInUser.PictureLargeURL);
            OvalProfilePictureBox2.LoadAsync(m_LoggedInUser.PictureLargeURL);
            OvalProfilePictureBox3.LoadAsync(m_LoggedInUser.PictureLargeURL);
            this.NameLabel1.Text += $" {m_LoggedInUser.FirstName} {m_LoggedInUser.LastName}";
            this.NameLabel2.Text += $" {m_LoggedInUser.FirstName} {m_LoggedInUser.LastName}";
            this.BithdayLabel1.Text += " " + m_LoggedInUser.Birthday;
            this.BithdayLabel2.Text += " " + m_LoggedInUser.Birthday;
            this.EmailLabel1.Text += " " + m_LoggedInUser.Email;
            this.EmailLabel2.Text += " " + m_LoggedInUser.Email;
            this.GenderLabel1.Text += " " + m_LoggedInUser.Gender.ToString();
            this.GenderLabel2.Text += " " + m_LoggedInUser.Gender.ToString();

            foreach (User user in m_LoggedInUser.Friends)
            {
                m_CurrentFriendsList.Add(user.Id, user.Name);
            }

            lastPost = m_LoggedInUser.Posts[0];
            this.LastPostTextBox.Text = lastPost.ToString();
            lastPostData.Append($"Create at: {lastPost.CreatedTime}\n");
            lastPostData.Append($"Comments amount: {lastPost.Comments.Count}\n");

            if (lastPost.TaggedUsers.Count != 0)
            {
                lastPostData.Append($"Tagged friends: ");
                foreach (User user in lastPost.TaggedUsers)
                {
                    lastPostData.Append($"{user.UserName},");
                }
            }

            this.LastPostData.Text = lastPostData.ToString();
        }

        private void PostButton_Click(object i_Sender, EventArgs i_)
        {
            try
            {
                Status postedStatus = m_LoggedInUser.PostStatus(PostTextBox.Text, null, null, null, null);
                PostTextBox.Text = $"Status ID {postedStatus.Id} posted!";
            }

            catch (Exception)
            {
                MessageBox.Show("Sory the post was not created");
            }
        }

        private void fillDataList<T>(FacebookObjectCollection<T> i_FacebookObject)
        {
            this.listBoxData.Items.Clear();
            foreach (T facebookObject in i_FacebookObject)
            {
                this.listBoxData.Items.Add(facebookObject);
            }

            if (this.listBoxData.Items.Count == 0)
            {
                MessageBox.Show("No data was found to retrieve");
            }
        }

        private void FriendsButton_Click(object i_Sender, EventArgs i_)
        {
            this.labelData.Text = "My Friends:";
            fillDataList(m_LoggedInUser.Friends);
        }

        private void PostsButton_Click(object i_Sender, EventArgs i_)
        {
            this.labelData.Text = "My posts:";
            fillDataList(m_LoggedInUser.Posts);
        }

        private void EventsButton_Click(object i_Sender, EventArgs i_)
        {
            this.labelData.Text = "My events:";
            fillDataList(m_LoggedInUser.Events);
        }

        private void GroupsButton_Click(object i_Sender, EventArgs i_)
        {
            this.labelData.Text = "My Groups:";
            fillDataList(m_LoggedInUser.Groups);
        }

        private void PhotosAlbumButton_Click(object i_Sender, EventArgs i_)
        {
            this.labelData.Text = "My Albums:";
            fillDataList(m_LoggedInUser.Albums);
        }

        private void PagesButton_Click(object i_Sender, EventArgs i_)
        {
            this.labelData.Text = "My liked pages:";
            fillDataList(m_LoggedInUser.LikedPages);
        }

        private void listBoxData_SelectedIndexChanged(object i_Sender, EventArgs i_)
        {
            this.SelectedData.Text = $"Name: ";
        }

        private void LostFriends_Click(object i_Sender, EventArgs i_)
        {
            Dictionary<string, string> lastDictionary = new Dictionary<string, string>();

            if (m_AppSetings.LastFriendList == null)
            {
                return;
            }

            foreach (Entry entry in m_AppSetings.LastFriendList)
            {
                lastDictionary.Add(entry.Key.ToString(), entry.Value.ToString());
            }

           Features.FriendChanges(this.LostsFriendsBox, this.GainedFriendsBox, lastDictionary, m_CurrentFriendsList);
        }

        private void LovesTheMostPicturesButton_Click(object i_Sender, EventArgs i_)
        {
            Features.TopPicturesWithMaxLikes(this.MostLikedPicturesTextBox, m_LoggedInUser.Albums);
        }

        private void PostTextBox_Leave(object i_Sender, EventArgs i_)
        {
            if (PostTextBox.Text == "")
            {
                PostTextBox.Text = "What do you want to share?";
            }
        }

        private void PostTextBox_Enter(object i_Sender, EventArgs i_)
        {
            PostTextBox.Clear();
        }

        private void SearchForAFriend_Click(object sender, EventArgs e)
        {
            this.FriendBirthdayLabel.Text = "Birthdate:";
            this.FriendEmailLabel.Text = "Email:";
            this.FriendGenderLabel.Text = "Gender:";
            this.FriendNameLabel.Text = "Name:";
            this.FriendProfilePictureBox.Image = null;

            if (m_CurrentFriendsList.ContainsValue(this.SrachFriendTextBox.Text))
            {
                foreach (User user in m_LoggedInUser.Friends)
                {
                    if (user.Name.Equals(this.SrachFriendTextBox.Text))
                    {

                        this.FriendBirthdayLabel.Text += " " + user.Birthday;
                        this.FriendEmailLabel.Text += " " + user.Email;
                        this.FriendNameLabel.Text += $" {user.FirstName} {user.LastName}";
                        this.FriendGenderLabel.Text += " " + m_LoggedInUser.Gender.ToString();
                        this.FriendProfilePictureBox.LoadAsync(user.PictureLargeURL);
                        this.FriendSearchGroupBox.Show();
                    }
                }
            }

            else
            {
                MessageBox.Show($"You have no friend named {this.SrachFriendTextBox.Text}");
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void SearchFriend_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void OvalProfilePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ProfileDataBox_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
