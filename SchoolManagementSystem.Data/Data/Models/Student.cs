using SchoolManagementSystem.Data.Data.Common;

namespace SchoolManagementSystem.Data.Data.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string? MiddleName { get; set; }
        public string LastName { get; set; } = null!;

        public int InfoId { get; set; }
        public Info Info { get; set; } = null!;

        public int SchoolId { get; set; }
        public School School { get; set; } = null!;

        public int ClassId { get; set; }
        public Class Class { get; set; } = null!;

        public ICollection<ParentStudent> Parents { get; set; } 
            = new List<ParentStudent>();

        public ICollection<Grade> SubjectGrades { get; set; }
            = new List<Grade>();

        public ICollection<Absence> Absences { get; set; }
            = new List<Absence>();
    }
}
