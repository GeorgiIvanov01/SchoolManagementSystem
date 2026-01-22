using SchoolManagementSystem.Data.Data.Common;

namespace SchoolManagementSystem.Data.Data.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string? MiddleName { get; set; }
        public string LastName { get; set; } = null!;
        public Info Info { get; set; } = new();

        public ICollection<StudentClass> Classes { get; set; } = new List<StudentClass>();
        public ICollection<ParentStudent> Parents { get; set; } = new List<ParentStudent>();
        public ICollection<Grade> Grades { get; set; } = new List<Grade>();
        public ICollection<Attendance> Attendances { get; set; } = new List<Attendance>();
    }
}
