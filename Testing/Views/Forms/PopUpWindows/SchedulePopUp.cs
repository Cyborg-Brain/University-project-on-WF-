using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Testing.Domain.Controllers;
using Testing.Views.Helpers;

namespace Testing.Views.Forms.PopUpWindows
{
    public partial class SchedulePopUp : Form
    {
        private ScheduleController scheduleController;
        public SchedulePopUp()
        {
            scheduleController = new ScheduleController();
            InitializeComponent();
            //radioBtnAscend.Click += radioBtnAscend_Click;
        }

        private void SchedulePopUp_Load(object sender, EventArgs e)
        {
            var schedule = scheduleController.Schedule();
            foreach (var item in schedule)
            {
                ListViewItem listViewItem = new ListViewItem(item.DaysEnum.ToString());
                listViewItem.SubItems.Add(item.NumSubject.ToString());
                listViewItem.SubItems.Add(scheduleController.ListGroups().FirstOrDefault(x => x.Id.Equals(item.IdGroup)).Name);
                listViewItem.SubItems.Add(scheduleController.ListSubjects().FirstOrDefault(x => x.Id.Equals(item.IdSubject)).Name);
                listViewItem.SubItems.Add(scheduleController.ListLecturers().Where(x => x.Id.Equals(item.IdLecturer)).Select(x => x.Name + " " + x.Surname).FirstOrDefault());
                listView1.Items.Add(listViewItem);
            }
            listView1.Sort();

        }

        private void radioBtnAscend_CheckedChanged(object sender, EventArgs e)
        {
            listView1.ListViewItemSorter = new ListViewAllColumnComparer(SortOrder.Ascending);
            listView1.Sort();
        }

        private void radioBtnDescending_CheckedChanged(object sender, EventArgs e)
        {
            listView1.ListViewItemSorter = new ListViewAllColumnComparer(SortOrder.Descending);
            listView1.Sort();
        }
    }
}
