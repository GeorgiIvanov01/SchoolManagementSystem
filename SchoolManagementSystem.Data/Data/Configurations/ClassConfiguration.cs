using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolManagementSystem.Data.Data.Models;

namespace SchoolManagementSystem.Data.Data.Configurations
{
    public class ClassConfiguration : IEntityTypeConfiguration<Class>
    {
        public void Configure(EntityTypeBuilder<Class> entity)
        {
            entity
                .HasKey(x => x.Id);

            entity
                .Property(x => x.Grade)
                .HasMaxLength(2)
                .IsRequired(true);

            entity
                .Property(x => x.Section)
                .IsRequired(true);
        }
    }
}
