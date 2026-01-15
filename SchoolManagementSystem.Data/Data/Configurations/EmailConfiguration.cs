using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolManagementSystem.Data.Data.Common;

namespace SchoolManagementSystem.Data.Data.Configurations
{
    public class EmailConfiguration : IEntityTypeConfiguration<Emails>
    {
        public void Configure(EntityTypeBuilder<Emails> builder)
        {
            builder
                .HasKey(e => e.Id);

            builder
                .Property(e => e.EmailAddress)
                .HasMaxLength(255)
                .IsRequired(false);

        }
    }
}
