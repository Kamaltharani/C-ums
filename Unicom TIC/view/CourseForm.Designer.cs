namespace Unicom_TIC.view
{
    partial class CourseForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCourses = new System.Windows.Forms.ComboBox();
            this.btnAddSubject = new System.Windows.Forms.Button();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.txtCourse = new System.Windows.Forms.TextBox();
            this.Subject = new System.Windows.Forms.Label();
            this.labcouname = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(162, 241);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(343, 97);
            this.dataGridView1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "course selection";
            // 
            // cmbCourses
            // 
            this.cmbCourses.FormattingEnabled = true;
            this.cmbCourses.Location = new System.Drawing.Point(270, 162);
            this.cmbCourses.Name = "cmbCourses";
            this.cmbCourses.Size = new System.Drawing.Size(121, 21);
            this.cmbCourses.TabIndex = 16;
            // 
            // btnAddSubject
            // 
            this.btnAddSubject.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAddSubject.Location = new System.Drawing.Point(305, 199);
            this.btnAddSubject.Name = "btnAddSubject";
            this.btnAddSubject.Size = new System.Drawing.Size(75, 23);
            this.btnAddSubject.TabIndex = 15;
            this.btnAddSubject.Text = "Ubdata";
            this.btnAddSubject.UseVisualStyleBackColor = false;
            this.btnAddSubject.Click += new System.EventHandler(this.btnAddSubject_Click);
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(270, 99);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(157, 20);
            this.txtSubject.TabIndex = 14;
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAddCourse.Location = new System.Drawing.Point(167, 199);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(75, 23);
            this.btnAddCourse.TabIndex = 13;
            this.btnAddCourse.Text = "Add";
            this.btnAddCourse.UseVisualStyleBackColor = false;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // txtCourse
            // 
            this.txtCourse.Location = new System.Drawing.Point(270, 32);
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.Size = new System.Drawing.Size(157, 20);
            this.txtCourse.TabIndex = 12;
            // 
            // Subject
            // 
            this.Subject.AutoSize = true;
            this.Subject.Location = new System.Drawing.Point(158, 106);
            this.Subject.Name = "Subject";
            this.Subject.Size = new System.Drawing.Size(70, 13);
            this.Subject.TabIndex = 11;
            this.Subject.Text = "subject name";
            // 
            // labcouname
            // 
            this.labcouname.AutoSize = true;
            this.labcouname.Location = new System.Drawing.Point(158, 32);
            this.labcouname.Name = "labcouname";
            this.labcouname.Size = new System.Drawing.Size(67, 13);
            this.labcouname.TabIndex = 10;
            this.labcouname.Text = "couresName";
            // 
            // CourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 371);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCourses);
            this.Controls.Add(this.btnAddSubject);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.btnAddCourse);
            this.Controls.Add(this.txtCourse);
            this.Controls.Add(this.Subject);
            this.Controls.Add(this.labcouname);
            this.Name = "CourseForm";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.CourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCourses;
        private System.Windows.Forms.Button btnAddSubject;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.TextBox txtCourse;
        private System.Windows.Forms.Label Subject;
        private System.Windows.Forms.Label labcouname;
    }
}