namespace SchoolManagementSystem.Data.Data.Common
{
    public class SubjectDailyProgram
    {
        public int SubjectId { get; set; }
        public Subject Subject { get; set; } = null!;

        public int DailyProgramId { get; set; }
        public DailyProgram DailyProgram { get; set; } = null!;
    }
}
