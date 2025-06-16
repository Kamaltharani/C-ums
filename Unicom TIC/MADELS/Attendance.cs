using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicom_TIC.MADELS
{
    internal class Attendance
    {
        public int AttendanceId { get; set; }
        public int StudentId { get; set; }
        public int TimeTable {  get; set; }
        public int Timslot {  get; set; }
    }
}
