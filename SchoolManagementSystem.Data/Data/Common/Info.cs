using SchoolManagementSystem.Data.Data.Models;

namespace SchoolManagementSystem.Data.Data.Common
{
    public class Info
    {

        public int Id { get; set; }

        public Address Address { get; set; } = null!;

        public ICollection<PhoneNumber> PhoneNumbers { get; set; } 
            = new List<PhoneNumber>();

        public ICollection<EmailAddress> Emails { get; set; }
            = new List<EmailAddress>();

        public int StudentId { get; set; }
        public Student? Student { get; set; }

        public int StaffId { get; set; }
        public Staff? Staff { get; set; }

        public int SchoolId { get; set; }
        public School? School { get; set; }

        public int PerentId { get; set; }
        public Parent? Parent { get; set; }
    }
}
