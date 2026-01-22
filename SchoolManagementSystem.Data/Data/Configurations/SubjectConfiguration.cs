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
        }
    }
}
