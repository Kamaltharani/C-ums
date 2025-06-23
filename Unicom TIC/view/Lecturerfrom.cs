using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unicom_TIC.MADELS;

namespace Unicom_TIC.view
{
    public partial class Lecturerfrom : Form
    {
        public Lecturerfrom()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Lecturer lec = new Lecturer
                {
                    LectureId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["LectureId"].Value),
                    LectureName = txtName.Text,
                    LectureEmail = txtEmail.Text,
                    LectureAddress = txtAddress.Text,
                    LectureAge = Convert.ToInt32(txtAge.Text),
                    LectureCourse = txtCourse.Text
                };
                controller.Update(lec);
                LoadData();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Lecturer lec = new Lecturer
            {
                LectureName = txtName.Text,
                LectureEmail = txtEmail.Text,
                LectureAddress = txtAddress.Text,
                LectureAge = Convert.ToInt32(txtAge.Text),
                LectureCourse = txtCourse.Text
            };
            controller.Add(lec);
            LoadData();
        }

        private void btnDelet_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["LectureId"].Value);
                controller.Delete(id);
                LoadData();
            }
        }
    }
}
