using System;
using System.Data.SQLite; // Or use Microsoft.Data.Sqlite if you're on .NET Core

namespace Unicom_TIC.Repositories
{
    internal class DatabaseManager
    {
        public static void CreateTables()
        {
            using (var conn = DbConfig.GetConnection()) // Make sure DbConfig returns SQLiteConnection
            {
                conn.Open();
                var cmd = conn.CreateCommand();

                string createTableQuery = @"
                CREATE TABLE IF NOT EXISTS Course (
                    CourseId INTEGER PRIMARY KEY AUTOINCREMENT,
                    CourseName TEXT NOT NULL
                );

                CREATE TABLE IF NOT EXISTS User(
                    UserId INTEGER PRIMARY KEY AUTOINCREMENT,
                    UserName TEXT NOT NULL,
                    PasswordHash TEXT NOT NULL,
                    Role TEXT NOT NULL
                );

                CREATE TABLE IF NOT EXISTS Room(
                    RoomId INTEGER PRIMARY KEY AUTOINCREMENT,
                    RoomName TEXT NOT NULL,
                    RoomType TEXT NOT NULL
                );

                CREATE TABLE IF NOT EXISTS [Group](
                    GroupId INTEGER PRIMARY KEY AUTOINCREMENT,
                    GroupName TEXT NOT NULL
                );

                CREATE TABLE IF NOT EXISTS Lecture (
                    LectureId INTEGER PRIMARY KEY AUTOINCREMENT,
                    LectureName TEXT NOT NULL,
                    LectureEmail TEXT,
                    LectureAddress TEXT,
                    LectureAge INTEGER,
                    LectureCourse TEXT
                );

                CREATE TABLE IF NOT EXISTS Student (
                    StudentId INTEGER PRIMARY KEY AUTOINCREMENT,
                    StudentName TEXT NOT NULL,
                    StudentAddress TEXT NOT NULL,
                    StudentEmail TEXT NOT NULL,
                    StudentAge INTEGER NOT NULL,
                    CourseId INTEGER,
                    FOREIGN KEY(CourseId) REFERENCES Course(CourseId)
                );

                CREATE TABLE IF NOT EXISTS Subject (
                    SubjectId INTEGER PRIMARY KEY AUTOINCREMENT,
                    SubjectName TEXT NOT NULL
                );

                CREATE TABLE IF NOT EXISTS StudentLecturer (
                    StudentSubjectId INTEGER PRIMARY KEY AUTOINCREMENT,
                    StudentId INTEGER,
                    LecturerId INTEGER,
                    FOREIGN KEY (StudentId) REFERENCES Student(StudentId),
                    FOREIGN KEY (LecturerId) REFERENCES Lecture(LectureId)
                );

                CREATE TABLE IF NOT EXISTS Timetable (
                    TimetableId INTEGER PRIMARY KEY AUTOINCREMENT,
                    Timeslot TEXT NOT NULL
                );

                 CREATE TABLE Attendance (
                        AttendanceID INTEGER PRIMARY KEY AUTOINCREMENT,
                        StudentID INTEGER,
                        CourseID INTEGER,
                        Date TEXT,
                        Status TEXT
                );
                ";

                cmd.CommandText = createTableQuery;
                cmd.ExecuteNonQuery();
            }
        }
    }
}
