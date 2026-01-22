using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolManagementSystem.Data.Data.Models;

namespace SchoolManagementSystem.Data.Data.Configurations
{
    public class ParentStudentConfiguration : IEntityTypeConfiguration<ParentStudent>
    {
        public void Configure(EntityTypeBuilder<ParentStudent> entity)
        {
            entity
                .HasKey(e => new { e.ParentId, e.StudentId });
        }
    }
}
