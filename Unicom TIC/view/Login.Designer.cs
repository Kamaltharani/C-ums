namespace Unicom_TIC.view
{
    partial class Login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStaff = new System.Windows.Forms.Button();
            this.bntStudent = new System.Windows.Forms.Button();
            this.btnLecture = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnx = new System.Windows.Forms.Button();
            this.main = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnStaff);
            this.panel1.Controls.Add(this.bntStudent);
            this.panel1.Controls.Add(this.btnLecture);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(121, 450);
            this.panel1.TabIndex = 0;
            // 
            // btnStaff
            // 
            this.btnStaff.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnStaff.Location = new System.Drawing.Point(24, 209);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(75, 23);
            this.btnStaff.TabIndex = 3;
            this.btnStaff.Text = "Staff";
            this.btnStaff.UseVisualStyleBackColor = false;
            // 
            // bntStudent
            // 
            this.bntStudent.BackColor = System.Drawing.SystemColors.Highlight;
            this.bntStudent.Location = new System.Drawing.Point(24, 161);
            this.bntStudent.Name = "bntStudent";
            this.bntStudent.Size = new System.Drawing.Size(75, 23);
            this.bntStudent.TabIndex = 2;
            this.bntStudent.Text = "Student ";
            this.bntStudent.UseVisualStyleBackColor = false;
            // 
            // btnLecture
            // 
            this.btnLecture.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLecture.Location = new System.Drawing.Point(24, 103);
            this.btnLecture.Name = "btnLecture";
            this.btnLecture.Size = new System.Drawing.Size(75, 23);
            this.btnLecture.TabIndex = 1;
            this.btnLecture.Text = "lecuture";
            this.btnLecture.UseVisualStyleBackColor = false;
            this.btnLecture.Click += new System.EventHandler(this.btnLecture_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.btnx);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(121, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(679, 40);
            this.panel2.TabIndex = 1;
            // 
            // btnx
            // 
            this.btnx.BackColor = System.Drawing.Color.Red;
            this.btnx.Location = new System.Drawing.Point(643, 3);
            this.btnx.Name = "btnx";
            this.btnx.Size = new System.Drawing.Size(24, 23);
            this.btnx.TabIndex = 4;
            this.btnx.Text = " x";
            this.btnx.UseVisualStyleBackColor = false;
            // 
            // main
            // 
            this.main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main.Location = new System.Drawing.Point(121, 40);
            this.main.Name = "main";
            this.main.Size = new System.Drawing.Size(679, 410);
            this.main.TabIndex = 2;
            this.main.Paint += new System.Windows.Forms.PaintEventHandler(this.main_Paint);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.main);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Login";
            this.Text = "lOGIN";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnStaff;
        private System.Windows.Forms.Button bntStudent;
        private System.Windows.Forms.Button btnLecture;
        private System.Windows.Forms.Button btnx;
        private System.Windows.Forms.Panel main;
    }
}