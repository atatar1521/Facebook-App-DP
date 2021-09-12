using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using BasicFacebookFeatures.Logic;
using System.Windows.Forms;

namespace BasicFacebookFeatures.UI
{
    public static class ListBoxFactoryMethod
    {

        public static ListBox CreateListBox(eColor i_Color)
        {
            ListBox ListBoxToReturn;

            switch (i_Color)
            {
                case eColor.Red:
                    ListBoxToReturn = new ListBoxRed();
                    break;

                case eColor.Yellow:
                    ListBoxToReturn = new ListBoxYellow();
                    break;

                case eColor.Green:
                    ListBoxToReturn = new ListBoxGreen();
                    break;

                default:
                    ListBoxToReturn = null;
                    break;
            }

            return ListBoxToReturn;
        }
    }
}