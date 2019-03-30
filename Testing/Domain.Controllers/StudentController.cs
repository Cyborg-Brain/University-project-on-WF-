using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testing.Domain.Data;
using Testing.Domain.Entities.ViewModels;
using Testing.Models;
using Testing.Views.ViewModels;

namespace Testing.Domain.Controllers
{
    public class StudentController
    {
        private GroupRepository groupRepository;
        private SubjectRepository subjectRepository;
        private LecturerRepository lecturerRepository;
        private ScheduleRepository scheduleRepository;
        public StudentController()
        {
            subjectRepository = new SubjectRepository();
            scheduleRepository = new ScheduleRepository();
            lecturerRepository = new LecturerRepository();
            groupRepository = new GroupRepository();
        }

        public List<ScheduleView> Schedule(int GroupId)
        {
            var curGroup = groupRepository.FindOne(x => x.Id == GroupId);
            var subject = subjectRepository.SelectMany();
            var lecturer = lecturerRepository.SelectMany<Lecturer>(x => x.StatusInt == 2);
            var schedule = scheduleRepository.SelectMany().Where(x => x.IdGroup == curGroup.Id);
            List<ScheduleView> listView = new List<ScheduleView>();
            foreach (var item in schedule)
            {
                ScheduleView scheduleView = new ScheduleView();
                scheduleView.Day = item.DaysEnum;
                scheduleView.NumSubject = item.NumSubject;
                scheduleView.Lecturer = lecturer.Where(x => x.Id.Equals(item.IdLecturer)).Select(x => (x.Name +" "+ x.Surname)).FirstOrDefault();
                scheduleView.Subject = subject.Where(x => x.Id.Equals(item.IdSubject)).Select(x => x.Name).FirstOrDefault();
                scheduleView.Group = curGroup.Name;
                listView.Add(scheduleView);
            }
            return listView;
        }
    }
}
