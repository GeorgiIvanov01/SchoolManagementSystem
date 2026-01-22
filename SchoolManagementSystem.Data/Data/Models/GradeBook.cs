using SchoolManagementSystem.Data.Data.Common;
namespace SchoolManagementSystem.Data.Models
{
    public class GradeBook
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; } = null!;
        public Grade Grade { get; set; } = null!;
        public ICollection<Subject> Subjects { get; set; } = new List<Subject>();

    }
}
