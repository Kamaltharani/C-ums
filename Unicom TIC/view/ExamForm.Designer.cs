namespace Unicom_TIC.Forms
{
    partial class ExamForm
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
            this.cmbSubject = new System.Windows.Forms.ComboBox();
            this.txtEmName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Exam = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbSubject
            // 
            this.cmbSubject.FormattingEnabled = true;
            this.cmbSubject.Location = new System.Drawing.Point(138, 56);
            this.cmbSubject.Name = "cmbSubject";
            this.cmbSubject.Size = new System.Drawing.Size(121, 21);
            this.cmbSubject.TabIndex = 0;
            // 
            // txtEmName
            // 
            this.txtEmName.Location = new System.Drawing.Point(138, 102);
            this.txtEmName.Name = "txtEmName";
            this.txtEmName.Size = new System.Drawing.Size(100, 20);
            this.txtEmName.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(59, 225);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(402, 209);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // Exam
            // 
            this.Exam.AutoSize = true;
            this.Exam.Location = new System.Drawing.Point(44, 59);
            this.Exam.Name = "Exam";
            this.Exam.Size = new System.Drawing.Size(72, 13);
            this.Exam.TabIndex = 4;
            this.Exam.Text = "Exam Subject";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Exam Name";
            // 
            // ExamForm
            // 
            this.ClientSize = new System.Drawing.Size(663, 371);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Exam);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtEmName);
            this.Controls.Add(this.cmbSubject);
            this.Name = "ExamForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddExam;
        private System.Windows.Forms.ComboBox cmbSubjects;
        private System.Windows.Forms.DataGridView dgvExams;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox txtExamName;
        private System.Windows.Forms.ComboBox cmbSubject;
        private System.Windows.Forms.TextBox txtEmName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Exam;
        private System.Windows.Forms.Label label4;
    }
}