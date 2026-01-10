namespace SchoolManagementSystem.Data.Models
{
    public class Info
    {
        public required string Address { get; set; }
        public required List<string> PhoneNumber { get; set; }
        public string? Email { get; set; }
    }
}

//TODO: address validation must have at least 10 characters, phone number must be in valid format, email must be in valid format. 