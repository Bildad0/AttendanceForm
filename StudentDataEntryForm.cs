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


        //get cell data and cast it to the text input
        private void getCellData(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridViewDataEntry.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.dataGridViewDataEntry.SelectedRows[0];
                ArrayList arrayList = new ArrayList();

                for(int i =0; i<3; i++)
                {
                    arrayList.Insert(i, row.Cells["StudentName"].Value);
                }
                studentName.Text = (string)arrayList[1];
            }

        }
    }
}
