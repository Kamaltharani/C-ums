using System;
using System.Collections.Generic;
using System.Data.SQLite;
using Unicom_TIC.Controllers;
using Unicom_TIC.Repositories;

namespace Unicom_TIC.CONTROLLER
{
    internal class StudentController
    {
        public StudentController() { }

        public List<Student> AllStudents()
        {
            var students = new List<Student>();

            using (var conn = DbConfig.GetConnection())
            {
                var cmd = new SQLiteCommand(@"
                    SELECT s.Id, s.Name, s.Address, s.SectionId, sec.Name AS SectionName
                    FROM Students s
                    LEFT JOIN q sec ON s.couresId = sec.Id", conn);

                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Student student = new Student
                    {
                        StudentId = reader.GetInt32(0),
                        StaudentName = reader.GetString(1),
                        StudentAddress = reader.GetString(2),
                        // You can add SectionId and SectionName if needed
                    };
                    students.Add(student);
                }
            }

            return students; // ✅ Now always returns
        }
    }
}
