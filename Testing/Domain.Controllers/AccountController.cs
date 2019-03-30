using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testing.Domain.Data;
using Testing.Domain.Entities.Enums;
using Testing.Domain.Entities.Infrastructure;
using Testing.Domain.Entities.Models;
using Testing.Domain.Entities.ViewModels;
using Testing.Models;
using Testing.Views.ViewModels;

namespace Testing.Domain.Controllers
{
    public class AccountController
    {
        private GroupRepository groupRepository;
        private AccountRepository accountRepository;
        public AccountController()
        {
            accountRepository = new AccountRepository();
            groupRepository = new GroupRepository();
        }

        public List<Person> ListPerson()
        {
            return accountRepository.SelectMany();
        }

        public List<Group> ListGroups()
        {
            return groupRepository.SelectMany();
        }

        public AuthPerson Authorize(string email, string password)
        {
            return accountRepository.FindOne(email, password);
        }

        public Person CurrentPerson(string email)
        {
            return accountRepository.CurrentPerson(email);
        }

        public bool Register(Person person)
        {
            Person isPerson = null;
            switch (person.Status)
            {
                case Status.Student:
                    isPerson = accountRepository.FindOne(x => x.Email.Equals(person.Email) || x.ExamBook.Equals(person.ExamBook));
                    break;
                case Status.Lecturer:
                    isPerson = accountRepository.FindOne(x => x.Email.Equals(person.Email));
                    break;
            }
            if (isPerson == null)
            {
                accountRepository.Create(person);
                return true;
            }
            return false;
        }
    }
}
