using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolManagementSystem.Data.Data.Models;

namespace SchoolManagementSystem.Data.Data.Configurations
{
    public class StudentClassConfiguration : IEntityTypeConfiguration<StudentClass>
    {
        public void Configure(EntityTypeBuilder<StudentClass> entity)
        {
            entity
                .HasKey(e => new { e.StudentId, e.ClassId });
        }
    }
}
