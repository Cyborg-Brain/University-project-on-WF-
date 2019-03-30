using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Testing.Domain.Controllers;
using Testing.Domain.Entities.Enums;
using Testing.Domain.Entities.Infrastructure;
using Testing.Domain.Entities.Infrastructure.Helpers;
using Testing.Domain.Entities.Models;
using Testing.Domain.Entities.ViewModels;
using Testing.Models;
using Testing.Views;
using Testing.Views.Forms;
using Testing.Views.Forms.PopUpWindows;
using Testing.Views.ViewModels;

namespace Testing
{
    public partial class Main : Form
    {
        private AccountController accountController;
        private ErrorProvider errorProvider;

        public Main()
        {
            accountController = new AccountController();
            accountController.ListPerson();
            InitializeComponent();
            errorProvider = new ErrorProvider();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegisterLecturer registerLecturer = new RegisterLecturer();
            registerLecturer.ShowDialog();
        }

        private void btnRegStud_Click(object sender, EventArgs e)
        {
            RegisterStudent registerStudent = new RegisterStudent();
            registerStudent.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            AuthorizeValidationModel authorizeValidation = new AuthorizeValidationModel();
            authorizeValidation.Email = textBox1.Text;
            authorizeValidation.Password = textBox2.Text;
            var validationResult = ValidationHelper.ValidateEntity(authorizeValidation);
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
                AuthPerson person = accountController.Authorize(textBox1.Text, textBox2.Text);
                if (person != null)
                {
                    var curPerson = accountController.CurrentPerson(textBox1.Text);
                    CurrentPerson.getInstance().person = curPerson;
                    switch (Enum.Parse(typeof(Status), person.StatusInt.ToString()))
                    {
                        case Status.Lecturer:
                            CurrentPerson.getInstance().person.ListSubjects = ConvertValueHelper.ConvertStringToList(curPerson.Subjects);
                            LecturerForm lecturerForm = new LecturerForm();
                            lecturerForm.ShowDialog();
                            break;
                        case Status.Student:
                            StudentForm studentForm = new StudentForm(curPerson);
                            studentForm.ShowDialog();
                            break;
                        case Status.Admin:
                            AdministratorForm administratorForm = new AdministratorForm();
                            administratorForm.Show();
                            this.Hide();
                            break;
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            SchedulePopUp schedulePopUp = new SchedulePopUp();
            schedulePopUp.ShowDialog();
        }
    }
}
