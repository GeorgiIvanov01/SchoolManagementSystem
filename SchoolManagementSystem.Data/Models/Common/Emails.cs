namespace SchoolManagementSystem.Data.Models.Common
{
    public class Emails
    {
        public int Id { get; set; }
        public string EmailAddress { get; set; } = null!;

        public int? SchoolId { get; set; }
        public School? School { get; set; }
    }
}
