using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using BasicFacebookFeatures.Logic;
using System.Windows.Forms;

namespace BasicFacebookFeatures.UI
{
    public class ListBoxRed : ListBoxToUser
    {
        public ListBoxRed()
        {
        }

        public override void SetColorsDesign()
        {
            this.BackColor = Color.Red;
        }
    }
}
