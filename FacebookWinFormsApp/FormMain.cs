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

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        private AppSettings m_AppSetings;
        LoginResult m_LoginResult;

        public FormMain()
        {
            InitializeComponent();
            m_AppSetings = AppSettings.LoadFromFile<AppSettings>();

            if (m_AppSetings != null)
            {
                this.RememberMeCheckBox.Checked = m_AppSetings.RememberUser;
            }

            else
            {
                m_AppSetings = new AppSettings();
            }

            FacebookService.s_CollectionLimit = 100;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (m_AppSetings.RememberUser && !string.IsNullOrEmpty(m_AppSetings.LastAccessToken))
            {
                m_LoginResult = FacebookService.Connect(m_AppSetings.LastAccessToken);
                FetchLoggedInUser();
            }

            else
            {
                m_LoginResult = FacebookService.Login(
                    "1361380624412589",
                     /// Requested permissions:
                    "public_profile",
                    "email",
                    "publish_to_groups",
                    "pages_read_engagement",
                    "pages_manage_posts",
                    "user_age_range",
                    "user_birthday",
                    "user_events",
                    "user_friends",
                    "user_gender",
                    "user_hometown",
                    "user_likes",
                    "user_link",
                    "user_location",
                    "user_photos",
                    "user_posts",
                    "user_videos");

                if (string.IsNullOrEmpty(m_LoginResult.AccessToken))
                {
                    MessageBox.Show(m_LoginResult.ErrorMessage, "Login Failed");
                }

                else
                {
                    FetchLoggedInUser();
                }
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookService.LogoutWithUI();
            buttonLogin.Text = "Login";
            buttonLogin.BackColor = buttonLogout.BackColor;
            m_LoginResult = null;
            buttonLogin.Enabled = true;
            buttonLogout.Enabled = false;
        }

        public void FetchLoggedInUser()
        {
            this.Hide();
            MainAppForm mainPage = new MainAppForm(this, m_LoginResult, this.RememberMeCheckBox.Checked, m_AppSetings);
            mainPage.Show();
        }
    }
}
