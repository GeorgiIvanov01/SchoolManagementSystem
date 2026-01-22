using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolManagementSystem.Data.Data.Common;

namespace SchoolManagementSystem.Data.Data.Configurations
{
    public class GradeConfiguration : IEntityTypeConfiguration<Grade>
    {
        public void Configure(EntityTypeBuilder<Grade> builder)
        {
            builder
                .HasKey(g => g.Id);

            builder
                .Property(r => r.RecordedBy)
                .IsRequired(true);

            builder 
                .Property(r => r.DateRecorded)
                .IsRequired(true);

            builder
                .Property(g => g.GradeValue)
                .HasMaxLength(6)
                .IsRequired(true);
        }
    }
}
