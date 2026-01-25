using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolManagementSystem.Data.Data.Common;

namespace SchoolManagementSystem.Data.Data.Configurations
{
    public class ExamConfiguration : IEntityTypeConfiguration<Exam>
    {
        public void Configure(EntityTypeBuilder<Exam> entity)
        {
            entity
                .HasKey(e => e.Id);

            entity
                .Property(e => e.ExamDate)
                .IsRequired(true);

            entity
                .HasOne(e => e.Subject)
                .WithOne(e => e.Exam)
                .HasForeignKey<Exam>(e => e.SubjectId)
                .OnDelete(DeleteBehavior.Restrict);

            entity
                .HasOne(e => e.Class)
                .WithMany(c => c.Exams)
                .HasForeignKey(e => e.ClassId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
