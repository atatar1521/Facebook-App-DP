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
    public interface IDecoratedButton
    {
        void Execute();
    }

    public class CoreButton : IDecoratedButton
    {
        public Button m_Button;

        public CoreButton(Button i_Button)
        {
            m_Button = i_Button;
        }

        public void Execute()
        {
            m_Button.Show();
            m_Button.Visible = true;
            m_Button.Enabled = true;
        }
    }

    public class DecoratedButton : IDecoratedButton
    {
        public Button m_ButtonToDecorate;
        protected IDecoratedButton m_DecoratedFatherButton;

        public DecoratedButton(IDecoratedButton i_Button)
        {
            if (i_Button is CoreButton)
            {
                m_ButtonToDecorate = (i_Button as CoreButton).m_Button;
            }
            else
            {
                m_ButtonToDecorate = (i_Button as DecoratedButton).m_ButtonToDecorate;
            }

            m_DecoratedFatherButton = i_Button;
            m_ButtonToDecorate.Visible = true;
            m_ButtonToDecorate.Enabled = true;
        }

        public virtual void Execute()
        {
            m_DecoratedFatherButton.Execute();
        }
    }

    public class DecoratorSetBackground : DecoratedButton
    {
        private Color m_Color;

        public DecoratorSetBackground(IDecoratedButton i_DecoratedButton, Color i_Color) : base(i_DecoratedButton)
        {
            m_Color = i_Color;
        }

        public override void Execute()
        {
            m_DecoratedFatherButton.Execute();
            m_ButtonToDecorate.BackColor = m_Color;
        }
    }

    public class DecoratorFont : DecoratedButton
    {
        public DecoratorFont(IDecoratedButton i_DecoratedButton) : base(i_DecoratedButton)
        {
        }

        public override void Execute()
        {
            m_DecoratedFatherButton.Execute();
            m_ButtonToDecorate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }
    }

    public class DecoratorText : DecoratedButton
    {
        private string m_text;

        public DecoratorText(IDecoratedButton i_DecoratedButton, string i_text) : base(i_DecoratedButton)
        {
            m_text = i_text;
        }

        public override void Execute()
        {
            m_DecoratedFatherButton.Execute();
            m_ButtonToDecorate.Text = m_text;
        }
    }
}
