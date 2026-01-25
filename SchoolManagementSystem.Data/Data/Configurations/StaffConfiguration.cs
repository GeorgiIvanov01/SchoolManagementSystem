using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolManagementSystem.Data.Data.Common;
using SchoolManagementSystem.Data.Data.Models;

namespace SchoolManagementSystem.Data.Data.Configurations
{
    public class StaffConfiguration : IEntityTypeConfiguration<Staff>
    {
        public void Configure(EntityTypeBuilder<Staff> entity)
        {
            entity
                .HasKey(e => e.Id);

            entity
                .Property(e => e.FirstName)
                .IsRequired(true)
                .HasMaxLength(50);

            entity
                .Property(e => e.MiddleName)
                .IsRequired(false)
                .HasMaxLength(50);

            entity
                .Property(e => e.LastName)
                .IsRequired(true)
                .HasMaxLength(50);

            entity
                .HasOne(e => e.Info)
                .WithOne(i => i.Staff)
                .HasForeignKey<Staff>(e => e.InfoId)
                .OnDelete(DeleteBehavior.Cascade);

            entity
                .HasOne(e => e.School)
                .WithMany(s => s.Staff)
                .HasForeignKey(e => e.SchoolId)
                .OnDelete(DeleteBehavior.Restrict);

            entity
                .HasMany(e => e.Roles)
                .WithOne(e => e.Staff)
                .HasForeignKey(e => e.StaffId)
                .OnDelete(DeleteBehavior.Cascade);

            entity
                .HasMany(e => e.Subjects)
                .WithOne(e => e.Staff)
                .HasForeignKey(e => e.StaffId)
                .OnDelete(DeleteBehavior.Restrict);
        }

    }
}
