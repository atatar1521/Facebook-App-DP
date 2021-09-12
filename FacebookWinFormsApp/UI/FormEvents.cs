using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System.Threading;
using BasicFacebookFeatures.Logic;

namespace BasicFacebookFeatures.UI
{
    public partial class FormEvents : Form
    {
        private User m_LoggedInUser;
        List<Event> m_EventsApproved;
        List<ListBox> m_ListOfAllListBoxs = new List<ListBox>();
        List<Event> m_GreenEvents = new List<Event>();
        List<Event> m_YellowEvents = new List<Event>();
        List<Event> m_RedEvents = new List<Event>();

        public FormEvents(List<Event> r_EventsApproved)
        {
            m_EventsApproved = r_EventsApproved;
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            displayRedListBox();
            displayYellowListBox();
            displayGreenListBox();
        }

        public void SetDataOnList()
        {
            foreach (Event item in m_EventsApproved)
            {
                if (item.AttendingCount <= 10)
                {
                    m_GreenEvents.Add(item);
                }

                if (item.AttendingCount > 10 && item.AttendingCount <= 150)
                {
                    m_YellowEvents.Add(item);
                }

                if (item.AttendingCount > 150)
                {
                    m_RedEvents.Add(item);
                }
            }

            this.ShowDialog();
        }

        private void FormEvents_Load(object sender, EventArgs e)
        {
        }

        private void FetchTrafficLightEventListBox(eColor i_Color, int i_Top, List<Event> i_TrafficLight)
        {
            int lineCounter = 0, left = 30;
            ListBox listBoxTrafficLight = ListBoxFactoryMethod.CreateListBox(i_Color);
            listBoxTrafficLight.Left = left;
            listBoxTrafficLight.Top = i_Top;
            left = listBoxTrafficLight.Right + 30;
            foreach (Event item in i_TrafficLight)
            {
                listBoxTrafficLight.Items.Add(item.Name);
            }

            m_ListOfAllListBoxs.Add(listBoxTrafficLight);
            this.Controls.Add(m_ListOfAllListBoxs[m_ListOfAllListBoxs.Count - 1]);
        }

        public void displayRedListBox()
        {
            FetchTrafficLightEventListBox(eColor.Red, 100, m_RedEvents);
            m_ListOfAllListBoxs[m_ListOfAllListBoxs.Count - 1].DataSource = eventBindingSource;
            m_ListOfAllListBoxs[m_ListOfAllListBoxs.Count - 1].DisplayMember = "Name";
            eventBindingSource.DataSource = m_RedEvents;
        }

        public void displayYellowListBox()
        {
            FetchTrafficLightEventListBox(eColor.Yellow, 180, m_YellowEvents);
            m_ListOfAllListBoxs[m_ListOfAllListBoxs.Count - 1].DataSource = eventBindingSource2;
            m_ListOfAllListBoxs[m_ListOfAllListBoxs.Count - 1].DisplayMember = "Name";
            eventBindingSource2.DataSource = m_YellowEvents;
        }

        public void displayGreenListBox()
        {
            FetchTrafficLightEventListBox(eColor.Green, 260, m_GreenEvents);
            m_ListOfAllListBoxs[m_ListOfAllListBoxs.Count - 1].DataSource = eventBindingSource3;
            m_ListOfAllListBoxs[m_ListOfAllListBoxs.Count - 1].DisplayMember = "Name";
            eventBindingSource3.DataSource = m_GreenEvents;
        }
    }
}
