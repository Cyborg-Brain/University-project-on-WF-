using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Testing.Domain.Controllers;
using Testing.Domain.Data;
using Testing.Domain.Entities.Enums;
using Testing.Domain.Entities.Infrastructure;
using Testing.Models;
using Testing.Views.ViewModels;

namespace Testing
{
    public partial class RegisterStudent : Form
    {
        private ErrorProvider errorProvider;
        private List<Models.Group> groupList;
        private AccountController accountController;
        private Dictionary<int, string> dictGroups;
        private StudentValidationModel accountRegister;
        private AutoCompleteStringCollection autoComplete;

        public RegisterStudent()
        {
            InitializeComponent();
            errorProvider = new ErrorProvider();
            accountController = new AccountController();
            dictGroups = new Dictionary<int, string>();
            accountRegister = new StudentValidationModel();
            autoComplete = new AutoCompleteStringCollection();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            groupList = accountController.ListGroups();
            foreach (var item in groupList)
            {
                autoComplete.Add(item.Name);
                dictGroups.Add(item.Id, item.Name);
            }
            comboBoxSex.Items.Add("--Select--");
            comboBoxSex.Items.AddRange(Enum.GetValues(typeof(SexEnum)).Cast<object>().ToArray());
            comboBoxSex.SelectedIndex = 0;
            txtBoxGroups.AutoCompleteCustomSource = autoComplete;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            accountRegister.Name = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtBoxName.Text.ToLower());
            accountRegister.Status = Status.Student;
            accountRegister.Email = txtBoxEmail.Text;
            accountRegister.Surname = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtBoxSurn.Text.ToLower());
            accountRegister.Password = txtBoxPass.Text;
            accountRegister.ConfirmPassword = txtBoxConfPass.Text;
            accountRegister.BirthdayDT = dateTimePicker1.Value;
            accountRegister.Course = Int32.Parse(numericUpDownCourse.Text);
            accountRegister.ExamBook = Int32.Parse(numericUpDownExBook.Text);
            accountRegister.SexInt = comboBoxSex.SelectedIndex;
            var validationResult = ValidationHelper.ValidateEntity(accountRegister);
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
            else if (dictGroups.Values.Contains(txtBoxGroups.Text) == false)
            {
                errorProvider.SetError(txtBoxGroups, Errors.groupChoosedErr);
            }
            else
            {
                AccountController accountController = new AccountController();
                var destination = AutoMapperHelper.MapperConfiguration<StudentValidationModel, Person>(accountRegister);
                accountRegister.IdGroup = dictGroups.First(x => x.Value.Equals(txtBoxGroups.Text)).Key;
                var registerValue = accountController.Register(destination);
                if (registerValue == true)
                {

                    MessageBox.Show("Succes register");
                    return;
                }
                MessageBox.Show("Bad registered(Email or examBook is available)");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {
        }
        private void studentGroupBox_Enter(object sender, EventArgs e)
        {
        }
        private void lecturerGroupBox_Enter(object sender, EventArgs e)
        {
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }
        private void Course_TextChanged(object sender, EventArgs e)
        {
        }
        private void comboBoxSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
