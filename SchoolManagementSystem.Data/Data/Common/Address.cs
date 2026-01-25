namespace SchoolManagementSystem.Data.Data.Common
{
    public class Address
    {
        public int Id { get; set; }

        public string Country { get; set; } = null!;    
        public string City { get; set; } = null!;
        public string Street { get; set; } = null!;
        public string PostalCode { get; set; } = null!;
        public string? AdditionalInformation { get; set; }

        public int InfoId { get; set; }
        public Info Info { get; set; } = null!;
    }
}
