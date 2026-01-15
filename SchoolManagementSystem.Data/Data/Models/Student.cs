using SchoolManagementSystem.Data.Models;

namespace SchoolManagementSystem.Data.Models
{
    public class Student
    {
        public int Id { get; set; }

        public string FirstName { get; set; } = string.Empty;
        public string MiddleName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public ICollection<Parent> Parents { get; set; } = new List<Parent>();
        public GradeBook GradeBooks { get; set; } = null!;
    }
}
