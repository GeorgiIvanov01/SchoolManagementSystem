using SchoolManagementSystem.Data.Models;

namespace SchoolManagementSystem.Data.Data.Common
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public ICollection<Teacher> Teachers { get; set; } = new List<Teacher>();
    }
}
