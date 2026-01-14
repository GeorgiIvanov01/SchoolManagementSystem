using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolManagementSystem.Data.Models.Common;

namespace SchoolManagementSystem.Data.Data.Configurations
{
    public class PhoneNumberConfiguration : IEntityTypeConfiguration<PhoneNumber>
    {
        public void Configure(EntityTypeBuilder<PhoneNumber> builder)
        {
            builder
                .HasKey(pn => pn.Id);

            builder
                .Property(pn => pn.Number)
                .HasMaxLength(15)
                .IsRequired(true);
        }
    }
}
