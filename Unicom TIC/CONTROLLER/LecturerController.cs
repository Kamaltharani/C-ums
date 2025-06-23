using System;
using System.Collections.Generic;
using System.Data.SQLite;
using Unicom_TIC.MADELS;

public class LectureController
{
    private string connectionString = "Data Source=MyDatabase.sqlite;Version=3;";

    public LectureController()
    {
        CreateLectureTable();
    }

    private void CreateLectureTable()
    {
        using var connection = new SQLiteConnection(connectionString);
        connection.Open();

        string createTableQuery = @"
            CREATE TABLE IF NOT EXISTS Lecture (
                LectureId INTEGER PRIMARY KEY AUTOINCREMENT,
                LectureName TEXT NOT NULL,
                LectureEmail TEXT,
                LectureAddress TEXT,
                LectureAge INTEGER,
                LectureCourse TEXT
            )";

        using var command = new SQLiteCommand(createTableQuery, connection);
        command.ExecuteNonQuery();
    }

    public void AddLecture(Lecture lecture)
    {
        using var connection = new SQLiteConnection(connectionString);
        connection.Open();

        string insertQuery = @"
            INSERT INTO Lecture (LectureName, LectureEmail, LectureAddress, LectureAge, LectureCourse)
            VALUES (@name, @email, @address, @age, @course)";

        using var command = new SQLiteCommand(insertQuery, connection);
        command.Parameters.AddWithValue("@name", lecture.LectureName);
        command.Parameters.AddWithValue("@email", lecture.LectureEmail ?? (object)DBNull.Value);
        command.Parameters.AddWithValue("@address", lecture.LectureAddress ?? (object)DBNull.Value);
        command.Parameters.AddWithValue("@age", lecture.LectureAge);
        command.Parameters.AddWithValue("@course", lecture.LectureCourse ?? (object)DBNull.Value);

        command.ExecuteNonQuery();
    }

    public List<Lecture> GetAllLectures()
    {
        var lectures = new List<Lecture>();

        using var connection = new SQLiteConnection(connectionString);
        connection.Open();

        string selectQuery = "SELECT * FROM Lecture";

        using var command = new SQLiteCommand(selectQuery, connection);
        using var reader = command.ExecuteReader();

        while (reader.Read())
        {
            lectures.Add(new Lecture
            {
                LectureId = Convert.ToInt32(reader["LectureId"]),
                LectureName = reader["LectureName"].ToString(),
                LectureEmail = reader["LectureEmail"].ToString(),
                LectureAddress = reader["LectureAddress"].ToString(),
                LectureAge = Convert.ToInt32(reader["LectureAge"]),
                LectureCourse = reader["LectureCourse"].ToString()
            });
        }

        return lectures;
    }
}

