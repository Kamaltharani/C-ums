using System;
using System.Collections.Generic;
using Unicom_TIC.Models;

namespace Unicom_TIC.Controllers
{
    public class AttendanceController
    {
        private List<Attendance> attendanceList = new List<Attendance>();

        public void AddAttendance(string studentName, DateTime Dates, bool isPresent)
        {
            Attendance att = new Attendance
            {
                AttendancId = attendanceList.Count + 1,
                StudentName = studentName,
                DateTime = Dates,
                IsPresent = isPresent
            };

            attendanceList.Add(att);
        }

        public List<Attendance> GetAllAttendance()
        {
            return attendanceList;
        }
    }
}
