using System.Collections.Generic;
using Unicom_TIC.Models;

namespace Unicom_TIC.Controllers
{
    public class SubjectController
    {
        public List<Subject> Subjects = new List<Subject>();
        private int nextSubjectId = 1;

        public void AddSubject(string subjectName, int courseId)
        {
            Subjects.Add(new Subject { SubjectId = nextSubjectId++, SubjectName = subjectName, CourseId = courseId });
        }

        public void EditSubject(int id, string newName)
        {
            var sub = Subjects.Find(s => s.SubjectId == id);
            if (sub != null) sub.SubjectName = newName;
        }

        public void DeleteSubject(int id)
        {
            Subjects.RemoveAll(s => s.SubjectId == id);
        }

        public List<Subject> GetSubjectsByCourse(int courseId)
        {
            return Subjects.FindAll(s => s.CourseId == courseId);
        }
    }
}
