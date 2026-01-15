using SchoolManagementSystem.Data.Data.Models.Common;

namespace SchoolManagementSystem.Data.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;

        public ICollection<Subject> Subjects { get; set; } = new List<Subject>();

    }
}
