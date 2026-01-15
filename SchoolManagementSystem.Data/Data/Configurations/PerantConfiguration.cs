using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolManagementSystem.Data.Models;

namespace SchoolManagementSystem.Data.Data.Configurations
{
    public class PerantConfiguration : IEntityTypeConfiguration<Parent>
    {
        public void Configure(EntityTypeBuilder<Parent> builder)
        {
            builder
                .HasKey(p => p.Id);

            builder
                .Property(p => p.FirstName)
                .IsRequired(true)
                .HasMaxLength(50);

            builder
                .Property(p => p.MiddleName)
                .IsRequired(false)
                .HasMaxLength(50);

            builder
                .Property(p => p.LastName)
                .IsRequired(true)
                .HasMaxLength(50);

            builder
                .HasMany(p => p.PhoneNumbers)
                .WithOne(pn => pn.Parent)
                .HasForeignKey(pn => pn.ParentId)
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasMany(p => p.Emails)
                .WithOne(e => e.Parent)
                .HasForeignKey(e => e.ParentId)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
