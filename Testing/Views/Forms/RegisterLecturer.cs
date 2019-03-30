using AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Testing.Domain.Controllers;
using Testing.Domain.Entities.Enums;
using Testing.Domain.Entities.Infrastructure;
using Testing.Domain.Entities.ViewModels;
using Testing.Models;
using Testing.Views.ViewModels;

namespace Testing.Views.Forms
{
    public partial class RegisterLecturer : Form
    {
        private ErrorProvider errorProvider;
        private List<Subject> listSubjects;
        private Dictionary<int, string> dictionary;
        private LecturerValidationModel accountRegister;
        private Dictionary<TypeData, string> dictFormElements;
        private AutoCompleteStringCollection autoComplete;
        private ScheduleController subjectController;

        public RegisterLecturer()
        {
            listSubjects = new List<Subject>();
            errorProvider = new ErrorProvider();
            dictionary = new Dictionary<int, string>();
            subjectController = new ScheduleController();
            autoComplete = new AutoCompleteStringCollection();
            accountRegister = new LecturerValidationModel();
            dictFormElements = new Dictionary<TypeData, string>();
            InitializeComponent();
        }

        private void RegisterLecturer_Load(object sender, EventArgs e)
        {
            listSubjects = subjectController.ListSubjects();
            comboBoxSex.Items.Add("--Select--");
            foreach (var item in listSubjects)
            {
                autoComplete.Add(item.Name);
                dictionary.Add(item.Id, item.Name);
            }
            txtBoxSubjects.AutoCompleteCustomSource = autoComplete;
            comboBoxSex.Items.AddRange(Enum.GetValues(typeof(SexEnum)).Cast<object>().ToArray());
            comboBoxSex.SelectedIndex = 0;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            accountRegister.Name = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtBoxName.Text.ToLower());
            accountRegister.Status = Status.Lecturer;
            accountRegister.Email = txtBoxEmail.Text;
            accountRegister.Surname = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtBoxSurn.Text.ToLower());
            accountRegister.ConfirmPassword = txtBoxConfPass.Text;
            accountRegister.Password = txtBoxPass.Text;
            accountRegister.BirthdayDT = dateTimePicker1.Value;
            accountRegister.Subjects = string.Join(",", accountRegister.ListSubjects);
            accountRegister.Experience = (int)numericUpDownExp.Value;
            accountRegister.SexInt = comboBoxSex.SelectedIndex;
            var destination = AutoMapperHelper.MapperConfiguration<LecturerValidationModel, Person>(accountRegister);
            var validationResult = ValidationHelper.ValidateEntity(accountRegister);
            if (DateTime.Now.Year - dateTimePicker1.Value.Year < 22)
            {
                errorProvider.SetError(dateTimePicker1, Errors.birthdayErr);
            }
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
                return;
            }
            AccountController accountController = new AccountController();
            var registerValue = accountController.Register(destination);
            if (registerValue == true)
            {
                
                MessageBox.Show("Succes register");
                return;
            }
            MessageBox.Show("Bad registered");
            accountRegister.ListSubjects.Clear();
        }

        private void txtBoxSubjects_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxSubjects != null)
            {
                var addValue = dictionary.FirstOrDefault(x => x.Value.Equals(txtBoxSubjects.Text)).Key;
                if (!accountRegister.ListSubjects.Contains(addValue.ToString()) && addValue > 0)
                {
                    accountRegister.ListSubjects.Add(addValue.ToString());
                }
            }
        }
        private void comboBoxSubj_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void comboBoxSex_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void txtBoxExp_TextChanged(object sender, EventArgs e)
        {
        }
        private void txtBoxPass_TextChanged(object sender, EventArgs e)
        {
        }
        private void txtBoxConfPass_TextChanged(object sender, EventArgs e)
        {
        }
        private void label6_Click(object sender, EventArgs e)
        {
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
