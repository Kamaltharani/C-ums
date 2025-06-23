using System;
using System.Linq;
using System.Windows.Forms;
using Unicom_TIC.CONTROLLER;
using Unicom_TIC.Controllers;
using Unicom_TIC.Models;

namespace Unicom_TIC.Forms
{
    public partial class ExamForm : Form
    {
        private readonly CONTROLLER.SubjectController subjectCtrl = new CONTROLLER.SubjectController();
        private readonly ExamController examCtrl = new ExamController();

        public ExamForm()
        {
            InitializeComponent();
            LoadSubjects();        }

        private void LoadSubjects()
        {
            cmbSubjects.DataSource = subjectCtrl.GetAllSubjects();
            cmbSubjects.DisplayMember = "SubjectName";
            cmbSubjects.ValueMember = "SubjectId";
        }

       

        private void btnAddExam_Click(object sender, EventArgs e)
        {
            if (cmbSubjects.SelectedItem is Subject selectedSubject)
            {
                examCtrl.AddExam(selectedSubject.SubjectId, txtExamName.Text);
               
            }
        }

        private void ExamForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string subject = cmdExamSubject.Text;
            string examName = txtExamName.Text;

            if (!string.IsNullOrWhiteSpace(subject) && !string.IsNullOrWhiteSpace(examName))
            {
                dataGridView1.Rows.Add(subject, examName);
                cmbExamsubject.selectadIndex = -1;
                txtExamName.clear();
            }
            else
            {
                MessageBox.Show("please enter both subject and exam name.");
            }
        }
    }
}
