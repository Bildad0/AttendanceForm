using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceForm
{
    class Student
    {
        [Key]
        public int StudentId { get; set; }

        public string StudentName { get; set; }

        public float StudentAge { get; set; }

        public ICollection<AttendanceClass> AttendanceClasses { get; set; }
    }
}
