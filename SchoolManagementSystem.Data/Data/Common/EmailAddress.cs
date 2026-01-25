namespace SchoolManagementSystem.Data.Data.Common
{
    public class EmailAddress
    {
        public int Id { get; set; }
        public string Email { get; set; } = null!;

        public int InfoId { get; set; }
        public Info? Info { get; set; }
    }
}
