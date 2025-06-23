using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unicom_TIC.Controllers;

namespace Unicom_TIC.CONTROLLER
{
    public class ExamController
    {
        private List<Exam> exams = new List<Exam>();
        private int nextId = 1;

        public string SubjectId { get; private set; }

        public void AddExam(int subjectId, string examName)
        {
            exams.Add(new Exam
            {
                ExamId = nextId++,
                SubjectId = SubjectId,
                ExamName = examName
            });
        }

        internal IEnumerable<object> GetAllExams()
        {
            throw new NotImplementedException();
        }

        /* public List<Exam> GetAllExam() => exams;

         public void EditExam(int id, string newName)
         {
             var exam = exams.Find(e => e.ExamId == id);
             if (exam != null) exam.ExamName = newName;
         }*/
    }
}
