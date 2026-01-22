using SchoolManagementSystem.Data.Data.Common;
using SchoolManagementSystem.Data.Data.Enums;

namespace SchoolManagementSystem.Data.Data.Models
{
    public class School
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public SchoolTypes Type { get; set; }
        public Info Info { get; set; } = new();

        public ICollection<Class> Classes { get; set; } = new List<Class>();
        public ICollection<Staff> Staff { get; set; } = new List<Staff>();
        public ICollection<Student> Students { get; set; } = new List<Student>();
    }
}
