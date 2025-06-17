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
            this.labcouname = new System.Windows.Forms.Label();
            this.Subject = new System.Windows.Forms.Label();
            this.txtCourse = new System.Windows.Forms.TextBox();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.btnAddSubject = new System.Windows.Forms.Button();
            this.cmbCourses = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labcouname
            // 
            this.labcouname.AutoSize = true;
            this.labcouname.Location = new System.Drawing.Point(48, 33);
            this.labcouname.Name = "labcouname";
            this.labcouname.Size = new System.Drawing.Size(67, 13);
            this.labcouname.TabIndex = 0;
            this.labcouname.Text = "couresName";
            // 
            // Subject
            // 
            this.Subject.AutoSize = true;
            this.Subject.Location = new System.Drawing.Point(48, 107);
            this.Subject.Name = "Subject";
            this.Subject.Size = new System.Drawing.Size(70, 13);
            this.Subject.TabIndex = 1;
            this.Subject.Text = "subject name";
            // 
            // txtCourse
            // 
            this.txtCourse.Location = new System.Drawing.Point(160, 33);
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.Size = new System.Drawing.Size(157, 20);
            this.txtCourse.TabIndex = 2;
            this.txtCourse.TextChanged += new System.EventHandler(this.txtCourse_TextChanged);
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAddCourse.Location = new System.Drawing.Point(57, 200);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(75, 23);
            this.btnAddCourse.TabIndex = 3;
            this.btnAddCourse.Text = "Add";
            this.btnAddCourse.UseVisualStyleBackColor = false;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(160, 100);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(157, 20);
            this.txtSubject.TabIndex = 4;
            // 
            // btnAddSubject
            // 
            this.btnAddSubject.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAddSubject.Location = new System.Drawing.Point(195, 200);
            this.btnAddSubject.Name = "btnAddSubject";
            this.btnAddSubject.Size = new System.Drawing.Size(75, 23);
            this.btnAddSubject.TabIndex = 5;
            this.btnAddSubject.Text = "Ubdata";
            this.btnAddSubject.UseVisualStyleBackColor = false;
            this.btnAddSubject.Click += new System.EventHandler(this.btnUpdata_Click);
            // 
            // cmbCourses
            // 
            this.cmbCourses.FormattingEnabled = true;
            this.cmbCourses.Location = new System.Drawing.Point(160, 163);
            this.cmbCourses.Name = "cmbCourses";
            this.cmbCourses.Size = new System.Drawing.Size(121, 21);
            this.cmbCourses.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "course selection";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(52, 242);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(343, 97);
            this.dataGridView1.TabIndex = 9;
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labcouname;
        private System.Windows.Forms.Label Subject;
        private System.Windows.Forms.TextBox txtCourse;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Button btnAddSubject;
        private System.Windows.Forms.ComboBox cmbCourses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}