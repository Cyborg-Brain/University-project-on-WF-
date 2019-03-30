using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testing.Domain.Entities.Enums;
using Testing.Domain.Entities.Models;

namespace Testing.Models
{
    public class Schedule : BaseEntity
    {
        public int DayInt { get; set; }
        [NotMapped]
        [EnumDataType(typeof(DaysEnum))]
        public DaysEnum? DaysEnum
        {
            get { return (DaysEnum)this.DayInt;}
            set {
                    this.DayInt = (int)value;
            }
        }
        public int NumSubject { get; set; }
        public int IdSubject { get; set; }
        public int IdGroup { get; set; }
        public int IdLecturer { get; set; }
    }
}
