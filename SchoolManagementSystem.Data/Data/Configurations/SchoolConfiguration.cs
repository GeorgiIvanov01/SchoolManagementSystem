using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolManagementSystem.Data.Data.Models;

namespace SchoolManagementSystem.Data.Data.Configurations
{
    public class SchoolConfiguration : IEntityTypeConfiguration<School>
    {
        public void Configure(EntityTypeBuilder<School> entity)
        {
            entity
                .HasKey(e => e.Id);

            entity
                .Property(e => e.Name)
                .IsRequired(true)
                .HasMaxLength(200);

            entity
                .Property(e => e.Type)
                .IsRequired(true);

            entity
                .OwnsOne(i => i.Info, InfoModelBuilder.Configure);
        }
    }
}
