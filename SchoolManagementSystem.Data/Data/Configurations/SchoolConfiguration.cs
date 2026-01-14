using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolManagementSystem.Data.Models;

namespace SchoolManagementSystem.Data.Data.Configurations
{
    public class SchoolConfiguration : IEntityTypeConfiguration<School>
    {
        public void Configure(EntityTypeBuilder<School> builder)
        {
            builder
                .HasKey(s => s.Id);

            builder
                .HasMany(s => s.PhoneNumbers)
                .WithOne(pn => pn.School)
                .HasForeignKey(pn => pn.SchoolId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
