using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testing.Domain.Entities.Models;

namespace Testing.Models
{
    public class Group : BaseEntity
    {
        public string Name { get; set; }
        public int IdLecturer { get; set; }

    }
}
