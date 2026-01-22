namespace SchoolManagementSystem.Data.Data.Models
{
    public class Class
    {
        public int Id { get; set; }
        public int Grade { get; set; }
        public char Section { get; set; }

        public int SchoolId { get; set; }
        public School School { get; set; } = null!;

        public int? LeadTeacherId { get; set; }
        public Staff? LeadTeacher { get; set; }

        public ICollection<StudentClass> Students { get; set; } = new List<StudentClass>();
    }
}
