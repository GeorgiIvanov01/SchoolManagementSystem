namespace SchoolManagementSystem.Data.Data.Common
{
    public class PhoneNumber
    {
        public int Id { get; set; }

        public string Number { get; set; } = null!;

        public int InfoId { get; set; }
        public Info? Info { get; set; }
    }
}
