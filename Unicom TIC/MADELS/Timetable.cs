﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicom_TIC.Controllers
{
    internal class Timetable
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public string LecturerName { get; set; }
        public string Day { get; set; }
        public string Time { get; set; }
        public string Room { get; set; }
    }
}
