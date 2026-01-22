using SchoolManagementSystem.Data.Models;

namespace SchoolManagementSystem.Data.Data.Common
{
    public class Email
    {
        public int Id { get; set; }
        public string EmailAddress { get; set; } = null!;

        public int SchoolId { get; set; }
        public School School { get; set; } = null!;

        public int? TeacherId { get; set; }
        public Teacher? Teacher { get; set; }

        public int? ParentId { get; set; }
        public Parent? Parent { get; set; }
    }
}
