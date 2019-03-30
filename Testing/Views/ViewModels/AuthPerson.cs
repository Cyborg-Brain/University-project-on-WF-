using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing.Domain.Entities.Models
{
    public class AuthPerson : BaseEntity
    {
        public string Email { get; set; }
        public int StatusInt { get; set; }
    }
}
