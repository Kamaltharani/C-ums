using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicom_TIC.Models
{
    public class Attendance
    {
        public int AttendancId { get; set; }
        public string StudentName { get; set; }
        public DateTime DateTime { get; set; }
        public bool IsPresent { get; set; }
    }
}

