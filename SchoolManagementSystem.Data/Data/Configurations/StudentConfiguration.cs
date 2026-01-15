using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolManagementSystem.Data.Models;

namespace SchoolManagementSystem.Data.Data.Configurations
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder
                .HasKey(s => s.Id);

            builder
                .Property(s => s.FirstName)
                .IsRequired(true)
                .HasMaxLength(50);

            builder
                .Property(s => s.MiddleName)
                .IsRequired(true)
                .HasMaxLength(50);

            builder
                .Property(s => s.LastName)
                .IsRequired(true)
                .HasMaxLength(50);

            builder
                .HasMany(s => s.Parents)
                .WithMany(p => p.Students)
                .UsingEntity(j => j.ToTable("StudentsParents"));

            
        }
    }
}
