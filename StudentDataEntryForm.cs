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
    public partial class StudentDataEntryForm : Form
    {
        public StudentDataEntryForm()
        {
            InitializeComponent();
        }

        private void StudentDataEntryForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            List<Student> _students = new List<Student>();
            using(var ctx = new DatabaseContext())
            {
                _students = ctx.Students.ToList();
            }
            dataGridViewDataEntry.DataSource = _students;
        }

        private void save_Click(object sender, EventArgs e)
        {
            using(var ctx = new DatabaseContext())
            {
                var Student = new Student()
                {
                    StudentName = studentName.Text,
                    StudentAge= float.Parse(studentAge.Text),
                };

                ctx.Students.Add(Student);
                ctx.SaveChanges();
                MessageBox.Show("Saved");
                ResetFields();
            }

        }


        public void ResetFields()
        {
            studentName.Text = "";
            studentAge.Text = "";
        }
    }
}
