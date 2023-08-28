using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    partial class MainAppForm
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
            this.BithdayLabel1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.PanelSideMenu = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.EmailLabel1 = new System.Windows.Forms.Label();
            this.GenderLabel1 = new System.Windows.Forms.Label();
            this.NameLabel1 = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBoxData = new System.Windows.Forms.ListBox();
            this.labelData = new System.Windows.Forms.Label();
            this.SelectedData = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PhotosButtom = new System.Windows.Forms.Button();
            this.PagesButton = new System.Windows.Forms.Button();
            this.FriendsButton = new System.Windows.Forms.Button();
            this.PostsButton = new System.Windows.Forms.Button();
            this.EventsButton = new System.Windows.Forms.Button();
            this.GroupsButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.FriendSearchGroupBox = new System.Windows.Forms.GroupBox();
            this.FriendGenderLabel = new System.Windows.Forms.Label();
            this.FriendBirthdayLabel = new System.Windows.Forms.Label();
            this.FriendEmailLabel = new System.Windows.Forms.Label();
            this.FriendNameLabel = new System.Windows.Forms.Label();
            this.SearchFriend = new System.Windows.Forms.Label();
            this.SearchForAFriend = new System.Windows.Forms.Button();
            this.SrachFriendTextBox = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel8 = new System.Windows.Forms.Panel();
            this.MostLikedPicturesLabel = new System.Windows.Forms.Label();
            this.MostLikedPicturesTextBox = new System.Windows.Forms.ListBox();
            this.MostLikedPicturesTextBoxButton = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.LostsFriendsBox = new System.Windows.Forms.ListBox();
            this.GainedFriendsBox = new System.Windows.Forms.ListBox();
            this.FriendChangesButton = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.LastPostData = new System.Windows.Forms.Label();
            this.LastPost = new System.Windows.Forms.Label();
            this.LastPostTextBox = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.ProfileDataBox = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BithdayLabel2 = new System.Windows.Forms.Label();
            this.EmailLabel2 = new System.Windows.Forms.Label();
            this.GenderLabel2 = new System.Windows.Forms.Label();
            this.NameLabel2 = new System.Windows.Forms.Label();
            this.PostTextBox = new BasicFacebookFeatures.RoundedTextBox();
            this.OvalProfilePictureBox2 = new BasicFacebookFeatures.OvalPictureBox();
            this.OvalProfilePictureBox1 = new BasicFacebookFeatures.OvalPictureBox();
            this.FriendProfilePictureBox = new BasicFacebookFeatures.OvalPictureBox();
            this.OvalProfilePictureBox3 = new BasicFacebookFeatures.OvalPictureBox();
            this.BithdayLabel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.PanelSideMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.FriendSearchGroupBox.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.ProfileDataBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OvalProfilePictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OvalProfilePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FriendProfilePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OvalProfilePictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // BithdayLabel1
            // 
            this.BithdayLabel1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.BithdayLabel1.Controls.Add(this.tabPage2);
            this.BithdayLabel1.Controls.Add(this.tabPage1);
            this.BithdayLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.BithdayLabel1.Location = new System.Drawing.Point(0, 0);
            this.BithdayLabel1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.BithdayLabel1.Name = "BithdayLabel1";
            this.BithdayLabel1.SelectedIndex = 0;
            this.BithdayLabel1.Size = new System.Drawing.Size(1257, 548);
            this.BithdayLabel1.TabIndex = 63;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Controls.Add(this.PanelSideMenu);
            this.tabPage2.Controls.Add(this.UserName);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabPage2.Size = new System.Drawing.Size(1249, 515);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Actions";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Azure;
            this.panel4.Controls.Add(this.PostTextBox);
            this.panel4.Controls.Add(this.OvalProfilePictureBox2);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Location = new System.Drawing.Point(739, 244);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(503, 269);
            this.panel4.TabIndex = 84;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(138, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 24);
            this.label2.TabIndex = 82;
            this.label2.Text = "Let\'s Post here";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Calibri", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(28, 215);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(461, 48);
            this.button2.TabIndex = 75;
            this.button2.Text = "Post";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.PostButton_Click);
            // 
            // PanelSideMenu
            // 
            this.PanelSideMenu.BackColor = System.Drawing.Color.DarkSlateGray;
            this.PanelSideMenu.Controls.Add(this.groupBox1);
            this.PanelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelSideMenu.Location = new System.Drawing.Point(2, 1);
            this.PanelSideMenu.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.PanelSideMenu.Name = "PanelSideMenu";
            this.PanelSideMenu.Size = new System.Drawing.Size(251, 513);
            this.PanelSideMenu.TabIndex = 67;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonLogout);
            this.groupBox1.Controls.Add(this.OvalProfilePictureBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.EmailLabel1);
            this.groupBox1.Controls.Add(this.GenderLabel1);
            this.groupBox1.Controls.Add(this.NameLabel1);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(7, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(225, 509);
            this.groupBox1.TabIndex = 80;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Profile Data";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // buttonLogout
            // 
            this.buttonLogout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonLogout.Font = new System.Drawing.Font("Calibri", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.Location = new System.Drawing.Point(31, 435);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(151, 46);
            this.buttonLogout.TabIndex = 53;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 325);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 22);
            this.label3.TabIndex = 71;
            this.label3.Text = "Bithday:";
            // 
            // EmailLabel1
            // 
            this.EmailLabel1.AutoSize = true;
            this.EmailLabel1.Location = new System.Drawing.Point(8, 246);
            this.EmailLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EmailLabel1.Name = "EmailLabel1";
            this.EmailLabel1.Size = new System.Drawing.Size(55, 22);
            this.EmailLabel1.TabIndex = 69;
            this.EmailLabel1.Text = "Email:";
            // 
            // GenderLabel1
            // 
            this.GenderLabel1.AutoSize = true;
            this.GenderLabel1.Location = new System.Drawing.Point(8, 282);
            this.GenderLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GenderLabel1.Name = "GenderLabel1";
            this.GenderLabel1.Size = new System.Drawing.Size(68, 22);
            this.GenderLabel1.TabIndex = 70;
            this.GenderLabel1.Text = "Gender:";
            // 
            // NameLabel1
            // 
            this.NameLabel1.AutoSize = true;
            this.NameLabel1.Location = new System.Drawing.Point(8, 210);
            this.NameLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLabel1.Name = "NameLabel1";
            this.NameLabel1.Size = new System.Drawing.Size(59, 22);
            this.NameLabel1.TabIndex = 68;
            this.NameLabel1.Text = "Name:";
            this.NameLabel1.Click += new System.EventHandler(this.label6_Click);
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Font = new System.Drawing.Font("Calibri", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.UserName.Location = new System.Drawing.Point(724, 388);
            this.UserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(61, 24);
            this.UserName.TabIndex = 63;
            this.UserName.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listBoxData);
            this.panel1.Controls.Add(this.labelData);
            this.panel1.Controls.Add(this.SelectedData);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(257, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(478, 512);
            this.panel1.TabIndex = 79;
            // 
            // listBoxData
            // 
            this.listBoxData.Font = new System.Drawing.Font("Calibri", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxData.FormattingEnabled = true;
            this.listBoxData.ItemHeight = 19;
            this.listBoxData.Location = new System.Drawing.Point(50, 330);
            this.listBoxData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxData.Name = "listBoxData";
            this.listBoxData.Size = new System.Drawing.Size(407, 175);
            this.listBoxData.TabIndex = 77;
            this.listBoxData.SelectedIndexChanged += new System.EventHandler(this.listBoxData_SelectedIndexChanged);
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelData.Location = new System.Drawing.Point(62, 300);
            this.labelData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(48, 20);
            this.labelData.TabIndex = 79;
            this.labelData.Text = "Data:";
            // 
            // SelectedData
            // 
            this.SelectedData.AutoSize = true;
            this.SelectedData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.SelectedData.ForeColor = System.Drawing.SystemColors.Desktop;
            this.SelectedData.Location = new System.Drawing.Point(379, 300);
            this.SelectedData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SelectedData.Name = "SelectedData";
            this.SelectedData.Size = new System.Drawing.Size(64, 25);
            this.SelectedData.TabIndex = 78;
            this.SelectedData.Text = "label1";
            this.SelectedData.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.PhotosButtom);
            this.panel2.Controls.Add(this.PagesButton);
            this.panel2.Controls.Add(this.FriendsButton);
            this.panel2.Controls.Add(this.PostsButton);
            this.panel2.Controls.Add(this.EventsButton);
            this.panel2.Controls.Add(this.GroupsButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(478, 287);
            this.panel2.TabIndex = 76;
            // 
            // PhotosButtom
            // 
            this.PhotosButtom.Dock = System.Windows.Forms.DockStyle.Top;
            this.PhotosButtom.Location = new System.Drawing.Point(0, 240);
            this.PhotosButtom.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.PhotosButtom.Name = "PhotosButtom";
            this.PhotosButtom.Size = new System.Drawing.Size(478, 48);
            this.PhotosButtom.TabIndex = 6;
            this.PhotosButtom.Text = "Photos Albums";
            this.PhotosButtom.UseVisualStyleBackColor = true;
            this.PhotosButtom.Click += new System.EventHandler(this.PhotosAlbumButton_Click);
            // 
            // PagesButton
            // 
            this.PagesButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.PagesButton.Location = new System.Drawing.Point(0, 192);
            this.PagesButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.PagesButton.Name = "PagesButton";
            this.PagesButton.Size = new System.Drawing.Size(478, 48);
            this.PagesButton.TabIndex = 2;
            this.PagesButton.Text = "Pages";
            this.PagesButton.UseVisualStyleBackColor = true;
            this.PagesButton.Click += new System.EventHandler(this.PagesButton_Click);
            // 
            // FriendsButton
            // 
            this.FriendsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.FriendsButton.Location = new System.Drawing.Point(0, 144);
            this.FriendsButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.FriendsButton.Name = "FriendsButton";
            this.FriendsButton.Size = new System.Drawing.Size(478, 48);
            this.FriendsButton.TabIndex = 1;
            this.FriendsButton.Text = "Friends";
            this.FriendsButton.UseVisualStyleBackColor = true;
            this.FriendsButton.Click += new System.EventHandler(this.FriendsButton_Click);
            // 
            // PostsButton
            // 
            this.PostsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.PostsButton.Location = new System.Drawing.Point(0, 96);
            this.PostsButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.PostsButton.Name = "PostsButton";
            this.PostsButton.Size = new System.Drawing.Size(478, 48);
            this.PostsButton.TabIndex = 5;
            this.PostsButton.Text = "Posts";
            this.PostsButton.UseVisualStyleBackColor = true;
            this.PostsButton.Click += new System.EventHandler(this.PostsButton_Click);
            // 
            // EventsButton
            // 
            this.EventsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.EventsButton.Location = new System.Drawing.Point(0, 48);
            this.EventsButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.EventsButton.Name = "EventsButton";
            this.EventsButton.Size = new System.Drawing.Size(478, 48);
            this.EventsButton.TabIndex = 4;
            this.EventsButton.Text = "Events";
            this.EventsButton.UseVisualStyleBackColor = true;
            this.EventsButton.Click += new System.EventHandler(this.EventsButton_Click);
            // 
            // GroupsButton
            // 
            this.GroupsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.GroupsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GroupsButton.Location = new System.Drawing.Point(0, 0);
            this.GroupsButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.GroupsButton.Name = "GroupsButton";
            this.GroupsButton.Size = new System.Drawing.Size(478, 48);
            this.GroupsButton.TabIndex = 0;
            this.GroupsButton.Text = "Groups";
            this.GroupsButton.UseVisualStyleBackColor = true;
            this.GroupsButton.Click += new System.EventHandler(this.GroupsButton_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.FriendSearchGroupBox);
            this.panel3.Controls.Add(this.SearchFriend);
            this.panel3.Controls.Add(this.SearchForAFriend);
            this.panel3.Controls.Add(this.SrachFriendTextBox);
            this.panel3.Location = new System.Drawing.Point(739, 2);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(503, 240);
            this.panel3.TabIndex = 78;
            // 
            // FriendSearchGroupBox
            // 
            this.FriendSearchGroupBox.Controls.Add(this.FriendGenderLabel);
            this.FriendSearchGroupBox.Controls.Add(this.FriendBirthdayLabel);
            this.FriendSearchGroupBox.Controls.Add(this.FriendEmailLabel);
            this.FriendSearchGroupBox.Controls.Add(this.FriendNameLabel);
            this.FriendSearchGroupBox.Controls.Add(this.FriendProfilePictureBox);
            this.FriendSearchGroupBox.Font = new System.Drawing.Font("Calibri", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FriendSearchGroupBox.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FriendSearchGroupBox.Location = new System.Drawing.Point(36, 73);
            this.FriendSearchGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.FriendSearchGroupBox.Name = "FriendSearchGroupBox";
            this.FriendSearchGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.FriendSearchGroupBox.Size = new System.Drawing.Size(453, 145);
            this.FriendSearchGroupBox.TabIndex = 80;
            this.FriendSearchGroupBox.TabStop = false;
            this.FriendSearchGroupBox.Text = "Friend Data";
            this.FriendSearchGroupBox.Visible = false;
            // 
            // FriendGenderLabel
            // 
            this.FriendGenderLabel.AutoSize = true;
            this.FriendGenderLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FriendGenderLabel.Location = new System.Drawing.Point(251, 36);
            this.FriendGenderLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FriendGenderLabel.Name = "FriendGenderLabel";
            this.FriendGenderLabel.Size = new System.Drawing.Size(66, 21);
            this.FriendGenderLabel.TabIndex = 3;
            this.FriendGenderLabel.Text = "Gender:";
            // 
            // FriendBirthdayLabel
            // 
            this.FriendBirthdayLabel.AutoSize = true;
            this.FriendBirthdayLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FriendBirthdayLabel.Location = new System.Drawing.Point(251, 72);
            this.FriendBirthdayLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FriendBirthdayLabel.Name = "FriendBirthdayLabel";
            this.FriendBirthdayLabel.Size = new System.Drawing.Size(80, 21);
            this.FriendBirthdayLabel.TabIndex = 4;
            this.FriendBirthdayLabel.Text = "Birthdate:";
            // 
            // FriendEmailLabel
            // 
            this.FriendEmailLabel.AutoSize = true;
            this.FriendEmailLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FriendEmailLabel.Location = new System.Drawing.Point(95, 72);
            this.FriendEmailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FriendEmailLabel.Name = "FriendEmailLabel";
            this.FriendEmailLabel.Size = new System.Drawing.Size(53, 21);
            this.FriendEmailLabel.TabIndex = 2;
            this.FriendEmailLabel.Text = "Email:";
            // 
            // FriendNameLabel
            // 
            this.FriendNameLabel.AutoSize = true;
            this.FriendNameLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FriendNameLabel.Location = new System.Drawing.Point(92, 36);
            this.FriendNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FriendNameLabel.Name = "FriendNameLabel";
            this.FriendNameLabel.Size = new System.Drawing.Size(56, 21);
            this.FriendNameLabel.TabIndex = 1;
            this.FriendNameLabel.Text = "Name:";
            // 
            // SearchFriend
            // 
            this.SearchFriend.AutoSize = true;
            this.SearchFriend.BackColor = System.Drawing.Color.CadetBlue;
            this.SearchFriend.Font = new System.Drawing.Font("Calibri", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchFriend.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SearchFriend.Location = new System.Drawing.Point(32, 25);
            this.SearchFriend.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SearchFriend.Name = "SearchFriend";
            this.SearchFriend.Size = new System.Drawing.Size(125, 24);
            this.SearchFriend.TabIndex = 77;
            this.SearchFriend.Text = "Search friend:";
            // 
            // SearchForAFriend
            // 
            this.SearchForAFriend.Font = new System.Drawing.Font("Calibri", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchForAFriend.Location = new System.Drawing.Point(394, 17);
            this.SearchForAFriend.Margin = new System.Windows.Forms.Padding(2);
            this.SearchForAFriend.Name = "SearchForAFriend";
            this.SearchForAFriend.Size = new System.Drawing.Size(95, 41);
            this.SearchForAFriend.TabIndex = 79;
            this.SearchForAFriend.Text = "Search";
            this.SearchForAFriend.UseVisualStyleBackColor = true;
            this.SearchForAFriend.Click += new System.EventHandler(this.SearchForAFriend_Click);
            // 
            // SrachFriendTextBox
            // 
            this.SrachFriendTextBox.Font = new System.Drawing.Font("Calibri", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SrachFriendTextBox.Location = new System.Drawing.Point(161, 22);
            this.SrachFriendTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.SrachFriendTextBox.Name = "SrachFriendTextBox";
            this.SrachFriendTextBox.Size = new System.Drawing.Size(229, 32);
            this.SrachFriendTextBox.TabIndex = 78;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.panel8);
            this.tabPage1.Controls.Add(this.panel7);
            this.tabPage1.Controls.Add(this.panel6);
            this.tabPage1.Controls.Add(this.panel5);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabPage1.Size = new System.Drawing.Size(1249, 515);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "My Data";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel8.Controls.Add(this.MostLikedPicturesLabel);
            this.panel8.Controls.Add(this.MostLikedPicturesTextBox);
            this.panel8.Controls.Add(this.MostLikedPicturesTextBoxButton);
            this.panel8.Location = new System.Drawing.Point(725, 244);
            this.panel8.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(517, 269);
            this.panel8.TabIndex = 89;
            // 
            // MostLikedPicturesLabel
            // 
            this.MostLikedPicturesLabel.AutoSize = true;
            this.MostLikedPicturesLabel.Font = new System.Drawing.Font("Calibri", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MostLikedPicturesLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.MostLikedPicturesLabel.Location = new System.Drawing.Point(13, 20);
            this.MostLikedPicturesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MostLikedPicturesLabel.Name = "MostLikedPicturesLabel";
            this.MostLikedPicturesLabel.Size = new System.Drawing.Size(174, 21);
            this.MostLikedPicturesLabel.TabIndex = 88;
            this.MostLikedPicturesLabel.Text = "Pictures liked the most:";
            // 
            // MostLikedPicturesTextBox
            // 
            this.MostLikedPicturesTextBox.Font = new System.Drawing.Font("Calibri", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MostLikedPicturesTextBox.ItemHeight = 19;
            this.MostLikedPicturesTextBox.Location = new System.Drawing.Point(17, 50);
            this.MostLikedPicturesTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MostLikedPicturesTextBox.Name = "MostLikedPicturesTextBox";
            this.MostLikedPicturesTextBox.Size = new System.Drawing.Size(463, 137);
            this.MostLikedPicturesTextBox.TabIndex = 83;
            // 
            // MostLikedPicturesTextBoxButton
            // 
            this.MostLikedPicturesTextBoxButton.Font = new System.Drawing.Font("Calibri", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MostLikedPicturesTextBoxButton.Location = new System.Drawing.Point(70, 197);
            this.MostLikedPicturesTextBoxButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MostLikedPicturesTextBoxButton.Name = "MostLikedPicturesTextBoxButton";
            this.MostLikedPicturesTextBoxButton.Size = new System.Drawing.Size(369, 35);
            this.MostLikedPicturesTextBoxButton.TabIndex = 87;
            this.MostLikedPicturesTextBoxButton.Text = "Most Liked Pictures:";
            this.MostLikedPicturesTextBoxButton.UseVisualStyleBackColor = true;
            this.MostLikedPicturesTextBoxButton.Click += new System.EventHandler(this.LovesTheMostPicturesButton_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel7.Controls.Add(this.label1);
            this.panel7.Controls.Add(this.LostsFriendsBox);
            this.panel7.Controls.Add(this.GainedFriendsBox);
            this.panel7.Controls.Add(this.FriendChangesButton);
            this.panel7.Location = new System.Drawing.Point(725, 2);
            this.panel7.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(517, 240);
            this.panel7.TabIndex = 88;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 21);
            this.label1.TabIndex = 89;
            this.label1.Text = "The changes in your friends";
            // 
            // LostsFriendsBox
            // 
            this.LostsFriendsBox.AccessibleDescription = "Losts Friends";
            this.LostsFriendsBox.AccessibleName = "Losts Friends";
            this.LostsFriendsBox.Font = new System.Drawing.Font("Calibri", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LostsFriendsBox.FormattingEnabled = true;
            this.LostsFriendsBox.ItemHeight = 19;
            this.LostsFriendsBox.Location = new System.Drawing.Point(22, 45);
            this.LostsFriendsBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LostsFriendsBox.Name = "LostsFriendsBox";
            this.LostsFriendsBox.Size = new System.Drawing.Size(223, 118);
            this.LostsFriendsBox.TabIndex = 86;
            // 
            // GainedFriendsBox
            // 
            this.GainedFriendsBox.AccessibleDescription = "Gained Friends";
            this.GainedFriendsBox.AccessibleName = "Gained Friends";
            this.GainedFriendsBox.Font = new System.Drawing.Font("Calibri", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GainedFriendsBox.FormattingEnabled = true;
            this.GainedFriendsBox.ItemHeight = 19;
            this.GainedFriendsBox.Location = new System.Drawing.Point(262, 45);
            this.GainedFriendsBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GainedFriendsBox.Name = "GainedFriendsBox";
            this.GainedFriendsBox.Size = new System.Drawing.Size(223, 118);
            this.GainedFriendsBox.TabIndex = 85;
            // 
            // FriendChangesButton
            // 
            this.FriendChangesButton.Font = new System.Drawing.Font("Calibri", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FriendChangesButton.Location = new System.Drawing.Point(75, 190);
            this.FriendChangesButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FriendChangesButton.Name = "FriendChangesButton";
            this.FriendChangesButton.Size = new System.Drawing.Size(369, 35);
            this.FriendChangesButton.TabIndex = 84;
            this.FriendChangesButton.Text = "Friend Changes";
            this.FriendChangesButton.UseVisualStyleBackColor = true;
            this.FriendChangesButton.Click += new System.EventHandler(this.LostFriends_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel6.Controls.Add(this.LastPostData);
            this.panel6.Controls.Add(this.LastPost);
            this.panel6.Controls.Add(this.LastPostTextBox);
            this.panel6.Location = new System.Drawing.Point(243, 2);
            this.panel6.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(478, 512);
            this.panel6.TabIndex = 87;
            // 
            // LastPostData
            // 
            this.LastPostData.AutoSize = true;
            this.LastPostData.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastPostData.ForeColor = System.Drawing.SystemColors.Desktop;
            this.LastPostData.Location = new System.Drawing.Point(285, 45);
            this.LastPostData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LastPostData.Name = "LastPostData";
            this.LastPostData.Size = new System.Drawing.Size(107, 22);
            this.LastPostData.TabIndex = 89;
            this.LastPostData.Text = "LastPostData";
            // 
            // LastPost
            // 
            this.LastPost.AutoSize = true;
            this.LastPost.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastPost.ForeColor = System.Drawing.SystemColors.Desktop;
            this.LastPost.Location = new System.Drawing.Point(17, 15);
            this.LastPost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LastPost.Name = "LastPost";
            this.LastPost.Size = new System.Drawing.Size(108, 22);
            this.LastPost.TabIndex = 88;
            this.LastPost.Text = "My Last Post:";
            // 
            // LastPostTextBox
            // 
            this.LastPostTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.LastPostTextBox.Font = new System.Drawing.Font("Calibri", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastPostTextBox.ForeColor = System.Drawing.SystemColors.Desktop;
            this.LastPostTextBox.Location = new System.Drawing.Point(15, 45);
            this.LastPostTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LastPostTextBox.Multiline = true;
            this.LastPostTextBox.Name = "LastPostTextBox";
            this.LastPostTextBox.ReadOnly = true;
            this.LastPostTextBox.Size = new System.Drawing.Size(262, 449);
            this.LastPostTextBox.TabIndex = 87;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel5.Controls.Add(this.ProfileDataBox);
            this.panel5.Location = new System.Drawing.Point(2, 2);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(237, 517);
            this.panel5.TabIndex = 83;
            // 
            // ProfileDataBox
            // 
            this.ProfileDataBox.Controls.Add(this.button1);
            this.ProfileDataBox.Controls.Add(this.BithdayLabel2);
            this.ProfileDataBox.Controls.Add(this.OvalProfilePictureBox3);
            this.ProfileDataBox.Controls.Add(this.EmailLabel2);
            this.ProfileDataBox.Controls.Add(this.GenderLabel2);
            this.ProfileDataBox.Controls.Add(this.NameLabel2);
            this.ProfileDataBox.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfileDataBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ProfileDataBox.Location = new System.Drawing.Point(7, 3);
            this.ProfileDataBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProfileDataBox.Name = "ProfileDataBox";
            this.ProfileDataBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProfileDataBox.Size = new System.Drawing.Size(229, 509);
            this.ProfileDataBox.TabIndex = 78;
            this.ProfileDataBox.TabStop = false;
            this.ProfileDataBox.Text = "Profile Data";
            this.ProfileDataBox.Enter += new System.EventHandler(this.ProfileDataBox_Enter);
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Font = new System.Drawing.Font("Calibri", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(31, 430);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 46);
            this.button1.TabIndex = 72;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // BithdayLabel2
            // 
            this.BithdayLabel2.AutoSize = true;
            this.BithdayLabel2.Location = new System.Drawing.Point(8, 319);
            this.BithdayLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BithdayLabel2.Name = "BithdayLabel2";
            this.BithdayLabel2.Size = new System.Drawing.Size(70, 22);
            this.BithdayLabel2.TabIndex = 71;
            this.BithdayLabel2.Text = "Bithday:";
            // 
            // EmailLabel2
            // 
            this.EmailLabel2.AutoSize = true;
            this.EmailLabel2.Location = new System.Drawing.Point(8, 246);
            this.EmailLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EmailLabel2.Name = "EmailLabel2";
            this.EmailLabel2.Size = new System.Drawing.Size(55, 22);
            this.EmailLabel2.TabIndex = 69;
            this.EmailLabel2.Text = "Email:";
            // 
            // GenderLabel2
            // 
            this.GenderLabel2.AutoSize = true;
            this.GenderLabel2.Location = new System.Drawing.Point(8, 282);
            this.GenderLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GenderLabel2.Name = "GenderLabel2";
            this.GenderLabel2.Size = new System.Drawing.Size(68, 22);
            this.GenderLabel2.TabIndex = 70;
            this.GenderLabel2.Text = "Gender:";
            // 
            // NameLabel2
            // 
            this.NameLabel2.AutoSize = true;
            this.NameLabel2.Location = new System.Drawing.Point(8, 210);
            this.NameLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLabel2.Name = "NameLabel2";
            this.NameLabel2.Size = new System.Drawing.Size(59, 22);
            this.NameLabel2.TabIndex = 68;
            this.NameLabel2.Text = "Name:";
            // 
            // PostTextBox
            // 
            this.PostTextBox.BackColor = System.Drawing.Color.LightGray;
            this.PostTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostTextBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.PostTextBox.Location = new System.Drawing.Point(28, 98);
            this.PostTextBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.PostTextBox.Multiline = true;
            this.PostTextBox.Name = "PostTextBox";
            this.PostTextBox.Size = new System.Drawing.Size(461, 102);
            this.PostTextBox.TabIndex = 84;
            this.PostTextBox.Text = "What\'s on your mind?";
            this.PostTextBox.Enter += new System.EventHandler(this.PostTextBox_Enter);
            this.PostTextBox.Leave += new System.EventHandler(this.PostTextBox_Leave);
            // 
            // OvalProfilePictureBox2
            // 
            this.OvalProfilePictureBox2.BackColor = System.Drawing.Color.White;
            this.OvalProfilePictureBox2.Location = new System.Drawing.Point(28, 1);
            this.OvalProfilePictureBox2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.OvalProfilePictureBox2.Name = "OvalProfilePictureBox2";
            this.OvalProfilePictureBox2.Size = new System.Drawing.Size(83, 96);
            this.OvalProfilePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.OvalProfilePictureBox2.TabIndex = 83;
            this.OvalProfilePictureBox2.TabStop = false;
            // 
            // OvalProfilePictureBox1
            // 
            this.OvalProfilePictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.OvalProfilePictureBox1.Location = new System.Drawing.Point(12, 24);
            this.OvalProfilePictureBox1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.OvalProfilePictureBox1.Name = "OvalProfilePictureBox1";
            this.OvalProfilePictureBox1.Size = new System.Drawing.Size(193, 164);
            this.OvalProfilePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.OvalProfilePictureBox1.TabIndex = 66;
            this.OvalProfilePictureBox1.TabStop = false;
            // 
            // FriendProfilePictureBox
            // 
            this.FriendProfilePictureBox.BackColor = System.Drawing.Color.White;
            this.FriendProfilePictureBox.Location = new System.Drawing.Point(4, 36);
            this.FriendProfilePictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.FriendProfilePictureBox.Name = "FriendProfilePictureBox";
            this.FriendProfilePictureBox.Size = new System.Drawing.Size(84, 96);
            this.FriendProfilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FriendProfilePictureBox.TabIndex = 0;
            this.FriendProfilePictureBox.TabStop = false;
            // 
            // OvalProfilePictureBox3
            // 
            this.OvalProfilePictureBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.OvalProfilePictureBox3.Location = new System.Drawing.Point(12, 28);
            this.OvalProfilePictureBox3.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.OvalProfilePictureBox3.Name = "OvalProfilePictureBox3";
            this.OvalProfilePictureBox3.Size = new System.Drawing.Size(193, 164);
            this.OvalProfilePictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.OvalProfilePictureBox3.TabIndex = 67;
            this.OvalProfilePictureBox3.TabStop = false;
            // 
            // MainAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 569);
            this.Controls.Add(this.BithdayLabel1);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "MainAppForm";
            this.Text = "MainPage";
            this.BithdayLabel1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.PanelSideMenu.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.FriendSearchGroupBox.ResumeLayout(false);
            this.FriendSearchGroupBox.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ProfileDataBox.ResumeLayout(false);
            this.ProfileDataBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OvalProfilePictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OvalProfilePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FriendProfilePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OvalProfilePictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl BithdayLabel1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBoxData;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button PhotosButtom;
        private System.Windows.Forms.Button PagesButton;
        private System.Windows.Forms.Button FriendsButton;
        private System.Windows.Forms.Button PostsButton;
        private System.Windows.Forms.Button EventsButton;
        private System.Windows.Forms.Button GroupsButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label SearchFriend;
        private System.Windows.Forms.GroupBox FriendSearchGroupBox;
        private System.Windows.Forms.Label FriendGenderLabel;
        private System.Windows.Forms.Label FriendBirthdayLabel;
        private System.Windows.Forms.Label FriendEmailLabel;
        private System.Windows.Forms.Label FriendNameLabel;
        private OvalPictureBox FriendProfilePictureBox;
        private System.Windows.Forms.Button SearchForAFriend;
        private System.Windows.Forms.TextBox SrachFriendTextBox;
        private System.Windows.Forms.Panel PanelSideMenu;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Label SelectedData;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private OvalPictureBox OvalProfilePictureBox2;
        private RoundedTextBox PostTextBox;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.GroupBox ProfileDataBox;
        private System.Windows.Forms.Label BithdayLabel2;
        private OvalPictureBox OvalProfilePictureBox3;
        private System.Windows.Forms.Label EmailLabel2;
        private System.Windows.Forms.Label GenderLabel2;
        private System.Windows.Forms.Label NameLabel2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox LostsFriendsBox;
        private System.Windows.Forms.ListBox GainedFriendsBox;
        private System.Windows.Forms.Button FriendChangesButton;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label LastPostData;
        private System.Windows.Forms.Label LastPost;
        private System.Windows.Forms.TextBox LastPostTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private OvalPictureBox OvalProfilePictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label EmailLabel1;
        private System.Windows.Forms.Label GenderLabel1;
        private System.Windows.Forms.Label NameLabel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label MostLikedPicturesLabel;
        private System.Windows.Forms.ListBox MostLikedPicturesTextBox;
        private System.Windows.Forms.Button MostLikedPicturesTextBoxButton;
    }
}
