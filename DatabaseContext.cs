using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceForm
{
    class DatabaseContext:DbContext
    {
        public DatabaseContext():base("SchoolAttendance")
        { 
        
        }
        public DbSet<Student> Students { get; set; }

        public DbSet<AttendanceClass> AttendanceClasses { get; set; }

    }
}
