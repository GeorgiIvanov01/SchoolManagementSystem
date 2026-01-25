using Microsoft.EntityFrameworkCore;
using SchoolManagementSystem.Data.Data.Common;

namespace SchoolManagementSystem.Data.Data.Configurations
{
    public class SubjectDailyProgramConfiguration : IEntityTypeConfiguration<SubjectDailyProgram>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<SubjectDailyProgram> entity)
        {
            entity.HasKey(e => new { e.SubjectId, e.DailyProgramId });
        }
    }
}
