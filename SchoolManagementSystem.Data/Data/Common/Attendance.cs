using SchoolManagementSystem.Data.Data.Models;

namespace SchoolManagementSystem.Data.Data.Common
{
    public class Attendance
    {
        public int Id { get; set; }
        public bool IsPresent { get; set; }
        public DateTime Date { get; set; }

        public int StudentId { get; set; }
        public Student Student { get; set; } = null!;
    }
}
