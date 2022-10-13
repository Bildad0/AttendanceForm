
namespace AttendanceForm
{
    partial class AttendanceForm
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
            this.classLable = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.classComboBox = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.attendanceBtn = new System.Windows.Forms.Button();
            this.lessonDate = new System.Windows.Forms.DateTimePicker();
            this.attendanceSubmitBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // classLable
            // 
            this.classLable.AutoSize = true;
            this.classLable.Location = new System.Drawing.Point(13, 13);
            this.classLable.Name = "classLable";
            this.classLable.Size = new System.Drawing.Size(65, 13);
            this.classLable.TabIndex = 0;
            this.classLable.Text = "Select Class";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(279, 13);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(63, 13);
            this.dateLabel.TabIndex = 1;
            this.dateLabel.Text = "Select Date";
            // 
            // classComboBox
            // 
            this.classComboBox.FormattingEnabled = true;
            this.classComboBox.Items.AddRange(new object[] {
            "Lesson One",
            "Lesson Two",
            "Lesson Three"});
            this.classComboBox.Location = new System.Drawing.Point(16, 29);
            this.classComboBox.Name = "classComboBox";
            this.classComboBox.Size = new System.Drawing.Size(121, 21);
            this.classComboBox.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 310);
            this.dataGridView1.TabIndex = 4;
            // 
            // attendanceBtn
            // 
            this.attendanceBtn.Location = new System.Drawing.Point(613, 26);
            this.attendanceBtn.Name = "attendanceBtn";
            this.attendanceBtn.Size = new System.Drawing.Size(117, 24);
            this.attendanceBtn.TabIndex = 5;
            this.attendanceBtn.Text = "Attendance Report";
            this.attendanceBtn.UseVisualStyleBackColor = true;
            // 
            // lessonDate
            // 
            this.lessonDate.Location = new System.Drawing.Point(282, 30);
            this.lessonDate.Name = "lessonDate";
            this.lessonDate.Size = new System.Drawing.Size(200, 20);
            this.lessonDate.TabIndex = 6;
            // 
            // attendanceSubmitBtn
            // 
            this.attendanceSubmitBtn.Location = new System.Drawing.Point(613, 415);
            this.attendanceSubmitBtn.Name = "attendanceSubmitBtn";
            this.attendanceSubmitBtn.Size = new System.Drawing.Size(85, 23);
            this.attendanceSubmitBtn.TabIndex = 7;
            this.attendanceSubmitBtn.Text = "Submit";
            this.attendanceSubmitBtn.UseVisualStyleBackColor = true;
            // 
            // AttendanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.attendanceSubmitBtn);
            this.Controls.Add(this.lessonDate);
            this.Controls.Add(this.attendanceBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.classComboBox);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.classLable);
            this.Name = "AttendanceForm";
            this.Text = "AttendanceForm";
            this.Load += new System.EventHandler(this.AttendanceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label classLable;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.ComboBox classComboBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button attendanceBtn;
        private System.Windows.Forms.DateTimePicker lessonDate;
        private System.Windows.Forms.Button attendanceSubmitBtn;
    }
}