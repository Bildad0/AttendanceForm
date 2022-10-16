using System;
using System.Collections;
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
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
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

            //resize the datagrid columns as per the data length
            for (int i = 0; i < dataGridViewDataEntry.Columns.Count; i++)
            {
                dataGridViewDataEntry.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
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
                LoadData();
            }

        }


        public void ResetFields()
        {
            studentName.Text = "";
            studentAge.Text = "";
        }


        //returns the selected user ID
        private void GetCellData(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridViewDataEntry.Rows.Count > 0)
            {
                foreach(DataGridViewRow row in dataGridViewDataEntry.SelectedRows)
                {
                    idtextBox.Text = row.Cells[0].Value.ToString();//this is a read only texbox
                    studentName.Text = row.Cells[1].Value.ToString();
                    studentAge.Text = row.Cells[2].Value.ToString();
                    
                }
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            //Student std = SetValues(Convert.ToInt32(idtextBox.Text), studentName.Text, Convert.ToInt32(studentAge.Text));
            EditStudent(Convert.ToInt32(idtextBox.Text));
        }

        public void EditStudent(int id)
        {
           using(var ctx = new DatabaseContext())
            {
                var data = ctx.Students.Where(i => i.StudentId == id);
                var student = new Student()
                {
                    StudentName= studentName.Text, 
                    StudentAge= int.Parse(studentAge.Text),
                };

                if(data !=null)
                {
                    //update user student if the field selected is not null
                    ctx.Entry(data).State = System.Data.Entity.EntityState.Modified;
                    ctx.Students.Attach(student);
                    
                }
                else
                {
                    //Add new student if the field is null.
                    ctx.Students.Add(student);
                }
                ctx.SaveChanges();
                MessageBox.Show("Edited");
                ResetFields();
                LoadData();
            }
        }
    }
}
