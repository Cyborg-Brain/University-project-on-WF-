using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testing.Domain.Entities.Enums;

namespace Testing.Domain.Entities.Models
{
    public class Student : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Birthday{ get;set; }
        [NotMapped]
        public DateTime BirthdayDate
        {
            get { return Convert.ToDateTime(this.Birthday); }
            set { this.Birthday = value.ToShortDateString(); }
        }
        [NotMapped]
        public SexEnum SexStud
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
        public int ExamBook { get; set; }
        public int Course { get; set; }
        public int AverageMark { get; set; }
        public int IdGroup { get; set; }
        public string Group { get; set; }
    }
}
