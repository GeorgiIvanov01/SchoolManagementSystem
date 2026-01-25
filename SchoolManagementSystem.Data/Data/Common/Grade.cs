using SchoolManagementSystem.Data.Data.Enums;
using SchoolManagementSystem.Data.Data.Models;

namespace SchoolManagementSystem.Data.Data.Common
{
    public class Grade
    {
        public int Id { get; set; }
        public int Value { get; set; }
        public DateTime DateRecorded { get; set; }
        public GradeType GradeType { get; set; }

        public int SubjectId { get; set; }
        public Subject Subject { get; set; } = null!;

        public int StudentId { get; set; }
        public Student Student { get; set; } = null!;
    }
}
