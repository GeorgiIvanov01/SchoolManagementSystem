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
                .Property(s => s.Name)
                .IsRequired()
                .HasMaxLength(300)
                .IsRequired(true);

            builder
                .Property(s => s.SchoolType)
                .HasConversion<string>()
                .IsRequired(true);

            builder
                .Property(s => s.Address)
                .HasMaxLength(500)
                .IsRequired(true);

            builder
                .HasMany(s => s.PhoneNumbers)
                .WithOne(pn => pn.School)
                .HasForeignKey(pn => pn.SchoolId)
                .IsRequired(true)
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasMany(s => s.Emails)
                .WithOne(e => e.School)
                .HasForeignKey(e => e.SchoolId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasMany(s => s.SchoolPofiles)
                .WithOne(sp => sp.School)
                .HasForeignKey(sp => sp.SchoolId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Cascade);



        }
    }
}
