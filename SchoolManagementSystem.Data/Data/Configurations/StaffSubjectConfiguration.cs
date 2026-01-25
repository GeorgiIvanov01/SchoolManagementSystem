using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolManagementSystem.Data.Data.Common;

namespace SchoolManagementSystem.Data.Data.Configurations
{
    public class StaffSubjectConfiguration : IEntityTypeConfiguration<StaffSubject>
    {
        public void Configure(EntityTypeBuilder<StaffSubject> entity)
        {
            entity
                .HasKey(e => new { e.StaffId, e.SubjectId });
        }
    }
}
