using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class MostAttractiveLogic
    {
        private User m_LoggedInUser;

        public MostAttractiveLogic(User i_LoggedInUser = null)
        {
            m_LoggedInUser = i_LoggedInUser;
        }

        public string FetchMostCommentedPicture()
        {
            int maxComments = 0;
            string msg = string.Empty;
            Photo mostCommentedPhoto = null;
            try
            {
                if (m_LoggedInUser.Albums.Count > 0)
                {
                    foreach (Album album in m_LoggedInUser.Albums)
                    {
                        foreach (Photo photo in album.Photos)
                        {
                            if (photo.Comments.Count > maxComments)
                            {
                                mostCommentedPhoto = photo;
                                maxComments = photo.Comments.Count;
                            }
                        }
                    }

                    if (maxComments > 0)
                    {
                        msg = mostCommentedPhoto.PictureNormalURL;
                    }
                }

                return msg;
            }
            catch
            {
                return "There are no permissions to access the Comment list of your Photos";
            }
        }
    }
}