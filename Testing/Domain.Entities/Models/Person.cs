using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testing.Domain.Entities.Enums;
using Testing.Domain.Entities.Models;

namespace Testing.Models
{
    public class Person : BaseEntity
    {
        public string Email { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Birthday { get;  set; }
        [NotMapped]
        public DateTime BirthdayDT
        {
            get { return Convert.ToDateTime(this.Birthday); }
            set { this.Birthday = value.ToShortDateString(); }
        }
        [NotMapped]
        public SexEnum Sex
        {
            get { return (SexEnum)this.SexInt; }
            set { this.SexInt = (int)value; }
        }
        public int SexInt { get; set; }
        public string Password { get; set; }
        [NotMapped]
        public Status Status
        {
            get {return (Status)this.StatusInt;}
            set {this.StatusInt = (int)value; }
        }
        public int StatusInt { get; set; }
        //***Property student***
        public int ExamBook { get; set; }
        public int Course { get; set; }
        public int AverageMark { get; set; }
        public int IdGroup { get; set; }
        //******

        //***Property lecturer***
        public int Experience { get; set; }
        //for saving list
        [NotMapped]
        public List<string> ListSubjects
        {
            get { return Subjects.Split(',').ToList(); }
            set { Subjects = string.Join(",", value); }
        }
        public string Subjects { get; set; }
    }
}
