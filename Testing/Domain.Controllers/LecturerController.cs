using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testing.Domain.Data;
using Testing.Domain.Entities.Infrastructure.Helpers;
using Testing.Domain.Entities.Models;
using Testing.Models;

namespace Testing.Domain.Controllers
{
    public class LecturerController
    {
        private GroupRepository groupRepository;
        private SubjectRepository subjectRepository;
        private StudentRepository studentRepository;
        public LecturerController()
        {
            subjectRepository = new SubjectRepository();
            studentRepository = new StudentRepository();
            groupRepository = new GroupRepository();
        }

        public List<string> ListSubjects(List<string> Subjects)
        {
            if (Subjects != null)
            {
                List<string> listSubj = new List<string>();
                foreach (var item in Subjects)
                {
                    listSubj.Add(subjectRepository.FindOne(x => x.Id.ToString().Equals(item)).Name);
                }
                return listSubj;
            }
            return null;
        }

        public List<Student> ListStudents(int KeyId)
        {
            var groupOfCurator = groupRepository.FindOne(x => x.IdLecturer.Equals(KeyId));
            if (groupOfCurator != null)
            {
                return studentRepository.SelectMany<Student>(
                    x => x.StatusInt == 3 && x.IdGroup.Equals(groupOfCurator.Id));
            }
            return null;
        }

        //Update
        public bool Update(Person person)
        {
            return studentRepository.Update(person, person.Id);
        }

    }
}
