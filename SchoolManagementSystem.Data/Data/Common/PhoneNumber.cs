using SchoolManagementSystem.Data.Models;

namespace SchoolManagementSystem.Data.Data.Common
{
    public class PhoneNumber
    {
        public int Id { get; set; }
        public string Number { get; set; } = null!;

        public int SchoolId { get; set; }
        public School School { get; set; } = null!;

        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; } = null!;

        public int ParentId { get; set; }
        public Parent Parent { get; set; } = null!;
    }
}
