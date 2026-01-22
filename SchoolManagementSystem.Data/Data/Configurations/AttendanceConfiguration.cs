using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolManagementSystem.Data.Data.Common;

namespace SchoolManagementSystem.Data.Data.Configurations
{
    public class AttendanceConfiguration : IEntityTypeConfiguration<Attendance>
    {
        public void Configure(EntityTypeBuilder<Attendance> entity)
        {
            entity
                .HasKey(e => e.Id);

            entity
                .Property(e => e.IsPresent)
                .IsRequired(true);

            entity
                .Property(e => e.Date)
                .IsRequired(true);
        }
    }
}
