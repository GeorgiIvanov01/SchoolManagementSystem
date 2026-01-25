using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolManagementSystem.Data.Data.Common;

namespace SchoolManagementSystem.Data.Data.Configurations
{
    public class DailyProgramConfiguration : IEntityTypeConfiguration<DailyProgram>
    {
        public void Configure(EntityTypeBuilder<DailyProgram> entity)
        {
            entity
                .HasKey(x => x.Id);

            entity
                .Property(x => x.Day)
                .IsRequired(true);

            entity
                .HasOne(dp => dp.Class)
                .WithMany(c => c.ClassProgram)
                .HasForeignKey(dp => dp.ClassId)
                .OnDelete(DeleteBehavior.Restrict);

            entity
                .HasMany(dp => dp.Subjects)
                .WithOne(s => s.DailyProgram)
                .HasForeignKey(s => s.DailyProgramId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
