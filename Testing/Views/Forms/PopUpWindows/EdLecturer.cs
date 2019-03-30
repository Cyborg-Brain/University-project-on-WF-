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
using Testing.Domain.Entities.Infrastructure.Helpers;
using Testing.Domain.Entities.ViewModels;
using Testing.Models;
using Testing.Views.ViewModels;

namespace Testing.Views.Forms.PopUpWindows
{
    public partial class EdLecturer : Form
    {
        private Lecturer lecturer;
        private AdminController adminController;
        private Dictionary<int, string> dict;
        public Lecturer UpdatedLecturerForList { get; private set; }
        public Lecturer UpdatedLecturerForView { get; private set; }

        private List<Subject> list;
        private ErrorProvider errorProvider;
        private Dictionary<int, string> dictGroups;
        private ShortLecturerValidationModel shortLecturer;

        public EdLecturer(Lecturer lecturer, List<Subject> list)
        {
            this.list = list;
            this.lecturer = lecturer;
            InitializeComponent();
            adminController = new AdminController();
            errorProvider = new ErrorProvider();
            shortLecturer = new ShortLecturerValidationModel();
            comboBoxSex.Items.Add("--Select--");
            comboBoxSex.Items.AddRange(Enum.GetValues(typeof(SexEnum)).Cast<object>().ToArray());
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            shortLecturer.Id = lecturer.Id;
            shortLecturer.Name = txtBoxName.Text;
            shortLecturer.Status = Status.Lecturer;
            shortLecturer.Surname = txtBoxSurn.Text;
            shortLecturer.BirthdayDt = dateTimePicker1.Value;
            shortLecturer.SexInt = comboBoxSex.SelectedIndex;
            shortLecturer.Experience = Int32.Parse(numericUpDownExp.Value.ToString());
            foreach (var item in listBoxSubject.SelectedItems)
            {
                shortLecturer.ListSubjects.Add(list.Where(q => q.Name.Equals(item)).Select(x => x.Id).First().ToString());
            }
            shortLecturer.Subjects = ConvertValueHelper.ConvertListToStringForDB(shortLecturer.ListSubjects);
            var destination = AutoMapperHelper.MapperConfiguration<ShortLecturerValidationModel, Person>(shortLecturer);
            var validationResult = ValidationHelper.ValidateEntity(shortLecturer);
            if (validationResult.HasError)
            {
                foreach (Control x in this.Controls)
                {
                    foreach (var item in validationResult.Errors)
                    {
                        if (item.MemberNames.Where(eq => eq.Equals(x.Tag)).FirstOrDefault() != null)
                        {
                            errorProvider.SetError(x, item.ErrorMessage);
                        }
                    }
                }
            }
            else
            {
                var updateValue = adminController.Update(destination);
                if (updateValue == true)
                {
                    UpdatedLecturerForList = AutoMapperHelper.MapperConfiguration<Person, Lecturer>(destination);
                    UpdatedLecturerForList.ListSubjectsLecturer = destination.ListSubjects;
                    destination.Subjects = ConvertValueHelper.ConvertListToStringForView(listBoxSubject.SelectedItems.Cast<String>().ToList());
                    UpdatedLecturerForView = AutoMapperHelper.MapperConfiguration<Person, Lecturer>(destination);
                    MessageBox.Show("Success update");
                    this.Close();
                    return;
                }
                MessageBox.Show("Bad update");
            }
        }

        private void FillForm(Lecturer lecturer)
        {
            txtBoxName.Text = lecturer.Name;
            txtBoxSurn.Text = lecturer.Surname;
            dateTimePicker1.Value = lecturer.BirthdayDate;
            comboBoxSex.SelectedItem = lecturer.SexLect;
            numericUpDownExp.Value = lecturer.Experience;
            if (lecturer.ListSubjectsLecturer != null )
            {
                for (int i = 0; i < lecturer.ListSubjectsLecturer.Count; i++)
                {
                    listBoxSubject.SelectedItem = list
                        .Where(x => x.Id.ToString().Equals(lecturer.ListSubjectsLecturer[i]))
                        .Select(x => x.Name).First();
                }
            }
        }

        private void EdLecturer_Load(object sender, EventArgs e)
        {
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            listBoxSubject.DataSource = list.Select(x => x.Name).ToList();
            listBoxSubject.ClearSelected();
            FillForm(lecturer);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
