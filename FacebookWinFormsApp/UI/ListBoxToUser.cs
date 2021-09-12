using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using BasicFacebookFeatures.Logic;
using System.Windows.Forms;
using System.Drawing;

namespace BasicFacebookFeatures.UI
{
    public class ListBoxToUser : ListBox
    {
        public User ListBoxUser
        {
            get; set;
        }

        public ListBoxToUser()
        {
            initializeComponent();
        }

        private void initializeComponent()
        {
            this.Size = new System.Drawing.Size(250, 60);
            SetColorsDesign();
        }

        public virtual void SetColorsDesign()
        {
            this.BackColor = Color.Tan;
        }
    }
}
