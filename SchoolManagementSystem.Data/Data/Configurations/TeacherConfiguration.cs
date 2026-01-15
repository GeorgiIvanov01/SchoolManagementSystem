using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolManagementSystem.Data.Models;

namespace SchoolManagementSystem.Data.Data.Configurations
{
    public class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder
                .HasKey(t => t.Id);

            builder
                .Property(t => t.FirstName)
                .IsRequired(true)
                .HasMaxLength(50);

            builder .Property(t => t.MiddleName)
                .IsRequired(true)
                .HasMaxLength(50);

            builder
                .Property(t => t.LastName)
                .IsRequired(true)
                .HasMaxLength(50);

            builder
                .Property(t => t.IsHeadTeacher)
                .IsRequired(true);

            builder
                .Property(t => t.IsDirector)
                .IsRequired(true);

            builder
                .HasMany(t => t.Subjects)
                .WithMany(s => s.Teachers)
                .UsingEntity(j => j.ToTable("TeacherSubjects"));

            builder
                .HasMany(t => t.PhoneNumbers)
                .WithOne(p => p.Teacher)
                .HasForeignKey(p => p.TeacherId)
                .IsRequired(true)
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasMany(t => t.Emails)
                .WithOne(e => e.Teacher)
                .HasForeignKey(e => e.TeacherId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
