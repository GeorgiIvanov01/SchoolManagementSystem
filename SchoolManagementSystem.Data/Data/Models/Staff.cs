using SchoolManagementSystem.Data.Data.Common;

namespace SchoolManagementSystem.Data.Data.Models
{
    public class Staff
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string? MiddleName { get; set; }
        public string LastName { get; set; } = null!;

        public int InfoId { get; set; }
        public Info Info { get; set; } = new();

        public int SchoolId { get; set; }
        public School School { get; set; } = null!;

        public ICollection<StaffRoleAssignment> Roles { get; set; }
            = new List<StaffRoleAssignment>();

        public ICollection<StaffSubject> Subjects { get; set; } 
            = new List<StaffSubject>();
    }
}
