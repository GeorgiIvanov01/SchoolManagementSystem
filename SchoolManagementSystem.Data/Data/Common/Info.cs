namespace SchoolManagementSystem.Data.Data.Common
{
    public class Info
    {
        public string? Address { get; set; }
        public ICollection<PhoneNumber> PhoneNumbers { get; set; } = new List<PhoneNumber>();
        public ICollection<EmailAddress> Emails { get; set; } = new List<EmailAddress>();
    }
}
