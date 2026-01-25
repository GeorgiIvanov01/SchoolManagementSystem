namespace SchoolManagementSystem.Data.Data.Common
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public int GradeId { get; set; }
        public Grade Grade { get; set; } = null!;

        public int ExamId { get; set; }
        public Exam Exam { get; set; } = null!;

        public int DailyProgramId { get; set; }
        public DailyProgram DailyProgram { get; set; } = null!;

        public ICollection<StaffSubject> Teachers { get; set; } 
            = new List<StaffSubject>();

    }
}
