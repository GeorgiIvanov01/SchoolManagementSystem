using SchoolManagementSystem.Data.Models;

namespace SchoolManagementSystem.Data.Models
{
    public class Student
    {
        public int Id { get; set; }

        public string FirstName { get; set; } = null!;
        public string MiddleName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public ICollection<Parent> Parents { get; set; } = new List<Parent>();
        public GradeBook GradeBooks { get; set; } = null!;
    }
}
