using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Testing.Domain.Controllers;
using Testing.Domain.Data;
using Testing.Domain.Entities.Enums;
using Testing.Domain.Entities.Infrastructure;
using Testing.Domain.Entities.Infrastructure.Helpers;
using Testing.Domain.Entities.Models;
using Testing.Domain.Entities.ViewModels;
using Testing.Models;
using Testing.Views;
using Testing.Views.ViewModels;

namespace Testing
{
    public partial class LecturerForm : Form
    {
        private List<Student> list;
        private ErrorProvider errorProvider;
        private Dictionary<int, int> dict;
        private LecturerController lecturerController;
        private Person CurPerson;
        public LecturerForm()
        {
            errorProvider = new ErrorProvider();
            CurPerson = CurrentPerson.getInstance().person;
            lecturerController = new LecturerController();
            dict = new Dictionary<int, int>();
            InitializeComponent();
            txtBoxMark.KeyPress += txtBoxMark_KeyPress;
            txtBoxSex.KeyPress += txtBoxSex_KeyPress;
            txtBoxExperience.KeyPress += txtBoxMark_KeyPress;
            listView.DoubleClick += listView_SelectedIndexChanged;
        }

        private void txtBoxSex_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtBoxMark_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void LecturerForm_Load(object sender, EventArgs e)
        {
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            list = lecturerController.ListStudents(CurPerson.Id);
            if (list != null)
            {
                foreach (var item in list)
                {
                    ListViewItem listViewItem = new ListViewItem(item.Name);
                    listViewItem.SubItems.Add(item.Surname);
                    listViewItem.SubItems.Add(item.AverageMark.ToString());
                    listView.Items.Add(listViewItem);
                    dict.Add(listViewItem.Index, item.Id);
                }
            }
            LoadData();
        }

        private void LoadData()
        {
            txtBoxEmail.Text = CurPerson.Email;
            txtBoxName.Text = CurPerson.Name;
            txtBoxSurname.Text = CurPerson.Surname;
            dtTimePickerBirthday.Value = CurPerson.BirthdayDT;
            txtBoxSex.Text = CurPerson.Sex.ToString();
            txtBoxExperience.Text = CurPerson.Experience.ToString();
            var listSubjects = lecturerController.ListSubjects(CurPerson.ListSubjects);
            if (listSubjects != null)
            {
                listBoxSubj.DataSource = listSubjects;
            }
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            var mark = listView.FocusedItem.SubItems[2].Text;
            txtBoxMark.Text = mark;
        }

        private void btnSetMark_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            var student = list.First(x => x.Id.Equals(dict[listView.FocusedItem.Index]));
            student.AverageMark = Int32.Parse(txtBoxMark.Text);
            if (student.AverageMark < 0 || student.AverageMark > 100)
            {
                errorProvider.SetError(txtBoxMark, Errors.avMarkError);
            }
            else
            {
                var person = AutoMapperHelper.MapperConfiguration<Student, Person>(student);
                var updatePerson = lecturerController.Update(person);
                if (updatePerson == true)
                {
                    MessageBox.Show("Successfully seted mark");
                    listView.FocusedItem.SubItems[2].Text = txtBoxMark.Text;
                }
                else
                {
                    MessageBox.Show("Unsuccessfully seted mark");
                }
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            Person person = new Person();
            person.Id = CurPerson.Id;
            person.Email = txtBoxEmail.Text;
            person.Name = txtBoxName.Text;
            person.Surname = txtBoxSurname.Text;
            person.BirthdayDT = dtTimePickerBirthday.Value;
            person.Sex = (SexEnum)Enum.Parse(typeof(SexEnum),txtBoxSex.Text);
            person.Status = Domain.Entities.Enums.Status.Lecturer;
            var destination = AutoMapperHelper.MapperConfiguration<Person, LecturerValidationModelShort>(person);
            var validationResult = ValidationHelper.ValidateEntity(destination);
            if (validationResult.HasError)
            {
                foreach (var item in validationResult.Errors)
                {
                    foreach (Control x in groupBox1.Controls)
                    {
                        if (item.MemberNames.Where(eq => eq.Equals(x.Tag)).FirstOrDefault() != null)
                        {
                            errorProvider.SetError(x, item.ErrorMessage);
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
            }
            else
            {
                var answer = lecturerController.Update(person);
                if (answer)
                {
                    MessageBox.Show("Success updated");
                }
                else
                {
                    MessageBox.Show("Bad updated");
                    LoadData();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            CurPerson = null;
        }
    }
}
