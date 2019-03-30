using CodePlex.LinqProjector;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testing.Domain.Entities.Enums;
using Testing.Domain.Entities.Infrastructure;
using Testing.Domain.Entities.Models;
using Testing.Domain.Repository.Interface;
using Testing.Models;

namespace Testing.Domain.Data
{
    public class AccountRepository:GenericRepository<Person>, IAccountRepository
    {
        private ApplicationContext applicationContext;
        public AccountRepository() : base()
        {
            applicationContext = new ApplicationContext();
        }

        public bool FindOne(string email, int status)
        {
            var parseAdmin = (int)Status.Admin;
            var person = (from context in applicationContext.Persons.AsNoTracking()
                         where (context.Email == email || (status == parseAdmin && context.StatusInt == parseAdmin))
                         select context.Email).Count();
            return person == 0 ? true : false;
        }
        public AuthPerson FindOne(string email, string password)
        {
            var person = from context in applicationContext.Persons.AsNoTracking()
                         where (context.Password == password) && (context.Email == email) select context;
            return person.Project().To<AuthPerson>().FirstOrDefault();
        }

        public Person CurrentPerson(string email)
        {
            var currentPerson = from context in applicationContext.Persons.AsNoTracking() where (context.Email == email) select context;
            return currentPerson.FirstOrDefault();
        }
    }
}
