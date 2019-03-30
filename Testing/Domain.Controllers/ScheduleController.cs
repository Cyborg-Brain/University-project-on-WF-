using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testing.Domain.Data;
using Testing.Domain.Entities.ViewModels;
using Testing.Models;

namespace Testing.Domain.Controllers
{
    public class ScheduleController
    {
        private SubjectRepository subjectRepository;
        private GroupRepository groupRepository;
        private LecturerRepository lecturerRepository;
        private ScheduleRepository scheduleRepository;
        public ScheduleController()
        {
            scheduleRepository = new ScheduleRepository();
            groupRepository = new GroupRepository();
            lecturerRepository = new LecturerRepository();
            subjectRepository = new SubjectRepository();
        }

        public List<Subject> ListSubjects()
        {
            return subjectRepository.SelectMany();
        }

        public List<Group> ListGroups()
        {
            return groupRepository.SelectMany();
        }

        public List<Lecturer> ListLecturers()
        {
            return lecturerRepository.SelectMany<Lecturer>(x => x.StatusInt == 2);
        }

        public List<Schedule> Schedule()
        {
            return scheduleRepository.SelectMany();
        }
    }
}
