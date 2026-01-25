using SchoolManagementSystem.Data.Data.Common;

namespace SchoolManagementSystem.Data.Data.Models
{
    public class Parent
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string? MiddleName { get; set; }
        public string LastName { get; set; } = null!;

        public int InfoId { get; set; }
        public Info Info { get; set; } = null!;

        public ICollection<ParentStudent> Students { get; set; }
            = new List<ParentStudent>();
    }
}
