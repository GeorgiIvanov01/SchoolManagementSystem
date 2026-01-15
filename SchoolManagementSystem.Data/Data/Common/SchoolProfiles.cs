using SchoolManagementSystem.Data.Models;

namespace SchoolManagementSystem.Data.Data.Common
{
    public class SchoolProfiles
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public int? SchoolId { get; set; }
        public School? School { get; set; }
    }
}
