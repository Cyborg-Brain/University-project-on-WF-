using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testing.Models;

namespace Testing.Domain.Entities.Infrastructure
{
    
    public class ApplicationContext : DbContext
    {
        public ApplicationContext() : base("UniverContext")
        {
            this.Configuration.LazyLoadingEnabled = false;
            //this.Configuration.AutoDetectChangesEnabled = true;
            Database.SetInitializer(new CreateDatabaseIfNotExists<ApplicationContext>());
        }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Schedule> Schedule { get; set; }
        public DbSet<Group> Groups { get; set; }
    }
}
