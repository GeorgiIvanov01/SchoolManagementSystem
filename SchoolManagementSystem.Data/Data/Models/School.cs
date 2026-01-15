using SchoolManagementSystem.Data.Data.Common;
using SchoolManagementSystem.Data.Data.Enums;

namespace SchoolManagementSystem.Data.Models
{
    public class School
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public required SchoolTypes SchoolType { get; set; }

        public string  Address { get; set; } = null!;

        public ICollection<PhoneNumber> PhoneNumbers { get; set; } = new List<PhoneNumber>();

        public ICollection<Emails> Emails { get; set; } = new List<Emails>();

        public ICollection<SchoolProfiles> SchoolPofiles { get; set; } = new List<SchoolProfiles>();

        public virtual ICollection<Student> Students { get; set; } = new List<Student>();

        public virtual ICollection<Teacher> Teachers { get; set; } = new List<Teacher>();
    }
}
