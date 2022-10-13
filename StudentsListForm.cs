using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendanceForm
{
    public partial class StudentsListForm : Form
    {
        public StudentsListForm()
        {
            InitializeComponent();
        }

        private void StudentsList_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            List<Student> _students = new List<Student>();
            using (var ctx = new DatabaseContext())
            {
                _students = ctx.Students.ToList();
            }
            studentList.DataSource = _students;
           
        }
        private void studentList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (studentList.SelectedRows.Count != 0)
            //{
            //    DataGridViewRow row = this.studentList.SelectedRows[0];
            //    row.Cells["StudentId"].Value
            //}

        }

        private void markAttendance_Click(object sender, EventArgs e)
        {
            var attendanceForm = new AttendanceForm();
            attendanceForm.Show();
        }

        private void addStudent_Click(object sender, EventArgs e)
        {
            var dataEntryForm = new StudentDataEntryForm();
            dataEntryForm.Show();
        }
    }
}
