using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Testing.Domain.Controllers;
using Testing.Domain.Entities.Enums;
using Testing.Domain.Entities.Infrastructure;
using Testing.Domain.Entities.ViewModels;
using Testing.Models;
using Testing.Views.ViewModels;

namespace Testing.Views.Forms.PopUpWindows
{
    public partial class EdAddSchedule : Form
    {
        private Schedule Schedule;
        private List<Group> ListGroup;
        private List<Subject> ListSubject;
        private List<Lecturer> ListLecturer;
        private ErrorProvider errorProvider;
        private AdminController adminController;

        public Schedule NewScheduleForList { get; private set; }
        public ScheduleView NewScheduleForView { get; private set; }

        public EdAddSchedule(List<Group> ListGroup, List<Lecturer> ListLecturer, List<Subject> ListSubject, Schedule Schedule = null)
        {
            this.Schedule = Schedule;
            this.ListGroup = ListGroup;
            this.ListSubject = ListSubject;
            this.ListLecturer = ListLecturer; 
            InitializeComponent();
            errorProvider = new ErrorProvider();
            adminController = new AdminController();
        }

        private void EdAddSchedule_Load(object sender, EventArgs e)
        {
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            comboBoxDays.DataSource = Enum.GetValues(typeof(DaysEnum)).Cast<object>().ToArray();
            txtBoxGroup.AutoCompleteCustomSource.AddRange(ListGroup.Select(x => x.Name).ToArray());
            txtBoxLecturer.AutoCompleteCustomSource.AddRange(ListLecturer.Select(x => x.Name+" "+ x.Surname).ToArray());
            txtBoxSubj.AutoCompleteCustomSource.AddRange(ListSubject.Select(x => x.Name).ToArray());
            if (Schedule != null)
            {
                comboBoxDays.SelectedItem = Schedule.DaysEnum;
                numericUpDownSubj.Value = Schedule.NumSubject;
                txtBoxSubj.Text = ListSubject.Where(x => x.Id.Equals(Schedule.IdSubject)).Select(x => x.Name).FirstOrDefault();
                txtBoxGroup.Text = ListGroup.Where(x => x.Id.Equals(Schedule.IdGroup)).Select(x => x.Name).FirstOrDefault();
                txtBoxLecturer.Text = ListLecturer.Where(x => x.Id.Equals(Schedule.IdLecturer)).Select(x => (x.Name + " " + x.Surname)).FirstOrDefault();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            Subject subject = null;
            var group = ListContain((x => x.Name.Equals(txtBoxGroup.Text.ToUpper())), ListGroup, txtBoxGroup);
            if(txtBoxSubj != null) subject = ListContain((x => x.Name.Equals(txtBoxSubj.Text.Remove(1).ToUpper() + txtBoxSubj.Text.Substring(1))), ListSubject, txtBoxSubj);
            var lecturer = ListContain((x => (x.Name + " " + x.Surname).Equals(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtBoxLecturer.Text.ToLower()))), ListLecturer, txtBoxLecturer);

            if (group != null && subject != null && lecturer != null)
            {
                NewScheduleForView = new ScheduleView();
                NewScheduleForView.Day = (DaysEnum)Enum.Parse(typeof(DaysEnum), comboBoxDays.SelectedItem.ToString());
                NewScheduleForView.NumSubject = Int32.Parse(numericUpDownSubj.Value.ToString());
                NewScheduleForView.Group = group.Name;
                NewScheduleForView.Lecturer = lecturer.Name +" "+ lecturer.Surname;
                NewScheduleForView.Subject = subject.Name;

                NewScheduleForList = new Schedule();
                NewScheduleForList.DaysEnum = NewScheduleForView.Day;
                NewScheduleForList.NumSubject = NewScheduleForView.NumSubject;
                NewScheduleForList.IdGroup = group.Id;
                NewScheduleForList.IdSubject = subject.Id;
                NewScheduleForList.IdLecturer = lecturer.Id;
                EditAdd(Schedule);
            }
        }
        //METHOD FOR DETECT IF LIST CONTAIN SOME ITEM
        private TEntity ListContain<TEntity>(Func<TEntity, bool> predicate, List<TEntity>list, TextBox textBox)
        {
            var data = list.FirstOrDefault(predicate);
            if (data == null)
            {
                errorProvider.SetError(textBox, Errors.emptyErr);
            }
            return data;
        }

        private void EditAdd(Schedule Schedule)
        {
            if (Schedule == null)
            {
                var data = adminController.Create(NewScheduleForList);
                if (data != null)
                {
                    MessageBox.Show("Success creating");
                    NewScheduleForView.Id = data.Id;
                    NewScheduleForList.Id = data.Id;
                    this.Close();
                }
                else
                {
                    NewScheduleForList = null;
                    MessageBox.Show("Bad creating");
                }
            }
            else
            {
                NewScheduleForList.Id = Schedule.Id;
                Schedule = NewScheduleForList;
                var answer = adminController.Update(Schedule);
                if (answer.Equals(true))
                {
                    NewScheduleForView.Id = Schedule.Id;
                    MessageBox.Show("Success updating");
                    this.Close();
                }
                else
                {
                    NewScheduleForList = null;
                    MessageBox.Show("Bad updating");
                }
            }
        }
    }
}
