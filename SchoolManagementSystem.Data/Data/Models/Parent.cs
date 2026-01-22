using SchoolManagementSystem.Data.Data.Common;

namespace SchoolManagementSystem.Data.Data.Models
{
    public class Parent
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string? MiddleName { get; set; }
        public string LastName { get; set; } = null!;
        public Info Info { get; set; } = new();

        public ICollection<ParentStudent> Students { get; set; } = new List<ParentStudent>();
    }
}
