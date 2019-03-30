using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing.Domain.Entities.Infrastructure
{
    public static class Errors
    {
        public const string minLengthErr = "Too short";
        public const string maxLengthErr = "Too long";
        public const string intValueErr = "Only numbers";
        public const string avMarkError = "Invalid mark(Range 0-100)";
        public const string emptyErr = "Unavailable item";
        public const string emailErr = "Invalid email";
        public const string nameErr = "Invalid name";
        public const string surnameErr = "Invalid surname";
        public const string birthdayErr = "You are so small";
        public const string expErr = "Invalid date";
        public const string passErr = "Invalid format";
        public const string sexErr = "Choose man/woman!";
        public const string courseErr = "Choose course 1-5";
        public const string examBook = "Uncorrect format";
        public const string groupChoosedErr = "Invalid group";
        public const string curatorChoosedErr = "Invalid curator";
        public const string subjChooseErr = "Unavailable subject";
        public const string confPassErr = "Password and confirm password isn't equal";
    }
}
