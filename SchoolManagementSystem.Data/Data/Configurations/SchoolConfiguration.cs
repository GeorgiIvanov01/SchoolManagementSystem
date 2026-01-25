using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolManagementSystem.Data.Data.Models;

namespace SchoolManagementSystem.Data.Data.Configurations
{
    public class SchoolConfiguration : IEntityTypeConfiguration<School>
    {
        public void Configure(EntityTypeBuilder<School> entity)
        {
            entity
                .HasKey(e => e.Id);

            entity
                .Property(e => e.Name)
                .IsRequired(true)
                .HasMaxLength(200);

            entity
                .Property(e => e.Type)
                .IsRequired(true);

            entity
                .HasOne(e => e.Info)
                .WithOne(i => i.School)
                .HasForeignKey<School>(e => e.InfoId)
                .OnDelete(DeleteBehavior.Restrict);

            entity
                .HasMany(e => e.Classes)
                .WithOne(c => c.School)
                .HasForeignKey(c => c.SchoolId)
                .OnDelete(DeleteBehavior.Restrict);

            entity
                .HasMany(e => e.Staff)
                .WithOne(s => s.School)
                .HasForeignKey(s => s.SchoolId)
                .OnDelete(DeleteBehavior.Restrict);

            entity
                .HasMany(e => e.Students)
                .WithOne(s => s.School)
                .HasForeignKey(s => s.SchoolId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
