using SchoolManagementSystem.Data.Data.Common;

namespace SchoolManagementSystem.Data.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string? MiddleName { get; set; }
        public string LastName { get; set; } = null!;
        public bool IsHeadTeacher { get; set; }
        public bool IsDirector { get; set; }
        public ICollection<Subject> Subjects { get; set; } = new List<Subject>();
        public ICollection<PhoneNumber> PhoneNumbers { get; set; } = new List<PhoneNumber>();
        public ICollection<Email> Emails { get; set; } = new List<Email>();
    }
}
