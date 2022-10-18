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
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        DatabaseContext ctx = new DatabaseContext();
        private void ReportForm_Load(object sender, EventArgs e)
        {
            StudentBindingSource.DataSource = ctx.Students.ToList();
            this.reportViewer1.RefreshReport();
        }
    }
}
