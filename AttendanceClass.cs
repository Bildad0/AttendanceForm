using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceForm
{
    class AttendanceClass
    {
        [Key]
        public int Attendance_id { get; set; }

        public DateTime  Date { get; set; }
        public int Student_id { get; set; }

        public string Lesson { get; set; }
        public string Status { set; get; }

        [ForeignKey("Student_id")]
        public Student Students { get; set; }
    }
}
