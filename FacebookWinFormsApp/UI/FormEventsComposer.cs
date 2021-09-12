using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BasicFacebookFeatures.Logic;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.UI
{
    public partial class FormEventComposer : Form
    {
        private int m_MaxAttending;
        private int m_MinAttending;
        private EventBuilder m_EventBuilder;
        private User m_LoggedInUser;
        private IDecoratedButton m_ApproveButton;
        private IDecoratedButton m_CancelButton;

        public FormEventComposer(User i_LoggedInUser)
        {
            InitializeComponent();
            dateTimePickerStart.Value = DateTime.Now;
            m_LoggedInUser = i_LoggedInUser;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            if (DialogResult == DialogResult.OK)
            {
                m_EventBuilder = new EventBuilder(m_LoggedInUser, m_MaxAttending, m_MinAttending, StartingAt);
            }
        }

        public int MaxAttending
        {
            get
            {
                return m_MaxAttending;
            }
        }

        public int MinAttending
        {
            get
            {
                return m_MinAttending;
            }
        }

        public DateTime StartingAt
        {
            get
            {
                return dateTimePickerStart.Value;
            }
        }

        private void buttonApprove_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxMaxAttending.Text))
            {
                MessageBox.Show("It is mandatory to specify the maximum number of people you agree to see at the event");
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
            else
            {
                if (!int.TryParse(textBoxMaxAttending.Text, out m_MaxAttending))
                {
                    MessageBox.Show("The maximum number of people must be an integer");
                    this.DialogResult = DialogResult.Cancel;
                    this.Close();
                }
            }

            if (string.IsNullOrEmpty(textBoxMinAttending.Text))
            {
                m_MinAttending = -1;
            }
            else
            {
                if (!int.TryParse(textBoxMinAttending.Text, out m_MinAttending))
                {
                    MessageBox.Show("The minimum number of people must be an integer");
                    this.DialogResult = DialogResult.Cancel;
                    this.Close();
                }
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancle_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void textBoxMaxAttending_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxMinAttending_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void FormEventComposer_Load(object sender, EventArgs e)
        {
            // Decorator
            m_ApproveButton = new DecoratorText(new DecoratorSetBackground(new DecoratorFont(new CoreButton(buttonApprove)), Color.GreenYellow), "approve");
            m_ApproveButton.Execute();

            // Decorator
            m_CancelButton = new DecoratorText(new DecoratorSetBackground(new DecoratorFont(new CoreButton(buttonCancle)), Color.PaleVioletRed), "cancel");
            m_CancelButton.Execute();
        }
    }
}
