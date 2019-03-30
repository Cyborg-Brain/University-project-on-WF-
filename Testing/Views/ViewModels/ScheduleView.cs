using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testing.Domain.Entities.Enums;
using Testing.Domain.Entities.Models;

namespace Testing.Views.ViewModels
{
    public class ScheduleView : BaseEntity
    {
        public DaysEnum? Day
        {
            get { return (DaysEnum)this.DayInt; }
            set { this.DayInt = (int)value; }
        }
        public int NumSubject { get; set; }
        public string Subject { get; set; }
        public string Group { get; set; }
        public string Lecturer { get; set; }
        public int DayInt { get; set; }
    }
}
