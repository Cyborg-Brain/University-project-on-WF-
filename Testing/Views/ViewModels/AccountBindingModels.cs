using DataAnnotationsExtensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Testing.Domain.Entities.Enums;
using Testing.Domain.Entities.Infrastructure;
using Testing.Domain.Entities.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Testing.Views.ViewModels
{
    public class AuthorizeValidationModel
    {
        [Required]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = Errors.emailErr)]
        public string Email { get; set; }
        [Required]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{6,20}$", ErrorMessage = Errors.passErr)]
        public string Password { get; set; }
    }
    public class LecturerValidationModel
    {
        [Required]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = Errors.emailErr)]
        public string Email { get; set; }
        [Required]
        [RegularExpression(@"[A-Za-z]{2,20}", ErrorMessage = Errors.nameErr)]
        public string Name { get; set; }
        [Required]
        [RegularExpression(@"[A-Za-z]{2,20}", ErrorMessage = Errors.surnameErr)]
        public string Surname { get; set; }
        [Required]
        [CustomDate(-80, -20, ErrorMessage = Errors.birthdayErr)]
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
        [Required]
        [RegularExpression(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{6,20}$", ErrorMessage = Errors.passErr)]
        public string Password { get; set; }
        [Required]
        [EqualTo("Password", ErrorMessage = Errors.confPassErr)]
        public string ConfirmPassword { get; set; }
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

    public class StudentValidationModel
    {
        [Required]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = Errors.emailErr)]
        public string Email { get; set; }
        [Required]
        [RegularExpression(@"[A-Za-z]{2,20}", ErrorMessage = Errors.nameErr)]
        public string Name { get; set; }
        [Required]
        [RegularExpression(@"[A-Za-z]{2,20}", ErrorMessage = Errors.surnameErr)]
        public string Surname { get; set; }
        [Required]
        [CustomDate(-80, -17, ErrorMessage = Errors.birthdayErr)]
        public DateTime BirthdayDT { get; set; }
        [Required]
        public SexEnum Sex
        {
            get { return (SexEnum)this.SexInt; }
            set { this.SexInt = (int)value; }
        }
        [Required]
        [RegularExpression(@"^[1-2]{1}$", ErrorMessage = Errors.sexErr)]
        public int SexInt { get; set; }
        [Required]
        [RegularExpression(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{6,20}$", ErrorMessage = Errors.passErr)]
        public string Password { get; set; }
        [Required]
        [EqualTo("Password", ErrorMessage = Errors.confPassErr)]
        public string ConfirmPassword { get; set; }
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

    public class LecturerValidationModelShort
    {
        [Required]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = Errors.emailErr)]
        public string Email { get; set; }
        [Required]
        [RegularExpression(@"[A-Za-z]{2,20}", ErrorMessage = Errors.nameErr)]
        public string Name { get; set; }
        [Required]
        [RegularExpression(@"[A-Za-z]{2,20}", ErrorMessage = Errors.surnameErr)]
        public string Surname { get; set; }
        [Required]
        [CustomDate(-80, -20, ErrorMessage = Errors.birthdayErr)]
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
        [Required]
        [Range(0, 30, ErrorMessage = Errors.expErr)]
        public int Experience { get; set; }
    }

    public class StudentValidationModelShort
    {
        [Required]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = Errors.emailErr)]
        public string Email { get; set; }
        [Required]
        [RegularExpression(@"[A-Za-z]{2,20}", ErrorMessage = Errors.nameErr)]
        public string Name { get; set; }
        [Required]
        [RegularExpression(@"[A-Za-z]{2,20}", ErrorMessage = Errors.surnameErr)]
        public string Surname { get; set; }
        [Required]
        [CustomDate(-80, -17, ErrorMessage = Errors.birthdayErr)]
        public DateTime BirthdayDT { get; set; }
        [Required]
        public SexEnum Sex
        {
            get { return (SexEnum)this.SexInt; }
            set { this.SexInt = (int)value; }
        }
        [Required]
        [RegularExpression(@"^[1-2]{1}$", ErrorMessage = Errors.sexErr)]
        public int SexInt { get; set; }
        [Required]
        [RegularExpression(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{6,20}$", ErrorMessage = Errors.passErr)]
        public string Password { get; set; }
        [Required]
        [EqualTo("Password", ErrorMessage = Errors.confPassErr)]
        public string ConfirmPassword { get; set; }
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
}
