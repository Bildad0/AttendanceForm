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
    public partial class AttendanceForm : Form
    {
        public AttendanceForm()
        {
            InitializeComponent();
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        private void AttendanceForm_Load(object sender, EventArgs e)
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
            dataGridView1.DataSource = _students;

            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.HeaderText = "Present";
            checkBoxColumn.Name = "Present";
            dataGridView1.Columns.Insert(3,checkBoxColumn);

            DataGridViewCheckBoxColumn checkBoxColumn1 = new DataGridViewCheckBoxColumn();
            checkBoxColumn1.HeaderText = "Absent";
            checkBoxColumn1.Name = "Absent";
            dataGridView1.Columns.Insert(4, checkBoxColumn1);

            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        private void attendanceSubmitBtn_Click(object sender, EventArgs e)
        {
            using(var ctx = new DatabaseContext())
            {
                var Attendance = new AttendanceClass()
                {
                    Date =lessonDate.Value,
                    Lesson = classComboBox.Text,
                    //Status= CheckBox.

                };
                GetCheckBoxValue();

                MessageBox.Show("Attendance recorded Succesfully");
            }
        }


        //Trying to get value of the check box onChecked and set it to the attendance class Status column

        public void GetCheckBoxValue()
        {
            foreach(DataGridViewRow roww in dataGridView1.Rows)
            {
                DataGridViewCheckBoxCell checking = roww.Cells[3] as DataGridViewCheckBoxCell;

                if (Convert.ToBoolean(checking.Value) == true)
                {
                    if (dataGridView1[3, roww.Index].Value.ToString() == "Present")
                    {
                        using(var ctx = new DatabaseContext())
                        {
                            var Attendance = new AttendanceClass()
                            {
                                Status = dataGridView1.Rows[roww.Index].Cells[3].Value.ToString(),
                        };
                        }
                    }
                }
            }
        }


    }
}
