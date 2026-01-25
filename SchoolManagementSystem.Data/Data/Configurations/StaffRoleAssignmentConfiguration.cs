using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolManagementSystem.Data.Data.Common;

namespace SchoolManagementSystem.Data.Data.Configurations
{
    public class StaffRoleAssignmentConfiguration : IEntityTypeConfiguration<StaffRoleAssignment>

    {
        public void Configure(EntityTypeBuilder<StaffRoleAssignment> entity)
        {
            entity
                .HasKey(e => new { e.StaffId, e.Role });

            entity
                .HasOne(e => e.Staff)
                .WithMany(s => s.Roles)
                .HasForeignKey(e => e.StaffId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
