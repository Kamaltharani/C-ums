namespace Unicom_TIC.view
{
    partial class Form1
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.studentname = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.StudentAge = new System.Windows.Forms.Label();
            this.studentadderss = new System.Windows.Forms.Label();
            this.studentemail = new System.Windows.Forms.Label();
            this.Coursename = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.btnUpdata = new System.Windows.Forms.Button();
            this.btndelet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAdd.Location = new System.Drawing.Point(9, 215);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // studentname
            // 
            this.studentname.AutoSize = true;
            this.studentname.Location = new System.Drawing.Point(12, 26);
            this.studentname.Name = "studentname";
            this.studentname.Size = new System.Drawing.Size(72, 13);
            this.studentname.TabIndex = 1;
            this.studentname.Text = "StudentName";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(157, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // StudentAge
            // 
            this.StudentAge.AutoSize = true;
            this.StudentAge.Location = new System.Drawing.Point(12, 62);
            this.StudentAge.Name = "StudentAge";
            this.StudentAge.Size = new System.Drawing.Size(63, 13);
            this.StudentAge.TabIndex = 3;
            this.StudentAge.Text = "StudentAge";
            // 
            // studentadderss
            // 
            this.studentadderss.AutoSize = true;
            this.studentadderss.Location = new System.Drawing.Point(12, 100);
            this.studentadderss.Name = "studentadderss";
            this.studentadderss.Size = new System.Drawing.Size(82, 13);
            this.studentadderss.TabIndex = 4;
            this.studentadderss.Text = "StudentAdderss";
            // 
            // studentemail
            // 
            this.studentemail.AutoSize = true;
            this.studentemail.Location = new System.Drawing.Point(12, 137);
            this.studentemail.Name = "studentemail";
            this.studentemail.Size = new System.Drawing.Size(69, 13);
            this.studentemail.TabIndex = 5;
            this.studentemail.Text = "StudentEmail";
            this.studentemail.Click += new System.EventHandler(this.label4_Click);
            // 
            // Coursename
            // 
            this.Coursename.AutoSize = true;
            this.Coursename.Location = new System.Drawing.Point(16, 177);
            this.Coursename.Name = "Coursename";
            this.Coursename.Size = new System.Drawing.Size(68, 13);
            this.Coursename.TabIndex = 6;
            this.Coursename.Text = "CourseName";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(157, 59);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(157, 100);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(157, 137);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(157, 170);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 10;
            // 
            // btnUpdata
            // 
            this.btnUpdata.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnUpdata.Location = new System.Drawing.Point(117, 215);
            this.btnUpdata.Name = "btnUpdata";
            this.btnUpdata.Size = new System.Drawing.Size(75, 23);
            this.btnUpdata.TabIndex = 11;
            this.btnUpdata.Text = "UPdata";
            this.btnUpdata.UseVisualStyleBackColor = false;
            // 
            // btndelet
            // 
            this.btndelet.BackColor = System.Drawing.SystemColors.Highlight;
            this.btndelet.Location = new System.Drawing.Point(223, 215);
            this.btndelet.Name = "btndelet";
            this.btndelet.Size = new System.Drawing.Size(75, 23);
            this.btndelet.TabIndex = 12;
            this.btndelet.Text = "delet";
            this.btndelet.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 371);
            this.Controls.Add(this.btndelet);
            this.Controls.Add(this.btnUpdata);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Coursename);
            this.Controls.Add(this.studentemail);
            this.Controls.Add(this.studentadderss);
            this.Controls.Add(this.StudentAge);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.studentname);
            this.Controls.Add(this.btnAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label studentname;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label StudentAge;
        private System.Windows.Forms.Label studentadderss;
        private System.Windows.Forms.Label studentemail;
        private System.Windows.Forms.Label Coursename;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button btnUpdata;
        private System.Windows.Forms.Button btndelet;
    }
}