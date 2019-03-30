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
using Testing.Domain.Entities.Infrastructure;
using Testing.Domain.Entities.ViewModels;
using Testing.Models;
using Testing.Views.ViewModels;

namespace Testing.Views.Forms.PopUpWindows
{
    public partial class EdAddGroup : Form
    {
        public Group GroupForList { get; private set; }
        public GroupValidationModel GroupForView { get; private set; }
        private Group UpdGroup;
        private List<Lecturer> List;
        private ErrorProvider errorProvider;
        private AdminController adminController;
        private AutoCompleteStringCollection autoCompleteString;
        public EdAddGroup(List<Lecturer> List, Group UpdGroup = null)
        {
            this.List = List;
            this.UpdGroup = UpdGroup;
            adminController = new AdminController();
            InitializeComponent();
        }

        private void EdAddGroup_Load(object sender, EventArgs e)
        {
            errorProvider = new ErrorProvider();
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            autoCompleteString = new AutoCompleteStringCollection();
            autoCompleteString.AddRange(List.Select(x => (x.Name +" "+ x.Surname)).ToArray());
            txtBoxCurator.AutoCompleteCustomSource = autoCompleteString;
            if (UpdGroup != null)
            {
                txtBoxName.Text = UpdGroup.Name;
                txtBoxCurator.Text = List.Where(x => x.Id.Equals(UpdGroup.IdLecturer)).Select(x => x.Name + " " + x.Surname).FirstOrDefault();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            GroupForView = new GroupValidationModel();
            GroupForView.Name = txtBoxName.Text.ToUpper();
            GroupForView.NameLecturer = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtBoxCurator.Text.ToLower());
            var lecturer = ListContain((x => (x.Name+" "+x.Surname).Equals(txtBoxCurator.Text)), List, txtBoxCurator);
            var validationResult = ValidationHelper.ValidateEntity(GroupForView);
            if (lecturer == null)
            {
                errorProvider.SetError(txtBoxCurator, Errors.curatorChoosedErr);
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
            }
            else
            {
                GroupForView.IdLecturer = List.Where(x => (x.Name + " " + x.Surname).Equals(txtBoxCurator.Text)).Select(x => x.Id).FirstOrDefault();
                var destination = AutoMapperHelper.MapperConfiguration<GroupValidationModel, Group>(GroupForView);
                EditAdd(destination);
            }
        }

        private void EditAdd(Group Destination)
        {
            if (UpdGroup == null)
            {
                var data = adminController.Create(Destination);
                if (data != null)
                {
                    MessageBox.Show("Success creating");
                    GroupForList = data;
                    GroupForView.Id = data.Id;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Bad creating");
                }
            }
            else
            {
                Destination.Id = UpdGroup.Id;
                var answer = adminController.Update(Destination);
                if (answer.Equals(true))
                {
                    MessageBox.Show("Success updating");
                    GroupForList = Destination;
                    GroupForView.Id = Destination.Id;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Bad updating");
                }
            }
        }
        //METHOD FOR DETECT IF LIST CONTAIN SOME ITEM
        private TEntity ListContain<TEntity>(Func<TEntity, bool> predicate, List<TEntity> list, TextBox textBox)
        {
            var data = list.FirstOrDefault(predicate);
            if (data == null)
            {
                errorProvider.SetError(textBox, Errors.emptyErr);
            }
            return data;
        }
    }
}
