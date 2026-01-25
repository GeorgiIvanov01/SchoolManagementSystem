using SchoolManagementSystem.Data.Data.Common;

namespace SchoolManagementSystem.Data.Data.Models
{
    public class Class
    {
        public int Id { get; set; }
        public int SchoolGrade { get; set; }
        public char Section { get; set; }

        public int SchoolId { get; set; }
        public School School { get; set; } = null!;

        public ICollection<DailyProgram> ClassProgram { get; set; } 
            = new List<DailyProgram>();

        public ICollection<Student> Students { get; set; }
            = new List<Student>();

        public ICollection<Exam> Exams { get; set; } 
            = new List<Exam>();
    }
}
