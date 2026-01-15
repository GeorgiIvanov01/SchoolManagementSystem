using SchoolManagementSystem.Data.Data.Common;

namespace SchoolManagementSystem.Data.Models
{
    public class Parent
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string MiddleName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public ICollection<PhoneNumber> PhoneNumbers { get; set; } = new List<PhoneNumber>();
        public ICollection<Emails> Emails { get; set; } = new List<Emails>();
        public ICollection<Student> Students { get; set; } = new List<Student>();
    }
}
