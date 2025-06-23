using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Data.SQLite;
using Unicom_TIC.MODELS;

namespace Unicom_TIC.CONTROLLER
{
    public class TimetableController
    {
        private string connectionString = "Data Source=unicomtic.db;Version=3;";

        public void AddTimetable(Timetable t)
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Timetable (CourseName, LecturerName, Day, Time, Room) VALUES (@CourseName, @LecturerName, @Day, @Time, @Room)";
                var cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@CourseName", t.CourseName);
                cmd.Parameters.AddWithValue("@LecturerName", t.LecturerName);
                cmd.Parameters.AddWithValue("@Day", t.Day);
                cmd.Parameters.AddWithValue("@Time", t.Time);
                cmd.Parameters.AddWithValue("@Room", t.Room);
                cmd.ExecuteNonQuery();
            }
        }

        public List<Timetable> GetAll()
        {
            List<Timetable> list = new List<Timetable>();

            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Timetable";
                var cmd = new SQLiteCommand(query, conn);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new Timetable
                    {
                        Id = int.Parse(reader["Id"].ToString()),
                        CourseName = reader["CourseName"].ToString(),
                        LecturerName = reader["LecturerName"].ToString(),
                        Day = reader["Day"].ToString(),
                        Time = reader["Time"].ToString(),
                        Room = reader["Room"].ToString()
                    });
                }
            }

            return list;
        }

        public void DeleteTimetable(int id)
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM Timetable WHERE Id = @Id";
                var cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}

    
