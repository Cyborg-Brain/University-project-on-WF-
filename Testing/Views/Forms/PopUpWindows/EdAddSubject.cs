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
using Testing.Domain.Entities.Infrastructure;
using Testing.Models;
using Testing.Views.ViewModels;

namespace Testing.Views.Forms.PopUpWindows
{
    public partial class EdAddSubject : Form
    {
        public Subject Subject { get; private set; }
        private Subject Subj;
        private SubjectValidationModel subjectValidation;
        private ErrorProvider errorProvider;
        private AdminController adminController;
        public EdAddSubject(Subject Subj = null)
        {
            adminController = new AdminController();
            this.Subj = Subj;
            InitializeComponent();
        }

        private void EdAddSubject_Load(object sender, EventArgs e)
        {
            errorProvider = new ErrorProvider();
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            subjectValidation = new SubjectValidationModel();
            if (Subj != null)
            {
                subjectValidation.Id = Subj.Id;
                txtBoxName.Text = Subj.Name;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            if(txtBoxName != null)subjectValidation.Name = txtBoxName.Text.Remove(1).ToUpper() + txtBoxName.Text.Substring(1);
            var validationResult = ValidationHelper.ValidateEntity(subjectValidation);
            if (!validationResult.HasError)
            {
                var destination = AutoMapperHelper.MapperConfiguration<SubjectValidationModel, Subject>(subjectValidation);
                EditAdd(destination);
            }
            else
            {
                errorProvider.SetError(txtBoxName, validationResult.Errors.Select(x => x.ErrorMessage).FirstOrDefault());
            }
        }

        private void EditAdd(Subject destination)
        {
            if (Subj == null)
            {
                Subject = adminController.Create(destination);
                if (!Subject.Equals(null))
                {
                    MessageBox.Show("Success creating");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Bad creating");
                }
            }
            else
            {
                var answer = adminController.Update(destination);
                if (answer.Equals(true))
                {
                    Subject = destination;
                    MessageBox.Show("Success updating");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Bad updating");
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
