using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Unicom_TIC.Controllers;

namespace Unicom_TIC.view
{
    public partial class Form1 : Form
    {
        private object txtAddress;
        private object txtSectionId;
        private object txtName;
        private object txtId;

        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private string GetTxtAddress()
        {
            return (string)txtAddress;
        }

        private string GetTxtName()
        {
            return (string)txtName;
        }

        private void btnAdd_Click(object sender, EventArgs e, string txtAddress, string txtName)
        {
            // Create new Student object from textboxes
            Student student = new Student
            {
                StaudentName = txtName,
                StudentAddress = txtAddress,
                SectionId = Convert.ToInt32(txtSectionId)  // make sure input is valid int
            };

            using (var conn = DbConfig.GetConnection())
            {
                string query = @"
                        INSERT INTO Students (Name, Address, SectionId) 
                        VALUES (@Name, @Address, @SectionId)";

                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", student.StaudentName);
                    cmd.Parameters.AddWithValue("@Address", student.StudentAddress);
                    cmd.Parameters.AddWithValue("@SectionId", student.SectionId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void UpdateStudent(Student student)
        {
            using (var conn = DbConfig.GetConnection())
            {
                string query = @"


            UPDATE Students 
            SET Name = @Name, Address = @Address, SectionId = @SectionId
            WHERE Id = @Id";

                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", student.StaudentName);
                    cmd.Parameters.AddWithValue("@Address", student.StudentAddress);
                    cmd.Parameters.AddWithValue("@SectionId", student.SectionId);
                    cmd.Parameters.AddWithValue("@Id", student.StudentId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteStudent(int studentId)
        {
            using (var conn = DbConfig.GetConnection())
            { 
                string query = "DELETE FROM Students WHERE Id = @Id";

                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", studentId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

    }
}


