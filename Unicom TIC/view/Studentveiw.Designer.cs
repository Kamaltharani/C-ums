namespace Unicom_TIC.view
{
    partial class Studentveiw
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
            this.btnAttendance = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCourse = new System.Windows.Forms.Button();
            this.btnTimeTable = new System.Windows.Forms.Button();
            this.btnExam = new System.Windows.Forms.Button();
            this.btnMark = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAttendance
            // 
            this.btnAttendance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAttendance.Location = new System.Drawing.Point(32, 76);
            this.btnAttendance.Name = "btnAttendance";
            this.btnAttendance.Size = new System.Drawing.Size(75, 23);
            this.btnAttendance.TabIndex = 0;
            this.btnAttendance.Text = "attendance";
            this.btnAttendance.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "STUDENT VIEW";
            // 
            // btnCourse
            // 
            this.btnCourse.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCourse.Location = new System.Drawing.Point(260, 76);
            this.btnCourse.Name = "btnCourse";
            this.btnCourse.Size = new System.Drawing.Size(75, 23);
            this.btnCourse.TabIndex = 2;
            this.btnCourse.Text = "Course";
            this.btnCourse.UseVisualStyleBackColor = false;
            // 
            // btnTimeTable
            // 
            this.btnTimeTable.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTimeTable.Location = new System.Drawing.Point(488, 76);
            this.btnTimeTable.Name = "btnTimeTable";
            this.btnTimeTable.Size = new System.Drawing.Size(75, 23);
            this.btnTimeTable.TabIndex = 3;
            this.btnTimeTable.Text = "TimeTable";
            this.btnTimeTable.UseVisualStyleBackColor = false;
            // 
            // btnExam
            // 
            this.btnExam.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExam.Location = new System.Drawing.Point(140, 200);
            this.btnExam.Name = "btnExam";
            this.btnExam.Size = new System.Drawing.Size(75, 23);
            this.btnExam.TabIndex = 4;
            this.btnExam.Text = "Exam";
            this.btnExam.UseVisualStyleBackColor = false;
            // 
            // btnMark
            // 
            this.btnMark.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMark.Location = new System.Drawing.Point(384, 200);
            this.btnMark.Name = "btnMark";
            this.btnMark.Size = new System.Drawing.Size(75, 23);
            this.btnMark.TabIndex = 5;
            this.btnMark.Text = "Mark";
            this.btnMark.UseVisualStyleBackColor = false;
            // 
            // Studentveiw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 371);
            this.Controls.Add(this.btnMark);
            this.Controls.Add(this.btnExam);
            this.Controls.Add(this.btnTimeTable);
            this.Controls.Add(this.btnCourse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAttendance);
            this.Name = "Studentveiw";
            this.Text = "Studentveiw";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAttendance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCourse;
        private System.Windows.Forms.Button btnTimeTable;
        private System.Windows.Forms.Button btnExam;
        private System.Windows.Forms.Button btnMark;
    }
}