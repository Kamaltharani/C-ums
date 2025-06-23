using System;
using System.Collections.Generic;
using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Unicom_TIC
{
    public partial class AttendanceForm : Form
    {
        SQLiteConnection con = new SQLiteConnection("Data Source=ums.db");

        public AttendanceForm()
        {
            InitializeComponent();
            LoadStudents();
            LoadCourses();
        }

        private void LoadStudents()
        {
            con.Open();
            var cmd = new SQLiteCommand("SELECT StudentID, StudentName FROM Students", con);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cmdStudent.Items.Add(new { Text = reader["StudentName"].ToString(), Value = reader["StudentID"] });
            }
            con.Close();
        }

        private void LoadCourses()
        {
            con.Open();
            var cmd = new SQLiteCommand("SELECT CourseID, CourseName FROM Courses", con);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cmdCourse.Items.Add(new { Text = reader["CourseName"].ToString(), Value = reader["CourseID"] });
            }
            con.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmdStudent.SelectedIndex < 0 || cmdCourse.SelectedIndex < 0)
            {
                MessageBox.Show("Please select student and course.");
                return;
            }

            string status = rdoPresent.Checked ? "Present" : "Absent";
            string date = dtpDate.Value.ToString("yyyy-MM-dd");

            con.Open();
            var cmd = new SQLiteCommand("INSERT INTO Attendance (StudentID, CourseID, Date, Status) VALUES (@sid, @cid, @date, @status)", con);
            cmd.Parameters.AddWithValue("@sid", ((dynamic)cmdStudent.SelectedItem).Value);
            cmd.Parameters.AddWithValue("@cid", ((dynamic)cmdCourse.SelectedItem).Value);
            cmd.Parameters.AddWithValue("@date", date);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Attendance saved.");
        }
    }
}
