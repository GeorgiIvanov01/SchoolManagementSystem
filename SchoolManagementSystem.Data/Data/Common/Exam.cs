using SchoolManagementSystem.Data.Data.Models;

namespace SchoolManagementSystem.Data.Data.Common
{
    public class Exam
    {
        public int Id { get; set; }
        public DateTime ExamDate { get; set; }

        public int SubjectId { get; set; }
        public Subject Subject { get; set; } = null!;

        public int ClassId { get; set; }
        public Class Class { get; set; } = null!;
    }
}
