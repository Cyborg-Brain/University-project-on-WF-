using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Testing.Domain.Controllers;
using Testing.Domain.Entities.Enums;
using Testing.Domain.Entities.Infrastructure;
using Testing.Domain.Entities.Infrastructure.Helpers;
using Testing.Domain.Entities.Models;
using Testing.Domain.Entities.ViewModels;
using Testing.Domain.Repository.Interface;
using Testing.Models;
using Testing.Views.Forms;
using Testing.Views.Forms.PopUpWindows;
using Testing.Views.ViewModels;

namespace Testing
{
    public partial class AdministratorForm : Form, ISubjectRepository, IStudentRepository
    {
        private Person person;
        private AdminController adminController;
        private EdStud edStud;
        private EdLecturer edLect;

        //FIELDS LISTS
        private List<int> listExBook; 
        private List<Group> listGroups;
        private List<Subject> listSubjects;
        private List<Student> listStudents;
        private List<Schedule> listSchedule;
        private List<Lecturer> listLecturers;

        //FIELDS AUTOCOMPLETE
        private AutoCompleteStringCollection autoCompleteGroups;
        private AutoCompleteStringCollection autoCompleteCurators;
        private AutoCompleteStringCollection autoCompleteDays;

        private ModalWindow modalWindow;

        //DICTIONARIES
        private Dictionary<string, int> dict;
        //private Dictionary<int, int> dictRowNoPerson;
        private Dictionary<int, int> dictRowPerson;
        private Dictionary<int, string> dictCurators;
        private Dictionary<int, int> dictStudents;
        private Dictionary<int, string> dictGroups;
        private Dictionary<int, string> dictSubjects;

        public AdministratorForm()
        {
            person = new Person();
            adminController = new AdminController();
            listExBook = new List<int>();
            //DICTIONARIES
            dict = new Dictionary<string, int>();
            //dictRowNoPerson = new Dictionary<int, int>();
            dictRowPerson = new Dictionary<int, int>();
            dictCurators = new Dictionary<int, string>();
            dictSubjects = new Dictionary<int, string>();
            dictStudents = new Dictionary<int, int>();
            dictGroups = new Dictionary<int, string>();
            //AUTO COMPLETE
            autoCompleteDays = new AutoCompleteStringCollection();
            autoCompleteCurators = new AutoCompleteStringCollection();
            autoCompleteGroups = new AutoCompleteStringCollection();
            InitializeComponent();
        }

        private void AdministratorForm_Load(object sender, EventArgs e)
        {
            modalWindow = new ModalWindow();
             
            listGroups = adminController.ListGroups();
            listStudents = adminController.ListStudents();
            listLecturers = adminController.ListLecturers();
            listSubjects = adminController.ListSubjects();
            listSchedule = adminController.ListSchedule();
            LoadData();
            this.dataGridViewGroups.ClearSelection();
            this.dataGridViewStudents.ClearSelection();
            this.dataGridViewSchedule.ClearSelection();
            this.dataGridViewSubjects.ClearSelection();
            this.dataGridViewLecturers.ClearSelection();
        }

        //SEARCH BTN
        private void buttonStudSearch_Click(object sender, EventArgs e) => SearchData(tabPageStudents, cbBoxSearchStudent, txtBoxStudSearch.Text);
        private void btnLectSearch_Click(object sender, EventArgs e) => SearchData(tabPageLecturers, cbBoxSearchLecturer, txtBoxLectSearch.Text);
        private void button11_Click(object sender, EventArgs e) => SearchData(tabPageSubjGr, cbBoxSearchSubjGr, txtBoxSearchSubjGr.Text);
        private void btnSearchSchedule_Click(object sender, EventArgs e) => SearchData(tabPageSchedule, cbBoxSearchSchedule, txtBoxSearchSchedule.Text);
        //CLEAR BTN
        private void btnClearStud_Click(object sender, EventArgs e)
        {
            dataGridViewStudents.ClearSelection();
            txtBoxStudSearch.Clear();
        }

