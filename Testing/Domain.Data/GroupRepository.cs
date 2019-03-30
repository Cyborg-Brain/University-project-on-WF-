using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testing.Domain.Entities.Infrastructure;
using Testing.Models;

namespace Testing.Domain.Data
{
    public class GroupRepository : GenericRepository<Group>
    {
        public GroupRepository() : base()
        { }
    }
}
