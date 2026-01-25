using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolManagementSystem.Data.Data.Common;

namespace SchoolManagementSystem.Data.Data.Configurations
{
    public class GradeConfiguration : IEntityTypeConfiguration<Grade>
    {
        public void Configure(EntityTypeBuilder<Grade> entity)
        {
            entity
                .HasKey(e => e.Id);

            entity
                .Property(e => e.Value)
                .IsRequired(true);

            entity
                .HasOne(e => e.Subject)
                .WithOne(s => s.Grade)
                .HasForeignKey<Grade>(e => e.SubjectId)
                .OnDelete(DeleteBehavior.Restrict);

            entity
                .Property(e => e.DateRecorded)
                .IsRequired(true);

            entity .Property(e => e.GradeType)
                .IsRequired(true);

            entity
                .HasOne(e => e.Student)
                .WithMany(s => s.SubjectGrades)
                .HasForeignKey(e => e.StudentId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
