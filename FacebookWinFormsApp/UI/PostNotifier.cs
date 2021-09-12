using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
namespace BasicFacebookFeatures.UI
{
    public class PostNotifier
    {
        public event Action<string> UpdatingReplyPostID;

        public PostNotifier()
        {
        }

        public void onUpdateReplyPostID(string i_ReplyID)
        {
            this.UpdatingReplyPostID?.Invoke(i_ReplyID);
        }
    }
}
