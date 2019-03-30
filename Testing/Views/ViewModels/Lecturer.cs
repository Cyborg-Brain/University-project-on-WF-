using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testing.Domain.Entities.Enums;
using Testing.Domain.Entities.Infrastructure;
using Testing.Domain.Entities.Models;

namespace Testing.Domain.Entities.ViewModels
{
    public class Lecturer : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Birthday { get; set; }
        [NotMapped]
        public DateTime BirthdayDate
        {
            get { return Convert.ToDateTime(this.Birthday); }
            set { this.Birthday = value.ToShortDateString(); }
        }
        [NotMapped]
        public SexEnum SexLect
        {
            get { return (SexEnum)this.SexInt; }
            set { this.SexInt = (int)value; }
        }
        public int SexInt { get; set; }
        //[NotMapped]
        //public Status Status
        //{
        //    get { return (Status)this.StatusInt; }
        //    set { this.StatusInt = (int)value; }
        //}
        public int StatusInt { get; set; }
        public int Experience { get; set; }
        //for saving list
        public List<string> ListSubjectsLecturer { get; set; } = new List<string>();
        public string Subjects { get; set; }
    }
}
