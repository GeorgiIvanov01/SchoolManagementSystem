using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolManagementSystem.Data.Data.Common;

namespace SchoolManagementSystem.Data.Data.Configurations
{
    public class SchoolProfilesConfiguration : IEntityTypeConfiguration<SchoolProfile>
    {
        public void Configure(EntityTypeBuilder<SchoolProfile> builder)
        {
            builder
                .HasKey(sp => sp.Id);

            builder
                .Property(sp => sp.Name)
                .HasMaxLength(255)
                .IsRequired(false);
        }
    }
}
