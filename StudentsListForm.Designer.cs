
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
            this.studentList = new System.Windows.Forms.DataGridView();
            this.markAttendance = new System.Windows.Forms.Button();
            this.addStudent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.studentList)).BeginInit();
            this.SuspendLayout();
            // 
            // studentList
            // 
            this.studentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentList.Location = new System.Drawing.Point(12, 12);
            this.studentList.Name = "studentList";
            this.studentList.Size = new System.Drawing.Size(776, 373);
            this.studentList.TabIndex = 0;
            // 
            // markAttendance
            // 
            this.markAttendance.Location = new System.Drawing.Point(46, 405);
            this.markAttendance.Name = "markAttendance";
            this.markAttendance.Size = new System.Drawing.Size(103, 33);
            this.markAttendance.TabIndex = 1;
            this.markAttendance.Text = "Mark Attendance";
            this.markAttendance.UseVisualStyleBackColor = true;
            // 
            // addStudent
            // 
            this.addStudent.Location = new System.Drawing.Point(603, 405);
            this.addStudent.Name = "addStudent";
            this.addStudent.Size = new System.Drawing.Size(100, 33);
            this.addStudent.TabIndex = 2;
            this.addStudent.Text = "Add/Edit Student";
            this.addStudent.UseVisualStyleBackColor = true;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView studentList;
        private System.Windows.Forms.Button markAttendance;
        private System.Windows.Forms.Button addStudent;
    }
}

