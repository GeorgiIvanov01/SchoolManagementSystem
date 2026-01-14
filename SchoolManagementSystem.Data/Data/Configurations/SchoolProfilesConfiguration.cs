using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolManagementSystem.Data.Models.Common;

namespace SchoolManagementSystem.Data.Data.Configurations
{
    public class SchoolProfilesConfiguration : IEntityTypeConfiguration<SchoolProfiles>
    {
        public void Configure(EntityTypeBuilder<SchoolProfiles> builder)
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
