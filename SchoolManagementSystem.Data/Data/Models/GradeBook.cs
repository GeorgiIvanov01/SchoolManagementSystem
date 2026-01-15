namespace SchoolManagementSystem.Data.Models
{
    public class GradeBook
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; } = null!;
    }
}
