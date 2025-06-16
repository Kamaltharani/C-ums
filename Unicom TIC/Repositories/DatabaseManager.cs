using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicom_TIC.Repositories
{
    internal class DatabaseManager
    {
        public static void createtable()
        {
            using (var conn = DbConfig.GetConnection())
            {
                var cmd = conn.CreateCommand();

                string createTableQuery = @"
                 CREATE TABLE IF NOT EXISTS Course (
                      CourseId INTEGER PREMARAY KEY  AUTOINCREMENT,
                      CourseName TEXT NOT  NULL,
                 );
                    
                CREATE TABLE IF NOT EXISTS User(
                      UseId INTEGER PREMARAY KEY AUTOINCREMENT,
                      UseName TEXT NOT NULL,
                      PasswordHash TEXT NOT NULL,
                      Role  TEXT NOT NULL,
                );

                CREATE TABLE IF NOT EXISTS Room(
                       RoomId INTEGER PREMARAY KEY AUTOINCREMENT,
                       RoomName TEXT NOT NULL,
                       RoomType TEXT NOT NULL,
                           
                );
                      
                CREATE TABLE IF NOT EXISTS Group(
                      GroupId INTEGER PREMARAY KEY AUTOINCREMENT,
                      GroupName TEXT NOT NULL,
                );

                CREATE TABLE  IF NOT EXISTS Lecture (
                       LectureID INTEGER PRIMARY KEY AUTOINCREMENT,
                       LectureName TEXT NOT NULL,
                       LectureEmail TEXT,
                       LectureAddress TEXT,
                       Lectureage INTEGER,
                       Lecturecourse TEXT
                 );

                  
                CREATE TABLE  IF NOT EXISTS Student
                    SudenteId INTEGER PRIMARY KEY AUTOINCREMENT,
                    StudentName TEXT NOT NULL,
                    StudentAddress TEXT NOT NULL,
                    StudentEmail TEXT NOT NULL,
                    StudentAge INTEGER NOT NULL,
                    CourseId INTEGER ,
                    FOREIGN KEY(CourseId) REFERENCE (CourseId)
                );
                CREATE TABLE IF NOT EXISTS Subject(
                   SubjectId INTEGER PRIMARY KEY AUTOINCREMENT,
                   SubjectName TEXT NOT NULL
                 );
                
                 CREATE TABLE IF NOT EXISTS StudentLecturer (
                    StudentSubject INTEGER PRIMARY KEY AUTOINCREMENT,
                    StudentId INTEGER,
                    LecturerID INTEGER,
                    FOREIGN KEY (StudentId) REFERENCES Students(StudentId),
                    FOREIGN KEY (LecturerID) REFERENCES Lecturers(LecturerID)
                );
                CREATE TABLE IF NOT EXISTS Subject(
                    SubjectId INTEGER PRIMARY KEY AUTOINCREMENT,
                    SubjectNameTEXT NOT NULL
                 );
                 
                CREATE TABLE IF NOT EXISTS Timetable(
                    TimetableId INTEGER PRIMARY KEY AUTOINCREMENT,
                    Timesolt  TEXT NOT NULL
                 );
                 
                  CREATE TABLE IF NOT EXISTS User (
                    UserId INTEGER PRIMARY KEY AUTOINCREMENT,
                    Username  TEXT NOT NULL,
                    password INTEGER,
                    Email TEXT NOT NULL,
                    

               ";

                cmd.ExecuteNonQuery();
            } 
        }
    }
}
