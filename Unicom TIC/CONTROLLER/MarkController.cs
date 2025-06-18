using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unicom_TIC.Controllers;

namespace Unicom_TIC.CONTROLLER
{
    public class MarkController
    {
        private List<Mark> marks = new List<Mark>();    +-

        public void AddOrUpdateMark(int studentId, int examId, int score)
        {
            var existing = marks.Find(m => m.StudentId == studentId && m.ExamId == examId);
            if (existing != null)
                existing.Score = score;
            else
                marks.Add(new Mark { StudentId = studentId, ExamId = examId, Score = score });
        }

    }
}

