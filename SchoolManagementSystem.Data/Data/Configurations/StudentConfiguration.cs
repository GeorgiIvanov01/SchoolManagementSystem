using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolManagementSystem.Data.Data.Models;

namespace SchoolManagementSystem.Data.Data.Configurations
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> entity)
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

            entity .Property(e => e.LastName)
                .IsRequired(true)
                .HasMaxLength(50);

            entity
                .HasOne(e => e.Info)
                .WithOne(i => i.Student)
                .HasForeignKey<Student>(e => e.InfoId)
                .OnDelete(DeleteBehavior.Cascade);

            entity
                .HasOne(e => e.School)
                .WithMany(s => s.Students)
                .HasForeignKey(e => e.SchoolId)
                .OnDelete(DeleteBehavior.Restrict);

            entity
                .HasOne(e => e.Class)
                .WithMany(c => c.Students)
                .HasForeignKey(e => e.ClassId)
                .OnDelete(DeleteBehavior.Restrict);

            entity
                .HasMany(e => e.Parents)
                .WithOne(ps => ps.Student)
                .HasForeignKey(ps => ps.StudentId)
                .OnDelete(DeleteBehavior.Restrict);

            entity
                .HasMany(e => e.SubjectGrades)
                .WithOne(g => g.Student)
                .HasForeignKey(g => g.StudentId)
                .OnDelete(DeleteBehavior.Cascade);

            entity
                .HasMany(e => e.Absences)
                .WithOne(a => a.Student)
                .HasForeignKey(a => a.StudentId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
