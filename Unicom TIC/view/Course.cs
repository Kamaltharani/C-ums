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
    public partial class Course : Form
    {
        public Course()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string courseName = txtCourse.Text;
            if (!string.IsNullOrEmpty(courseName))
            {
                CourseController.Items.Add(courseName);
                txtCourse.Clear();
            }
            else
            {
                MessageBox.Show("please entre acourse.");
                
            }
        }

        private void btnUpdata_Click(object sender, EventArgs e)
        {
            if (txtCourse.SelectedIndex != -1)
            {
                string updatedCourseName = txtCourse.Text;

                if (!string.IsNullOrEmpty(updatedCourseName))
                {
                    // Update the selected item in ListBox
                    txtCourse.Items[txtCourse.SelectedIndex] = updatedCourseName;

                    // Clear the TextBox after update
                    txtCourse.Clear();

                    MessageBox.Show("Course updated successfully!");
                }
                else
                {
                    MessageBox.Show("Please enter a course name to update.");
                }
            }
            else
            {
                MessageBox.Show("Please select a course to update.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtCourse.SelectedIndex != -1)
            {

                txtCourse.Items.RemoveAt(txtCourse.SelectedIndex);

                MessageBox.Show("Selected course deleted successfully!");
            }
            else
            {
                MessageBox.Show("Please select a course to delete.");
            }
        }

        private void txtCourse_TextChanged(object sender, EventArgs e)
        {

        }
    }
 }

