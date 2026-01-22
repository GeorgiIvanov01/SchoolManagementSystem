using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolManagementSystem.Data.Models;

namespace SchoolManagementSystem.Data.Data.Configurations
{
    public class GradeBookConfiguration : IEntityTypeConfiguration<GradeBook>
    {
        public void Configure(EntityTypeBuilder<GradeBook> builder)
        {
            builder
                .HasKey(gb => gb.Id);

            builder
                .HasOne(gb => gb.Student)
                .WithOne(s => s.GradeBooks)
                .HasForeignKey<GradeBook>(gb => gb.StudentId)
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .Property(gb => gb.Grade)
                .IsRequired(false);

        }
    }
}
