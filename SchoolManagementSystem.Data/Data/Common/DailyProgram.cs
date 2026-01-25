using SchoolManagementSystem.Data.Data.Models;

namespace SchoolManagementSystem.Data.Data.Common
{
    public class DailyProgram
    {
        public int Id { get; set; }
        public DayOfWeek Day { get; set; }

        public int ClassId { get; set; }
        public Class Class { get; set; } = null!;

        public ICollection<Subject> Subjects { get; set; } 
            = new List<Subject>();
    }
}