        private void btnClearLect_Click(object sender, EventArgs e)
        {
            dataGridViewLecturers.ClearSelection();
            txtBoxLectSearch.Clear();
        }

        private void btnClSearchSubjGrFld_Click(object sender, EventArgs e)
        {
            dataGridViewSubjects.ClearSelection();
            dataGridViewGroups.ClearSelection();
            txtBoxSearchSubjGr.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridViewSchedule.ClearSelection();
            txtBoxSearchSchedule.Clear();
        }

        //ADD BUTTONS
        private void btnAddGr_Click(object sender, EventArgs e)
        {
            EdAddGroup edAddGroup = new EdAddGroup(listLecturers);
            edAddGroup.ShowDialog();
            var addedGroup = edAddGroup.GroupForList;
            if (addedGroup != null)
            {
                dataGridViewGroups.Rows.Add(edAddGroup.GroupForView.Id, edAddGroup.GroupForView.Name, edAddGroup.GroupForView.NameLecturer);
                listGroups.Add(addedGroup);
            }
        }

        private void btnAddSubj_Click(object sender, EventArgs e)
        {
            EdAddSubject edAddSubj = new EdAddSubject();
            edAddSubj.ShowDialog();
            var addedSubj = edAddSubj.Subject;
            if (addedSubj != null)
            {
                dataGridViewSubjects.Rows.Add(addedSubj.Id, addedSubj.Name);
                listSubjects.Add(addedSubj);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listGroups != null && listLecturers != null && listSubjects != null)
            {
                EdAddSchedule edAddSchedule = new EdAddSchedule(
                    listGroups.Select(x => new Group()
                    {
                        Id = x.Id,
                        Name = x.Name
                    }).ToList(),
                    listLecturers.Select(x => new Lecturer()
                    {
                        Id = x.Id,
                        Name = x.Name,
                        Surname = x.Surname,
                        Subjects = x.Subjects
                    }).ToList(),
                    listSubjects);
                edAddSchedule.ShowDialog();
                var dataForList = edAddSchedule.NewScheduleForList;
                var dataForView = edAddSchedule.NewScheduleForView;
                if (dataForList != null)
                {
                    dataGridViewSchedule.Rows.Add(dataForView.Id, dataForView.Day, dataForView.NumSubject, dataForView.Subject, dataForView.Group, dataForView.Lecturer);
                    listSchedule.Add(dataForList);
                }
            }
            else
            {
                MessageBox.Show("Subjects or Lecturers or Groups is empty!");
            }
        }

        //UPDATE BUTTONS
        private void btnEdStud_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            if (dataGridViewStudents.SelectedRows.Count == 1)
            {
                var currentIdObject = dataGridViewStudents.CurrentRow.Cells[0].Value;
                var currentStudent = listStudents.First(x => x.Id.Equals(currentIdObject));
                edStud = new EdStud(currentStudent, listGroups.Select(x => new Group()
                {
                    Id = x.Id,
                    Name = x.Name
                }).ToList());
                edStud.ShowDialog();
                if (edStud.UpdateStudent != null)
                {
                    var data = edStud.UpdateStudent;
                    ConvClassDataToRow(dataGridViewStudents, data);
                    listStudents[listStudents.FindIndex(x => x.Id.Equals(data.Id))] = data;
                }
                return;
            }
            else
            {
                MessageBox.Show("Choose only one row!");
            }
        }

