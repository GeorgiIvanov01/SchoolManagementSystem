using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolManagementSystem.Data.Data.Models;

namespace SchoolManagementSystem.Data.Data.Configurations
{
    public class ClassConfiguration : IEntityTypeConfiguration<Class>
    {
        public void Configure(EntityTypeBuilder<Class> entity)
        {
            entity
                .HasKey(x => x.Id);

            entity
                .Property(x => x.SchoolGrade)
                .HasMaxLength(2)
                .IsRequired(true);

            entity
                .Property(x => x.Section)
                .IsRequired(true);

            entity
                .HasOne(x => x.School)
                .WithMany(x => x.Classes)
                .HasForeignKey(x => x.SchoolId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired(true);

            entity
                .HasMany(x => x.ClassProgram)
                .WithOne(x => x.Class)
                .HasForeignKey(x => x.ClassId)
                .OnDelete(DeleteBehavior.Cascade);

            entity
                .HasMany(x => x.Students)
                .WithOne(x => x.Class)
                .HasForeignKey(x => x.ClassId)
                .OnDelete(DeleteBehavior.Restrict);

            entity
                .HasMany(x => x.Exams)
                .WithOne(x => x.Class)
                .HasForeignKey(x => x.ClassId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
