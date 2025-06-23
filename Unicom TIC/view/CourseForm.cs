using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unicom_TIC.CONTROLLER;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Unicom_TIC.view
{
    public partial class CourseForm : Form
    {
        public CourseForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private object CourseControlleAdd(string courseName)
        {
            throw new NotImplementedException();
        }

        private void btnUpdata_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtCourse.Text=="")
            {
                MessageBox.Show("Selected course deleted successfully!");
            }
            else
            {
                MessageBox.Show("Please select a course to delete.");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CourseForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            string course = txtCourseName.Text;
            string subject = txtSubjectName.Text;
            string courseSel = cmbCourseSelection.Selectedm?.ToString();
            
            if (string.IsNullOrWhiteSpace(course) || string.IsNullOrWhiteSpace(subject) || coursese1 == null)
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }
            dataGridView1.Rows.Add(course, subject, courseSel);
            ClearInputs();
        }

        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                dataGridView1.CurrentRow.Cells[0].Value = txtCourseName.Text;
                dataGridView1.CurrentRow.Cells[1].Value = txtSubject.Text;
                dataGridView1.CurrentRow.Cells[2].Value = cmdCourseSelection.Selectedltem?.ToString();
                Clearfields();

            }
        }
    }
 }

