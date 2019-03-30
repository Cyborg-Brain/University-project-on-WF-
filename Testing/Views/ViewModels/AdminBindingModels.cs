using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testing.Domain.Entities.Enums;
using Testing.Domain.Entities.Infrastructure;
using Testing.Domain.Entities.Models;

namespace Testing.Views.ViewModels
{
    public class ShortLecturerValidationModel : BaseEntity
    {
        [Required]
        [RegularExpression(@"[A-Za-z]{2,20}", ErrorMessage = Errors.nameErr)]
        public string Name { get; set; }
        [Required]
        [RegularExpression(@"[A-Za-z]{2,20}", ErrorMessage = Errors.surnameErr)]
        public string Surname { get; set; }
        public string Birthday { get; set; }
        [Required]
        [CustomDate(-80, -20,ErrorMessage = Errors.birthdayErr)]
        public DateTime BirthdayDt { get; set; }
        [Required]
        public SexEnum Sex
        {
            get { return (SexEnum)this.SexInt; }
            set { this.SexInt = (int)value; }
        }
        [Required]
        [RegularExpression(@"[1-2]{1}", ErrorMessage = Errors.sexErr)]
        public int SexInt { get; set; }
        public Domain.Entities.Enums.Status Status
        {
            get { return (Domain.Entities.Enums.Status)this.StatusInt; }
            set { this.StatusInt = (int)value; }
        }
        public int StatusInt { get; set; }
        [Required]
        [Range(0, 30, ErrorMessage = Errors.expErr)]
        public int Experience { get; set; }
        public List<string> ListSubjects { get; set; } = new List<string>();
        [Required]
        public string Subjects { get; set; }
    }

    public class ShortStudentValidationModel : BaseEntity
    {
        [Required]
        [RegularExpression(@"[A-Za-z]{2,20}", ErrorMessage = Errors.nameErr)]
        public string Name { get; set; }
        [Required]
        [RegularExpression(@"[A-Za-z]{2,20}", ErrorMessage = Errors.surnameErr)]
        public string Surname { get; set; }
        [Required]
        [CustomDate(-80, -17,ErrorMessage = Errors.birthdayErr)]
        public DateTime BirthdayDT { get; set; }
        [Required]
        public SexEnum Sex
        {
            get { return (SexEnum)this.SexInt; }
            set { this.SexInt = (int)value; }
        }
        [Required]
        [RegularExpression(@"[1-2]{1}", ErrorMessage = Errors.sexErr)]
        public int SexInt { get; set; }
        public Domain.Entities.Enums.Status Status
        {
            get { return (Domain.Entities.Enums.Status)this.StatusInt; }
            set { this.StatusInt = (int)value; }
        }
        public int StatusInt { get; set; }
        [Required]
        [RegularExpression(@"[0-9]{1,5}", ErrorMessage = Errors.examBook)]
        public int ExamBook { get; set; }
        [Required]
        [RegularExpression(@"[1-5]{1}", ErrorMessage = Errors.courseErr)]
        public int Course { get; set; }
        public int AverageMark { get; set; }
        [Required]
        public int IdGroup { get; set; }
    }

    public class GroupValidationModel : BaseEntity
    {
        [Required]
        [RegularExpression(@"([A-Z]{2}[-]{1}[1-9]{2})$", ErrorMessage = Errors.nameErr)]
        public string Name { get; set; }
        public int IdLecturer { get; set; }
        [Required]
        public string NameLecturer { get; set; }
    }

    public class SubjectValidationModel : BaseEntity
    {
        [Required]
        [MinLength(4,ErrorMessage = Errors.minLengthErr)]
        [MaxLength(60, ErrorMessage = Errors.maxLengthErr)]
        [RegularExpression(@"([A-Za-z]+\s*[a-z{2,}]+\s*){1,}", ErrorMessage = Errors.nameErr)]
        public string Name { get; set; }
    }

    public class CustomDateAttribute : RangeAttribute
    {
        public CustomDateAttribute(int minimum, int maximum)
          : base(typeof(DateTime),
                  DateTime.Now.AddYears(minimum).ToShortDateString(),
                  DateTime.Now.AddYears(maximum).ToShortDateString()
                  )
        { }
    }
}