        private void btnEdLect_Click(object sender, EventArgs e)
        {
            if (dataGridViewLecturers.SelectedRows.Count == 1)
            {
                var currentRow = dataGridViewLecturers.CurrentRow.Cells[0].Value;
                var currentLecturer = listLecturers.First(x => x.Id.Equals(currentRow));
                edLect = new EdLecturer(currentLecturer, listSubjects);
                edLect.ShowDialog();
                if (edLect.UpdatedLecturerForView != null)
                {
                    var data = edLect.UpdatedLecturerForView;
                    ConvClassDataToRow(dataGridViewLecturers, data);
                    listLecturers[listLecturers.IndexOf(currentLecturer)] = edLect.UpdatedLecturerForList;
                    var groupContains = listGroups
                        .Where(x => x.IdLecturer.Equals(data.Id)).ToList();
                    var scheduleContains = listSchedule
                        .Where(x => x.IdLecturer.Equals(data.Id)).ToList();
                    //Edit lecturer in schedule
                    if (scheduleContains != null)
                    {
                        for (int i = 0; i < scheduleContains.Count; i++)
                        {
                            var cells = dataGridViewSchedule.Rows.Cast<DataGridViewRow>()
                                .Where(x => x.Cells.GetCellFromColumnHeader("Id").Value.Equals(scheduleContains[i].Id))
                                .Select(x => x.Cells.GetCellFromColumnHeader("Lecturer")).ToList();
                            foreach (var itm in cells)
                            {
                                if (itm.ToString() != (data.Name + " " + data.Surname))
                                {
                                    itm.Selected = true;
                                    itm.Value = data.Name + " " + data.Surname;
                                    itm.Selected = false;
                                }
                            }
                        }
                    }
                    //Edit lecturer in group 
                    if (groupContains != null)
                    {
                        for (int i = 0; i < groupContains.Count; i++)
                        {
                           var cell = dataGridViewGroups.Rows.Cast<DataGridViewRow>()
                               .Where(x => x.Cells.GetCellFromColumnHeader("Id").Value.Equals(groupContains[i].Id))
                               .Select(x => x.Cells.GetCellFromColumnHeader("Curator")).First();
                            if (cell.ToString() != (data.Name + " " + data.Surname))
                            {
                                cell.Selected = true;
                                cell.Value = data.Name + " " + data.Surname;
                                cell.Selected = false;
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Choose only one row!");
            }
        }

        private void btnEdSubjGroup_Click(object sender, EventArgs e)
        {
            if (!(dataGridViewSubjects.SelectedRows.Count + dataGridViewGroups.SelectedRows.Count > 1))
            {
                if (dataGridViewSubjects.SelectedRows.Count == 1)
                {
                    var currentSubjId = dataGridViewSubjects.CurrentRow.Cells[0].Value;
                    var currentSubj = listSubjects.First(x => x.Id.Equals(currentSubjId));
                    EdAddSubject edAddSubject = new EdAddSubject(currentSubj);
                    edAddSubject.ShowDialog();
                    if (edAddSubject.Subject != null)
                    {
                        var data = edAddSubject.Subject;
                        ConvClassDataToRow(dataGridViewSubjects, data);
                        listSubjects[listSubjects.IndexOf(currentSubj)] = data;
                        var lectContains = listLecturers.Where(x => x.ListSubjectsLecturer.Contains(data.Id.ToString())).ToList();
                        var scheduleContains = listSchedule.Where(x => x.IdSubject.Equals(data.Id)).ToList();
                        //Udpate subject in scheduleDataGridView 
                        if (scheduleContains != null)
                        {
                            for (int i = 0; i < scheduleContains.Count; i++)
                            {
                                var cells = dataGridViewSchedule.Rows.Cast<DataGridViewRow>()
                                    .Where(x => x.Cells.GetCellFromColumnHeader("Id").Value.Equals(scheduleContains[i].Id))
                                    .Select(x => x.Cells.GetCellFromColumnHeader("Subject")).ToList();
                                foreach (var itm in cells)
                                {
                                    if (itm.Value.ToString().Contains(currentSubj.Name))
                                    {
                                        itm.Selected = true;
                                        itm.Value = data.Name;
                                        itm.Selected = false;
                                    }
                                }
                            }
                        }
                        //Update subject in lecturerDataGridView
                        if (lectContains != null)
                        {
                            for (int i = 0; i < lectContains.Count; i++)
                            {
                                var cell = dataGridViewLecturers.Rows.Cast<DataGridViewRow>()
                                          .Where(x => x.Cells.GetCellFromColumnHeader("Id").Value.Equals(lectContains[i].Id))
                                          .Select(q => q.Cells.GetCellFromColumnHeader("Subjects")).First();
                                List<string> list = new List<string>();
                                list = ConvertValueHelper.ConvertStringViewToList(cell.Value.ToString());
                                list[list.IndexOf(currentSubj.Name)] = data.Name;
                                cell.Selected = true;
                                cell.Value = ConvertValueHelper.ConvertListToStringForView(list);
                                cell.Selected = false;
                            }
                        }
                    }
                }
                if (dataGridViewGroups.SelectedRows.Count == 1)
                {
                    var currentGroupId = dataGridViewGroups.CurrentRow.Cells[0].Value;
                    var currentGroup = listGroups.First(x => x.Id.Equals(currentGroupId));
                    EdAddGroup edAddGroup = new EdAddGroup(listLecturers
                        .Select(q => new Lecturer()
                        {
                            Id = q.Id,
                            Name = q.Name,
                            Surname = q.Surname
                        }).ToList(), currentGroup);
                    edAddGroup.ShowDialog();
                    if (edAddGroup.GroupForList != null)
                    {
                        var data = edAddGroup.GroupForList;
                        ConvClassDataToRow(dataGridViewGroups, edAddGroup.GroupForView);
                        listGroups[listGroups.IndexOf(currentGroup)] = edAddGroup.GroupForList;
                        var studentContains = listStudents.Where(x => x.IdGroup.Equals(data.Id)).ToList();
                        var scheduleContains = listSchedule.Where(x => x.IdGroup.Equals(data.Id)).ToList();
                        //Udpate group in scheduleDataGridView 
                        if (scheduleContains != null)
                        {
                            for (int i = 0; i < scheduleContains.Count; i++)
                            {
                                var cell = dataGridViewSchedule.Rows.Cast<DataGridViewRow>()
                                    .Where(x => x.Cells.GetCellFromColumnHeader("Id").Value.Equals(scheduleContains[i].Id))
                                    .Select(x => x.Cells.GetCellFromColumnHeader("Group")).First();
                                if (!cell.Value.ToString().Equals(data.Name))
                                {
                                    cell.Selected = true;
                                    cell.Value = data.Name;
                                    cell.Selected = false;
                                }
                            }
                        }
                        //Update group in studentDataGridView 
                        if (studentContains != null)
                        {
                            for (int i = 0; i < studentContains.Count; i++)
                            {
                                var cell = dataGridViewLecturers.Rows.Cast<DataGridViewRow>()
                                          .Where(x => x.Cells.GetCellFromColumnHeader("Id").Value.Equals(studentContains[i].Id))
                                          .Select(q => q.Cells.GetCellFromColumnHeader("Group")).First();
                                if (!cell.Value.ToString().Equals(data.Name))
                                {
                                    cell.Selected = true;
                                    cell.Value = data.Name;
                                    cell.Selected = false;
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Choose only one row in one gridView!");
            }
        }

        private void btnUpdSchedule_Click(object sender, EventArgs e)
        {
            if (dataGridViewSchedule.SelectedRows.Count == 1)
            {
                var currentRow = dataGridViewSchedule.CurrentRow.Cells[0].Value;
                var currentSchedule = listSchedule.First(x => x.Id.Equals(currentRow));
                EdAddSchedule edSchedule = new EdAddSchedule(listGroups, listLecturers, listSubjects, currentSchedule);
                edSchedule.ShowDialog();
                if (edSchedule.NewScheduleForView != null && edSchedule.NewScheduleForView.Id > 0)
                {
                    var dataList = edSchedule.NewScheduleForList;
                    var dataView = edSchedule.NewScheduleForView;
                    var index = dataGridViewSchedule.CurrentCell.RowIndex;
                    ConvClassDataToRow(dataGridViewSchedule, dataView);
                    listSchedule[listSchedule.IndexOf(currentSchedule)] = dataList;
                }
            }
            else
            {
                MessageBox.Show("Choose only one row!");
            }
        }

        //DELETE BUTTONS
        private void butStudDel_Click(object sender, EventArgs e)
        {
            int key = DeleteRow(dataGridViewStudents);
            if (key != 0)
            {
                listStudents.RemoveAt(listStudents.FindIndex(x => x.Id.Equals(key)));
            }
        }

        private void btnLectDel_Click(object sender, EventArgs e)
        {
            if (dataGridViewLecturers.SelectedRows.Count == 1)
            {
                int keyId = DeleteRow(dataGridViewLecturers);
                if (keyId != 0)
                {
                    var groupContains = listGroups
                        .Where(x => x.IdLecturer.Equals(keyId)).ToList();
                    var scheduleContains = listSchedule
                        .Where(x => x.IdGroup.Equals(keyId)).ToList();
                    if(groupContains != null)
                    {
                        for (int i = 0; i < groupContains.Count; i++)
                        {
                            groupContains[i].IdLecturer = 0;
                            var answer = adminController.Update(groupContains[i]);
                            if (answer == true)
                            {
                                listGroups[listGroups.IndexOf(groupContains[i])].IdLecturer = 0;
                                var cell = dataGridViewGroups.Rows.Cast<DataGridViewRow>()
                                    .Where(x => x.Cells.GetCellFromColumnHeader("Id").Value.Equals(groupContains[i].Id))
                                    .Select(x => x.Cells.GetCellFromColumnHeader("Curator"))
                                    .First();
                                cell.Selected = true;
                                cell.Value = null;
                                cell.Selected = false;
                            }
                        }
                    }
                    if (scheduleContains != null)
                    {
                        for (int i = 0; i < scheduleContains.Count; i++)
                        {
                            var answer = adminController.Delete(scheduleContains[i].Id, dataGridViewSchedule.Tag.ToString());
                            if (answer == true)
                            {
                                var row = dataGridViewSchedule.Rows.Cast<DataGridViewRow>()
                                    .Where(x => x.Cells.GetCellFromColumnHeader("Id").Value.ToString().Equals(scheduleContains[i].Id.ToString()))
                                    .First();
                                dataGridViewSchedule.Rows.RemoveAt(row.Index);
                            }
                            listSchedule.RemoveAt(listSchedule.FindIndex(x => x.Id.Equals(scheduleContains[i].Id)));
                        }
                    }
                    listLecturers.RemoveAt(listLecturers.FindIndex(x => x.Id.Equals(keyId)));
                }
            }
        }

        private void btnDelSubjGroup_Click(object sender, EventArgs e)
        {
            if (!(dataGridViewSubjects.SelectedRows.Count + dataGridViewGroups.SelectedRows.Count > 1))
            {
                //Delete subject
                if (dataGridViewSubjects.SelectedRows.Count == 1)
                {
                    var keyId = DeleteRow(dataGridViewSubjects);
                    if (keyId != 0)
                    {
                        var lectContains = listLecturers.Where(x => x.ListSubjectsLecturer.Contains(keyId.ToString())).ToList();
                        var scheduleContains = listSchedule.Where(x => x.IdSubject.Equals(keyId)).ToList();
                        //Delete subject in schedule 
                        if (scheduleContains != null)
                        {
                            for (int i = 0; i < scheduleContains.Count; i++)
                            {
                                var row = dataGridViewSchedule.Rows.Cast<DataGridViewRow>()
                                    .Where(x => x.Cells.GetCellFromColumnHeader("Id").Value.Equals(scheduleContains[i].Id))
                                    .First();
                                if (adminController.Delete(scheduleContains[i].Id, dataGridViewSchedule.Tag.ToString()).Equals(true))
                                {
                                    dataGridViewSchedule.Rows.RemoveAt(row.Index);
                                }
                                listSchedule.RemoveAt(listSchedule.FindIndex(x => x.Id.Equals(scheduleContains[i].Id)));
                            }
                        }
                        //Delete subject in lecturer 
                        if (lectContains != null)
                        {
                            lectContains
                                .Where(x => x.ListSubjectsLecturer.Remove(keyId.ToString())).ToList()
                                .ForEach(x => x.Subjects = ConvertValueHelper.ConvertListToStringForDB(x.ListSubjectsLecturer));
                            for (int i = 0; i < lectContains.Count; i++)
                            {
                                var cell = dataGridViewLecturers.Rows.Cast<DataGridViewRow>()
                                          .Where(x => x.Cells.GetCellFromColumnHeader("Id").Value.Equals(lectContains[i].Id))
                                          .Select(q => q.Cells.GetCellFromColumnHeader("Subjects"))
                                          .First();
                                if (lectContains[i].ListSubjectsLecturer.Count > 0)
                                {
                                    var destination = AutoMapperHelper.MapperConfiguration<Lecturer, Person>(lectContains[i]);
                                    if (adminController.Update(destination).Equals(true))
                                    {
                                        List<string> list = new List<string>();
                                        foreach (var item in lectContains[i].ListSubjectsLecturer)
                                        {
                                            list.Add(listSubjects.First(x => x.Id.ToString().Equals(item)).Name);
                                        }
                                        listLecturers[listLecturers.FindIndex(x => x.Id.Equals(destination.Id))] = lectContains[i];
                                        cell.Selected = true;
                                        cell.Value = ConvertValueHelper.ConvertListToStringForView(list);
                                        cell.Selected = false;
                                    }
                                }
                                else
                                {
                                    cell.Selected = true;
                                    cell.Value = null;
                                    cell.Selected = false;
                                }
                            }
                        }
                        listSubjects.RemoveAt(listSubjects.FindIndex(x => x.Id.Equals(keyId)));
                    }
                }
                if (dataGridViewGroups.SelectedRows.Count == 1)
                {
                    var keyId = DeleteRow(dataGridViewGroups);
                    if (keyId != 0)
                    {
                        var studentContains = listStudents.Where(x => x.IdGroup.Equals(keyId)).ToList();
                        var scheduleContains = listSchedule.Where(x => x.IdGroup.Equals(keyId)).ToList();
                        //Delete group in student
                        if (studentContains != null)
                        {
                            foreach (var item in studentContains)
                            {
                                item.IdGroup = 0;
                                var destination = AutoMapperHelper.MapperConfiguration<Student, Person>(item);
                                if (adminController.Update(destination).Equals(true))
                                {
                                    var rowStudentContain = dictRowPerson.First(x => x.Key.Equals(item.Id)).Value;
                                    var currentCell = dataGridViewStudents.Rows[rowStudentContain].Cells[8];
                                    currentCell.Selected = true;
                                    currentCell.Value = null;
                                    currentCell.Selected = false;
                                }
                            }
                        }
                        //Delete group in schedule
                        if (scheduleContains != null)
                        {
                            foreach (var item in scheduleContains)
                            {
                                if (adminController.Delete(item.Id, dataGridViewSchedule.Tag.ToString()).Equals(true))
                                {
                                    var row = dataGridViewSchedule.Rows.Cast<DataGridViewRow>()
                                        .Where(x => x.Cells.GetCellFromColumnHeader("Id").Value.ToString().Equals(item.Id.ToString()))
                                        .First();
                                        dataGridViewSchedule.Rows.Remove(row);
                                }
                                listSchedule.RemoveAt(listSchedule.FindIndex(x => x.Id.Equals(item.Id)));
                            }
                        }
                        listGroups.RemoveAt(listGroups.FindIndex(x => x.Id.Equals(keyId)));
                    }
                }
            }
            else
            {
                MessageBox.Show("Choose only one row in one gridView!");
            }
        }

        private void btnDelSchedule_Click(object sender, EventArgs e)
        {
            if(dataGridViewSchedule.SelectedRows.Count == 1)
            {
                int key = DeleteRow(dataGridViewSchedule);
                if (key != 0)
                {
                    listSchedule.RemoveAt(listSchedule.FindIndex(x => x.Id.Equals(key)));
                }
            }
        }

        //METHODS FOR PERFORMING TYPICAL OPERATIONS
        //Search data
        private void SearchData(TabPage tabPage, ComboBox comboBox, string cellValue)
        {
            if (comboBox.SelectedItem != null)
            {
                foreach (var ctrl in tabPage.Controls.OfType<DataGridView>())
                {
                    ctrl.ClearSelection();
                    foreach (DataGridViewRow row in ctrl.Rows)
                    {
                        if (ctrl.Columns[0].Tag != null)
                        {
                            DataGridViewCell cell = row.Cells.GetCellFromColumnTag(comboBox.SelectedItem.ToString());
                            if (cell != null)
                            {
                                if (cell.Value != null)
                                {
                                    if (cell.Value.ToString().ToLower().StartsWith(cellValue.ToLower()) && cellValue != "")
                                    {
                                        row.Selected = true;
                                    }
                                }
                            }
                            else
                            {
                                continue;
                            }
                        }
                        else
                        {
                            DataGridViewCell cell = row.Cells.GetCellFromColumnHeader(comboBox.SelectedItem.ToString());
                            if (cell.Value != null)
                            {
                                if (cell.Value.ToString().ToLower().StartsWith(cellValue.ToLower()) && cellValue != "" )
                                {
                                    row.Selected = true;
                                }
                            }
                        }
                    }
                }
            }
        }

        //Load all data from lists to dataGridViews
        private void LoadData()
        {
            if (listSubjects != null)
            {
                foreach (var item in listSubjects)
                {
                    int index = dataGridViewSubjects.Rows.Add(
                        item.Id,
                        item.Name
                        );
                    dictSubjects.Add(item.Id, item.Name);
                    dict.Add(item.Name, item.Id);
                }
                dataGridViewSubjects.Columns[0].Tag = "Id";
                dataGridViewSubjects.Columns[1].Tag = "Subject";
            }
            if (listLecturers != null)
            {
                foreach (var item in listLecturers)
                {
                    List<string> newListSubjects = new List<string>();
                    if (item.Subjects != null)
                    {
                        item.ListSubjectsLecturer = ConvertValueHelper.ConvertStringToList(item.Subjects);
                        for (int val = 0; val < item.ListSubjectsLecturer.Count; val++)
                        {
                            newListSubjects.Add(listSubjects.First(x => x.Id.ToString().Equals(item.ListSubjectsLecturer[val])).Name);
                        }
                        item.Subjects = ConvertValueHelper.ConvertListToStringForView(newListSubjects);
                    }
                    string Sex = ((SexEnum)item.SexInt).ToString();
                    int index = dataGridViewLecturers.Rows.Add(
                        item.Id,
                        item.Name,
                        item.Surname,
                        item.Birthday,
                        Sex,
                        item.Experience,
                        item.Subjects
                        );

                    dictCurators.Add(item.Id, item.Name + " " + item.Surname);
                    dictRowPerson.Add(item.Id, index);
                    autoCompleteCurators.Add(item.Name + " " + item.Surname);
                }
            }
            if (listGroups != null)
            {
                foreach (var item in listGroups)
                {
                    int index = dataGridViewGroups.Rows.Add(
                        item.Id,
                        item.Name,
                        listLecturers.Where(x => x.Id.Equals(item.IdLecturer)).Select(x => x.Name+" "+x.Surname).FirstOrDefault());
                    dictGroups.Add(item.Id, item.Name);
                    dict.Add(item.Name, item.Id);
                    autoCompleteGroups.Add(item.Name);
                }
                dataGridViewGroups.Columns[0].Tag = "Id";
                dataGridViewGroups.Columns[1].Tag = "Group";
                dataGridViewGroups.Columns[2].Tag = "Curator";
            }
            if (listStudents != null)
            {
               
                foreach (var item in listStudents)
                {
                    string Sex = ((SexEnum)item.SexInt).ToString();
                    int index = dataGridViewStudents.Rows.Add(
                        item.Id,
                        item.Name,
                        item.Surname,
                        item.Birthday,
                        Sex,
                        item.Course,
                        item.ExamBook,
                        item.AverageMark,
                        listGroups.Where(x => x.Id.Equals(item.IdGroup)).Select(x => x.Name).FirstOrDefault());
                    listExBook.Add(item.ExamBook);
                    dictRowPerson.Add(item.Id, index);
                }
            }
            if (listSchedule != null)
            {
                foreach (var item in listSchedule)
                {
                    int index = dataGridViewSchedule.Rows.Add(
                        item.Id,
                        item.DaysEnum,
                        item.NumSubject,
                        listSubjects.Where(x => x.Id.Equals(item.IdSubject)).Select(x => x.Name).FirstOrDefault(),
                        listGroups.Where(x => x.Id.Equals(item.IdGroup)).Select(x => x.Name).FirstOrDefault(),
                        listLecturers.Where(x => x.Id.Equals(item.IdLecturer)).Select(x => x.Name + " " + x.Surname).FirstOrDefault());
                }
            }
        }

        //Method for convert model value to cells row value 
        private void ConvClassDataToRow<TEntity>(DataGridView dataGridView, TEntity entity)
        {
            if (dataGridView.SelectedCells.Count > 0)
            {
                var properties = entity.GetType().GetProperties();
                var selectedRowIndex = dataGridView.CurrentCell.RowIndex;
                for (int i = 0; i < dataGridView.ColumnCount; i++)
                {
                    var nameColumn = dataGridView.Columns[i].HeaderText;
                    var cellValue = dataGridView.Rows[selectedRowIndex].Cells[i];
                    var property = properties.Where(x => x.Name.Equals(nameColumn)).FirstOrDefault();
                    if (property != null)
                    {
                        var propertyType = property.PropertyType;
                        cellValue.Selected = true;
                        if (cellValue.Value == null)
                        {
                            cellValue.Value = property.GetValue(entity);
                        }
                        else
                        {
                            cellValue.Value = Convert.ChangeType(property.GetValue(entity), cellValue.Value.GetType());
                        }
                    }
                }
            }
        }
        private int DeleteRow(DataGridView dataGridView)
        {
            if (dataGridView.SelectedRows.Count == 1)
            {
                var rowIndex = dataGridView.CurrentCell.RowIndex;
                var key = Int32.Parse(dataGridView.Rows[rowIndex].Cells[0].Value.ToString());
                if (key != 0)
                {
                    modalWindow.ShowDialog();
                    if (modalWindow.Answer.Equals(true))
                    {
                        if (adminController.Delete(key, dataGridView.Tag.ToString()))
                        {
                            dataGridView.Rows.RemoveAt(rowIndex);
                            MessageBox.Show("Success delete");
                            return key;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Unsuccess delete");
                    }
                }
            }
            else
            {
                MessageBox.Show("Choose only one row!");
            }
            return 0;
        }
        private void txtBoxScheduleDay_TextChanged(object sender, EventArgs e)
        {
        }
        private void comboBoxLectName_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void listViewGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void button2_Click(object sender, EventArgs e)
        {
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
        }
        private void btnConfGroup_Click(object sender, EventArgs e)
        {
        }
        private void btnConfEdAddSchedule_Click(object sender, EventArgs e)
        {
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void button10_Click(object sender, EventArgs e)
        {
        }
        private void butOrderDescend_Click(object sender, EventArgs e)
        {
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void textBoxStudSearch_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBoxLectSearch_TextChanged(object sender, EventArgs e)
        {
        }
        private void txtBoxSearchSubjGroup_TextChanged(object sender, EventArgs e)
        {
        }
        private void listViewStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void tabPageStudents_Click(object sender, EventArgs e)
        {
        }
        private void dataGridViewStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void cbBoxSearchStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void dataGridViewLecturers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
