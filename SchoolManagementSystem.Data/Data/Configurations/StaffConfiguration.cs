using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolManagementSystem.Data.Data.Models;

namespace SchoolManagementSystem.Data.Data.Configurations
{
    public class StaffConfiguration : IEntityTypeConfiguration<Staff>
    {
        public void Configure(EntityTypeBuilder<Staff> entity)
        {
            entity
                .HasKey(e => e.Id);

            entity
                .Property(e => e.FirstName)
                .IsRequired(true)
                .HasMaxLength(50);

            entity
                .Property(e => e.MiddleName)
                .IsRequired(false)
                .HasMaxLength(50);

            entity
                .Property(e => e.LastName)
                .IsRequired(true)
                .HasMaxLength(50);

            entity
                .OwnsOne(i => i.Info, InfoModelBuilder.Configure);
        }

    }
}
