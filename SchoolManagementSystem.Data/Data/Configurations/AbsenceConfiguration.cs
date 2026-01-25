using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolManagementSystem.Data.Data.Common;

namespace SchoolManagementSystem.Data.Data.Configurations
{
    public class AbsenceConfiguration : IEntityTypeConfiguration<Absence>
    {
        public void Configure(EntityTypeBuilder<Absence> entity)
        {
            entity
                .HasKey(e => e.Id);

            entity
                .Property(e => e.IsPresent)
                .IsRequired(true);

            entity
                .Property(e => e.Date)
                .IsRequired(true);

            entity
                .HasOne(e => e.Student)
                .WithMany(s => s.Absences)
                .HasForeignKey(e => e.StudentId)
                .IsRequired(true)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
