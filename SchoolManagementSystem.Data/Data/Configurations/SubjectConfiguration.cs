using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolManagementSystem.Data.Data.Common;

namespace SchoolManagementSystem.Data.Data.Configurations
{
    public class SubjectConfiguration : IEntityTypeConfiguration<Subject>
    {
        public void Configure(EntityTypeBuilder<Subject> entity)
        {
            entity
                .HasKey(e => e.Id);

            entity
                .Property(e => e.Name)
                .IsRequired(true)
                .HasMaxLength(100);

            entity
                .HasOne(e => e.Grade)
                .WithOne(e => e.Subject)
                .HasForeignKey<Subject>(e => e.GradeId)
                .OnDelete(DeleteBehavior.Restrict);

            entity
                .HasOne(e => e.Exam)
                .WithOne(e => e.Subject)
                .HasForeignKey<Subject>(e => e.ExamId)
                .OnDelete(DeleteBehavior.Restrict);

            entity
                .HasOne(e => e.DailyProgram)
                .WithMany(e => e.Subjects)
                .OnDelete(DeleteBehavior.Restrict);

            entity
                .HasMany(e => e.Teachers)
                .WithOne(e => e.Subject)
                .HasForeignKey(e => e.SubjectId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
