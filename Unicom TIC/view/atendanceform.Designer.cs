namespace Unicom_TIC
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
            this.cmdStudent = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.rdoPresent = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmdCourse = new System.Windows.Forms.ComboBox();
            this.rdoAbsent = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // cmdStudent
            // 
            this.cmdStudent.FormattingEnabled = true;
            this.cmdStudent.Location = new System.Drawing.Point(142, 47);
            this.cmdStudent.Name = "cmdStudent";
            this.cmdStudent.Size = new System.Drawing.Size(121, 21);
            this.cmdStudent.TabIndex = 0;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(76, 126);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 1;
            // 
            // rdoPresent
            // 
            this.rdoPresent.AutoSize = true;
            this.rdoPresent.Location = new System.Drawing.Point(76, 163);
            this.rdoPresent.Name = "rdoPresent";
            this.rdoPresent.Size = new System.Drawing.Size(61, 17);
            this.rdoPresent.TabIndex = 2;
            this.rdoPresent.TabStop = true;
            this.rdoPresent.Text = "Present";
            this.rdoPresent.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSave.Location = new System.Drawing.Point(142, 246);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Student Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Course Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Status";
            // 
            // cmdCourse
            // 
            this.cmdCourse.FormattingEnabled = true;
            this.cmdCourse.Location = new System.Drawing.Point(142, 83);
            this.cmdCourse.Name = "cmdCourse";
            this.cmdCourse.Size = new System.Drawing.Size(121, 21);
            this.cmdCourse.TabIndex = 10;
            // 
            // rdoAbsent
            // 
            this.rdoAbsent.AutoSize = true;
            this.rdoAbsent.Location = new System.Drawing.Point(191, 163);
            this.rdoAbsent.Name = "rdoAbsent";
            this.rdoAbsent.Size = new System.Drawing.Size(58, 17);
            this.rdoAbsent.TabIndex = 11;
            this.rdoAbsent.TabStop = true;
            this.rdoAbsent.Text = "Absent";
            this.rdoAbsent.UseVisualStyleBackColor = true;
            // 
            // atendanceform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 371);
            this.Controls.Add(this.rdoAbsent);
            this.Controls.Add(this.cmdCourse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rdoPresent);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.cmdStudent);
            this.Name = "atendanceform";
            this.Text = "atendanceform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmdStudent;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.RadioButton rdoPresent;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmdCourse;
        private System.Windows.Forms.RadioButton rdoAbsent;
    }
}