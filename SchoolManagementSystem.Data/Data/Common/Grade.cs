using SchoolManagementSystem.Data.Models;

namespace SchoolManagementSystem.Data.Data.Common
{
    public class Grade
    {
        public int Id { get; set; }
        public Teacher RecordedBy { get; set; } = null!;
        public DateTime DateRecorded { get; set; }
        public double GradeValue { get; set; }
    }
}
