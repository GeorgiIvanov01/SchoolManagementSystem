using SchoolManagementSystem.Data.Data.Common;

namespace SchoolManagementSystem.Data.Models
{
    public class Parent
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string? MiddleName { get; set; }
        public string LastName { get; set; } = null!;
        public ICollection<PhoneNumber> PhoneNumbers { get; set; } = new List<PhoneNumber>();
        public ICollection<Email> Emails { get; set; } = new List<Email>();
        public ICollection<Student> Students { get; set; } = new List<Student>();
    }
}
