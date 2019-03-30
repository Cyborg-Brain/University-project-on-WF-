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
using Testing.Domain.Entities.Models;
using Testing.Models;

namespace Testing
{
    public partial class StudentForm : Form
    {
        private Person CurPerson;
        private StudentController studentController;
        public StudentForm(Person CurPerson)
        {
            this.CurPerson = CurPerson;
            InitializeComponent();
            studentController = new StudentController();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
           var curSchedule = studentController.Schedule(CurPerson.IdGroup);
           foreach(var item in curSchedule)
           {
                ListViewItem listViewItem = new ListViewItem(item.Day.ToString());
                listViewItem.SubItems.Add(item.NumSubject.ToString());
                listViewItem.SubItems.Add(item.Subject);
                listViewItem.SubItems.Add(item.Lecturer);
                listView1.Items.Add(listViewItem);
           }
            lblGroup.Text = curSchedule.Select(x => x.Group).First();
            lblAvMark.Text = CurPerson.AverageMark.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            CurPerson = null;
        }
    }
}
