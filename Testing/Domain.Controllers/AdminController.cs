using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testing.Domain.Data;
using Testing.Domain.Entities.Models;
using Testing.Domain.Entities.ViewModels;
using Testing.Models;
using Testing.Views.ViewModels;

namespace Testing.Domain.Controllers
{
    public class AdminController
    {
        private AdminRepository adminRepository;
        private GroupRepository groupRepository;
        private SubjectRepository subjectRepository;
        private StudentRepository studentRepository;
        private LecturerRepository lecturerRepository;
        private ScheduleRepository scheduleRepository;
        public AdminController()
        {
            adminRepository = new AdminRepository();
            groupRepository = new GroupRepository();
            subjectRepository = new SubjectRepository();
            studentRepository = new StudentRepository();
            scheduleRepository = new ScheduleRepository();
            lecturerRepository = new LecturerRepository();
        }

        //LOAD DATA FROM DATABASE
        public List<Student> ListStudents()
        {
            return studentRepository.SelectMany<Student>(
                x => x.StatusInt == 3);
        }

        public List<Lecturer> ListLecturers()
        {
            return lecturerRepository.SelectMany<Lecturer>(
                x => x.StatusInt == 2);
        }

        public List<Subject> ListSubjects()
        {
            return subjectRepository.SelectMany();
        }

        public List<Group> ListGroups()
        {
            return groupRepository.SelectMany();
        }

        public List<Schedule> ListSchedule()
        {
            return scheduleRepository.SelectMany();
        }

        //CREATE
        public Group Create(Group group)
        {
            var answer = groupRepository.FindOne(x => x.Name.Equals(group.Name) || x.IdLecturer.Equals(group.IdLecturer));
            if (answer == null)
            {
                var newGroup = groupRepository.Create(group);
                return newGroup;
            }
            return null;
        }

        public Subject Create(Subject subject)
        {
            if (subjectRepository.FindOne(x => x.Name.Equals(subject.Name)) == null)
            {
                var newSubject = subjectRepository.Create(subject);
                return newSubject;
            }
            return null;
        }

        public Schedule Create(Schedule schedule)
        {
            var isAvailable = scheduleRepository.FindOne(x => x.DayInt == schedule.DayInt && x.NumSubject == schedule.NumSubject && (x.IdGroup.Equals(schedule.IdGroup) || x.IdLecturer == schedule.IdLecturer));
            var lectListSubj = lecturerRepository.FindOne(schedule.IdLecturer);
            var lecturerContain = lectListSubj.ListSubjects.Contains(schedule.IdSubject.ToString());
            if (isAvailable == null && lecturerContain == true)
            {
                var newSchedule = scheduleRepository.Create(schedule);
                return newSchedule;
            }
            return null;
        }

        //UPDATE
        public bool Update(Person person)
        {
            bool requestDB = false;
            switch (person.Status)
            {
                case Entities.Enums.Status.Lecturer:
                    if (person.Subjects == null)
                    {
                        requestDB = lecturerRepository.Update(person, person.Id, x => new ShortLecturerValidationModel(){
                            Name = person.Name,
                            Surname = person.Surname,
                            Subjects = person.Subjects,
                            StatusInt = person.StatusInt,
                            SexInt = person.SexInt,
                            Experience = person.Experience,
                            Birthday = person.Birthday });
                    }
                    else
                    {
                        requestDB = lecturerRepository.Update(person, person.Id);
                    };
                    break;
                case Entities.Enums.Status.Student:
                    var answer = studentRepository.FindOne(
                        x => x.ExamBook.Equals(person.ExamBook) 
                        && !x.Id.Equals(person.Id));
                    if (answer == null)
                    {
                        requestDB = studentRepository.Update(person, person.Id);
                    }
                    else
                    {
                        requestDB = false;
                    }
                    break;
            }
            return requestDB;
        }

        public bool Update(Group group)
        {
            var answer = groupRepository.FindOne(x => x.Name.Equals(group.Name) && !x.IdLecturer.Equals(group.IdLecturer));
            if (answer == null)
            {
                var updateAnswer = groupRepository.Update(group, group.Id);
                return updateAnswer;
            }
            return false;
        }

        public bool Update(Subject subject)
        {
            var answer = subjectRepository.FindOne(x => x.Name.Equals(subject.Name));
            if (answer == null)
            {
                var updateAnswer = subjectRepository.Update(subject, subject.Id);
                return updateAnswer;
            }
            return false;
        }

        public bool Update(Schedule schedule)
        {
            var lecturerSubject = lecturerRepository.FindOne(schedule.IdLecturer);
            var answer = scheduleRepository.FindOne((
                x => x.Id != schedule.Id &&
                x.DayInt == schedule.DayInt &&
                x.NumSubject == schedule.NumSubject && 
                x.IdGroup == schedule.IdGroup));
            if (lecturerSubject != null)
            {
                if ((answer == null && lecturerSubject.ListSubjects.Contains(schedule.IdSubject.ToString())) || schedule.IdSubject == 0)
                {
                    var updateAnswer = scheduleRepository.Update(schedule, schedule.Id);
                    return updateAnswer;
                }
            }
            else if (lecturerSubject == null)
            {
                if ((answer == null) || schedule.IdSubject == 0)
                {
                    var updateAnswer = scheduleRepository.Update(schedule, schedule.Id);
                    return updateAnswer;
                }
            }
            return false;
        }

        //DELETE
        public bool Delete(int keyId, string keyRepos)
        {
            bool answer = false;
            switch (keyRepos)
            {
                case "Student":
                    answer = studentRepository.Delete(keyId);
                    break;
                case "Lecturer":
                    answer = lecturerRepository.Delete(keyId);
                    break;
                case "Subject":
                    answer = subjectRepository.Delete(keyId);
                    break;
                case "Group":
                    answer = groupRepository.Delete(keyId);
                    break;
                case "Schedule":
                    answer = scheduleRepository.Delete(keyId);
                    break;
            }
            return answer;
        }
    }
}
