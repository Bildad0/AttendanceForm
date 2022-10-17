
namespace AttendanceForm
{
    partial class StudentDataEntryForm
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
            this.name = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.Label();
            this.studentName = new System.Windows.Forms.TextBox();
            this.studentAge = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.dataGridViewDataEntry = new System.Windows.Forms.DataGridView();
            this.idtextBox = new System.Windows.Forms.TextBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataEntry)).BeginInit();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(43, 9);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(88, 13);
            this.name.TabIndex = 0;
            this.name.Text = "Student\'s Name :";
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.Location = new System.Drawing.Point(320, 9);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(79, 13);
            this.age.TabIndex = 1;
            this.age.Text = "Student\'s Age :";
            // 
            // studentName
            // 
            this.studentName.Location = new System.Drawing.Point(137, 6);
            this.studentName.Name = "studentName";
            this.studentName.Size = new System.Drawing.Size(177, 20);
            this.studentName.TabIndex = 2;
            // 
            // studentAge
            // 
            this.studentAge.Location = new System.Drawing.Point(405, 6);
            this.studentAge.Name = "studentAge";
            this.studentAge.Size = new System.Drawing.Size(88, 20);
            this.studentAge.TabIndex = 3;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(519, 3);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 4;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(609, 4);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(75, 23);
            this.edit.TabIndex = 5;
            this.edit.Text = "Edit";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // dataGridViewDataEntry
            // 
            this.dataGridViewDataEntry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDataEntry.Location = new System.Drawing.Point(15, 58);
            this.dataGridViewDataEntry.Name = "dataGridViewDataEntry";
            this.dataGridViewDataEntry.Size = new System.Drawing.Size(773, 351);
            this.dataGridViewDataEntry.TabIndex = 6;
            this.dataGridViewDataEntry.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GetCellData);
            // 
            // idtextBox
            // 
            this.idtextBox.Location = new System.Drawing.Point(12, 6);
            this.idtextBox.Name = "idtextBox";
            this.idtextBox.ReadOnly = true;
            this.idtextBox.Size = new System.Drawing.Size(22, 20);
            this.idtextBox.TabIndex = 7;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(690, 6);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 8;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // StudentDataEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.idtextBox);
            this.Controls.Add(this.dataGridViewDataEntry);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.save);
            this.Controls.Add(this.studentAge);
            this.Controls.Add(this.studentName);
            this.Controls.Add(this.age);
            this.Controls.Add(this.name);
            this.Name = "StudentDataEntryForm";
            this.Text = "StudentDataEntryForm";
            this.Load += new System.EventHandler(this.StudentDataEntryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataEntry)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.TextBox studentName;
        private System.Windows.Forms.TextBox studentAge;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.DataGridView dataGridViewDataEntry;
        private System.Windows.Forms.TextBox idtextBox;
        private System.Windows.Forms.Button deleteBtn;
    }
}