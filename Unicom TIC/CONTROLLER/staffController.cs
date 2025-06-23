using System.Collections.Generic;
using System.Data.SQLite;
using Unicom_TIC.MADELS;
using Unicom_TIC.MODELS;

namespace Unicom_TIC.CONTROLLER
{
    public class StaffController
    {
        private string connectionString = "Data Source=unicomtic.db;Version=3;";

        public List<Staff> GetAll()
        {
            List<Staff> staffList = new List<Staff>();
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Staff";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        staffList.Add(new Staff
                        {
                            StaffId = int.Parse(reader["StaffId"].ToString()),
                            Name = reader["Name"].ToString(),
                            Position = reader["Position"].ToString(),
                            Contact = reader["Contact"].ToString()
                        });
                    }
                }
            }
            return staffList;
        }

        public void Add(Staff staff)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Staff (Name, Position, Contact) VALUES (@Name, @Position, @Contact)";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", staff.Name);
                    cmd.Parameters.AddWithValue("@Position", staff.Position);
                    cmd.Parameters.AddWithValue("@Contact", staff.Contact);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Update(Staff staff)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE Staff SET Name = @Name, Position = @Position, Contact = @Contact WHERE StaffId = @StaffId";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", staff.Name);
                    cmd.Parameters.AddWithValue("@Position", staff.Position);
                    cmd.Parameters.AddWithValue("@Contact", staff.Contact);
                    cmd.Parameters.AddWithValue("@StaffId", staff.StaffId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Delete(int staffId)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM Staff WHERE StaffId = @StaffId";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StaffId", staffId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}


