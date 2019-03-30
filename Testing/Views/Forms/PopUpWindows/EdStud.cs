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
using Testing.Domain.Entities.Models;
using Testing.Models;
using Testing.Views.ViewModels;

namespace Testing.Views.Forms.PopUpWindows
{
    public partial class EdStud : Form
    {
        private Student Student { get; set; }
        public Student UpdateStudent { get; private set; }
        private List<Group> listGroup;
        private AdminController adminController;

        private AutoCompleteStringCollection autoComplete;
        private ErrorProvider errorProvider;
        private LecturerController groupController;
        private Dictionary<int, string> dictGroups;
        private ShortStudentValidationModel shortStudent;

        public EdStud(Student Student, List<Group> listGroup)
        {
            this.Student = Student;
            this.listGroup = listGroup;
            InitializeComponent();
            autoComplete = new AutoCompleteStringCollection();
            adminController = new AdminController();
            errorProvider = new ErrorProvider();
            groupController = new LecturerController();
            dictGroups = new Dictionary<int, string>();
            shortStudent = new ShortStudentValidationModel();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            shortStudent.Id = Student.Id;
            shortStudent.Name = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtBoxName.Text.ToLower());
            shortStudent.Status = Status.Student;
            shortStudent.Surname = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtBoxSurn.Text.ToLower());
            shortStudent.BirthdayDT = dateTimePicker1.Value;
            shortStudent.Sex = (SexEnum)Enum.Parse(typeof(SexEnum), comboBoxSex.SelectedItem.ToString());
            shortStudent.AverageMark = Int32.Parse(numUpDownAvMark.Value.ToString());
            shortStudent.Course = Int32.Parse(numericUpDownCourse.Value.ToString());
            shortStudent.ExamBook = Int32.Parse(numericUpDownExBook.Value.ToString());
            var validationResult = ValidationHelper.ValidateEntity(shortStudent);
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
            else if (listGroup.FirstOrDefault(x => x.Name.Equals(txtBoxGroups.Text)) == null)
            {
                errorProvider.SetError(txtBoxGroups, Errors.groupChoosedErr);
            }
            else
            {
                shortStudent.IdGroup = listGroup.First(x => x.Name.Equals(txtBoxGroups.Text.ToUpper())).Id;
                var destination = AutoMapperHelper.MapperConfiguration<ShortStudentValidationModel, Person>(shortStudent);
                var updateValue = adminController.Update(destination);
                if (updateValue == true)
                {
                    UpdateStudent = AutoMapperHelper.MapperConfiguration<Person, Student>(destination);
                    UpdateStudent.Birthday = destination.Birthday;
                    UpdateStudent.Group = txtBoxGroups.Text.ToUpper();
                    MessageBox.Show("Succes update");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Bad update(Student with this Email or ExamBook is available)");
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }

        private bool IntegerParser(NumericUpDown numUpDown)
        {
            int num;
            if (Int32.TryParse(numUpDown.Value.ToString(), out num) == true)
            {
                var test = num;
                return true;
            }
            else
            {
                errorProvider.SetError(numUpDown, Errors.intValueErr);
                return false;
            }
        }

        private void EdStud_Load(object sender, EventArgs e)
        {
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            comboBoxSex.Items.AddRange(Enum.GetValues(typeof(SexEnum)).Cast<object>().ToArray());
            autoComplete.AddRange(listGroup.Select(x => x.Name).ToArray());
            txtBoxGroups.AutoCompleteCustomSource = autoComplete;
            txtBoxName.Text = Student.Name;
            txtBoxSurn.Text = Student.Surname;
            dateTimePicker1.Value = Student.BirthdayDate;
            comboBoxSex.SelectedItem = Student.SexStud;
            numericUpDownCourse.Value = Student.Course;
            numericUpDownExBook.Value = Student.ExamBook;
            numUpDownAvMark.Value = Student.AverageMark;
            if (Student.IdGroup != 0)
            {
                txtBoxGroups.Text = listGroup.First(x => x.Id.Equals(Student.IdGroup)).Name;
            }
        }

        private void comboBoxSex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxGroups_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
