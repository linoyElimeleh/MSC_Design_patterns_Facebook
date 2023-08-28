using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System.IO;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    class Features
    {
        private static void dataToDataDictionary(Post i_Post, Dictionary<string, int> i_DataDictionaryID, Dictionary<string, string> i_DataDictionaryNames)
        {

            foreach (Comment comment in i_Post.Comments)
            {
                if (i_DataDictionaryID.ContainsKey(comment.From.Id))
                {
                    i_DataDictionaryID[comment.From.Id]++;
                }
                else
                {
                    i_DataDictionaryID.Add(comment.From.Id, 1);
                    i_DataDictionaryNames.Add(comment.From.Id, comment.From.Name);

                }
            }
        }

        private static void maxToTextBox(TextBox i_TextBox, Dictionary<string, int> i_DataDictionaryID, Dictionary<string, string> i_DataDictionaryNames)
        {
            if (i_DataDictionaryID.Count == 0)
            {
                i_TextBox.Text = "You have no friends to show..";
                return;
            }
            int maxValue = i_DataDictionaryID.Values.Max();
            foreach (string key in i_DataDictionaryID.Keys)
            {
                if (i_DataDictionaryID[key] == maxValue)
                {
                    i_TextBox.Text = i_DataDictionaryNames[key];
                    break;
                }
            }
        }

        public static void FriendChanges(ListBox i_LostFriendListBoxBox, ListBox i_GainedFriendListBox, Dictionary<string, string> i_LastFriendList, Dictionary<string, string> i_CurrentFriendList)
        {
            if (i_LastFriendList.Count == 0)
            {
                i_LostFriendListBoxBox.Items.Add("First time login, no data to show");
                i_GainedFriendListBox.Items.Add("First time login, no data to show");

                return;
            }

            int countLost = 0;
            int countGained = 0;

            foreach (string key in i_CurrentFriendList.Keys)
            {
                if (!i_LastFriendList.ContainsKey(key))
                {
                    i_GainedFriendListBox.Items.Add(i_CurrentFriendList[key]);
                    countGained++;
                }
            }

            foreach (string key in i_LastFriendList.Keys)
            {
                if (!i_CurrentFriendList.ContainsKey(key))
                {
                    i_LostFriendListBoxBox.Items.Add(i_LastFriendList[key]);
                    countLost++;
                }
            }

            if (countLost == 0)
            {
                i_LostFriendListBoxBox.Items.Add("No changes since last login");
            }
            if (countGained == 0)
            {
                i_GainedFriendListBox.Items.Add("No changes since last login");
            }

        }

        public static void TopPicturesWithMaxLikes(ListBox i_TopPicturesWithLikeBox, FacebookObjectCollection<Album> albums)
        {
            Dictionary<Photo, int> photosWithLikes = new Dictionary<Photo, int>();
            foreach (Album album in albums)
            {
                foreach (Photo photo in album.Photos)
                {
                    int totalLikes = 0;
                    foreach (User user in photo.LikedBy)
                    {
                        totalLikes++;
                    }

                    photosWithLikes.Add(photo, totalLikes);
                }
            }

            var sortedPhotos = photosWithLikes.OrderByDescending(kv => kv.Value);

            foreach (var kvp in sortedPhotos)
            {
                Photo topPhoto = kvp.Key;
                int likes = kvp.Value;
                i_TopPicturesWithLikeBox.Items.Add($"Picture: {topPhoto}, Likes: {likes}\r\n");
            }
        }
    }
}
