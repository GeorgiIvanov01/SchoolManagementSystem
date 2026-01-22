using SchoolManagementSystem.Data.Data.Enums;
using SchoolManagementSystem.Data.Data.Models;

namespace SchoolManagementSystem.Data.Data.Common
{
    public class StaffRoleAssignment
    {
        public StaffRole Role { get; set; }

        public int StaffId { get; set; }
        public Staff Staff { get; set; } = null!;

    }
}
