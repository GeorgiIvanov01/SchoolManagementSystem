namespace SchoolManagementSystem.Data.Models.Common
{
    public class PhoneNumber
    {
        public int Id { get; set; }
        public string Number { get; set; } = null!;

        public int SchoolId { get; set; }
        public School School { get; set; } = null!;
    }
}
