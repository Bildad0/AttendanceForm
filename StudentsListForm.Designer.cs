
namespace AttendanceForm
{
    partial class StudentsListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.studentList = new System.Windows.Forms.DataGridView();
            this.markAttendance = new System.Windows.Forms.Button();
            this.addStudent = new System.Windows.Forms.Button();
            this.winFormDBDataSet = new AttendanceForm.WinFormDBDataSet();
            this.winFormDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.studentList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winFormDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winFormDBDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // studentList
            // 
            this.studentList.AutoGenerateColumns = false;
            this.studentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentList.DataSource = this.winFormDBDataSetBindingSource;
            this.studentList.Location = new System.Drawing.Point(12, 12);
            this.studentList.Name = "studentList";
            this.studentList.Size = new System.Drawing.Size(776, 373);
            this.studentList.TabIndex = 0;
            this.studentList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentList_CellContentClick);
            // 
            // markAttendance
            // 
            this.markAttendance.Location = new System.Drawing.Point(46, 405);
            this.markAttendance.Name = "markAttendance";
            this.markAttendance.Size = new System.Drawing.Size(103, 33);
            this.markAttendance.TabIndex = 1;
            this.markAttendance.Text = "Mark Attendance";
            this.markAttendance.UseVisualStyleBackColor = true;
            this.markAttendance.Click += new System.EventHandler(this.markAttendance_Click);
            // 
            // addStudent
            // 
            this.addStudent.Location = new System.Drawing.Point(603, 405);
            this.addStudent.Name = "addStudent";
            this.addStudent.Size = new System.Drawing.Size(100, 33);
            this.addStudent.TabIndex = 2;
            this.addStudent.Text = "Add/Edit Student";
            this.addStudent.UseVisualStyleBackColor = true;
            this.addStudent.Click += new System.EventHandler(this.addStudent_Click);
            // 
            // winFormDBDataSet
            // 
            this.winFormDBDataSet.DataSetName = "WinFormDBDataSet";
            this.winFormDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // winFormDBDataSetBindingSource
            // 
            this.winFormDBDataSetBindingSource.DataSource = this.winFormDBDataSet;
            this.winFormDBDataSetBindingSource.Position = 0;
            // 
            // StudentsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addStudent);
            this.Controls.Add(this.markAttendance);
            this.Controls.Add(this.studentList);
            this.Name = "StudentsListForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.StudentsList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winFormDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winFormDBDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView studentList;
        private System.Windows.Forms.Button markAttendance;
        private System.Windows.Forms.Button addStudent;
        private System.Windows.Forms.BindingSource winFormDBDataSetBindingSource;
        private AttendanceForm.WinFormDBDataSet winFormDBDataSet;
    }
}

