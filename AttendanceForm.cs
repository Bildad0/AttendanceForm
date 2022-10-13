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
            dataGridView1.Columns.Insert(1,checkBoxColumn);

            DataGridViewCheckBoxColumn checkBoxColumn1 = new DataGridViewCheckBoxColumn();
            checkBoxColumn1.HeaderText = "Absent";
            checkBoxColumn1.Name = "Absent";
            dataGridView1.Columns.Insert(2, checkBoxColumn1);
        }

       

    }
}
