namespace Unicom_TIC.view
{
    partial class Subject
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
            this.SubjectName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.subjectId = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnUpdata = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SubjectName
            // 
            this.SubjectName.AutoSize = true;
            this.SubjectName.Location = new System.Drawing.Point(27, 22);
            this.SubjectName.Name = "SubjectName";
            this.SubjectName.Size = new System.Drawing.Size(74, 13);
            this.SubjectName.TabIndex = 1;
            this.SubjectName.Text = "Subject Name";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAdd.Location = new System.Drawing.Point(30, 203);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(116, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // subjectId
            // 
            this.subjectId.AutoSize = true;
            this.subjectId.Location = new System.Drawing.Point(27, 81);
            this.subjectId.Name = "subjectId";
            this.subjectId.Size = new System.Drawing.Size(50, 13);
            this.subjectId.TabIndex = 4;
            this.subjectId.Text = "subjectId";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(116, 74);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // btnUpdata
            // 
            this.btnUpdata.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnUpdata.Location = new System.Drawing.Point(153, 203);
            this.btnUpdata.Name = "btnUpdata";
            this.btnUpdata.Size = new System.Drawing.Size(75, 23);
            this.btnUpdata.TabIndex = 6;
            this.btnUpdata.Text = "Updata";
            this.btnUpdata.UseVisualStyleBackColor = false;
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.SystemColors.Highlight;
            this.btndelete.Location = new System.Drawing.Point(261, 203);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 7;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            // 
            // Subject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 371);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnUpdata);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.subjectId);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.SubjectName);
            this.Name = "Subject";
            this.Text = "Form8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SubjectName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label subjectId;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnUpdata;
        private System.Windows.Forms.Button btndelete;
    }
}