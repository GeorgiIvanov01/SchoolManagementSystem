using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolManagementSystem.Data.Data.Models;

namespace SchoolManagementSystem.Data.Data.Configurations
{
    public class ParentConfiguration : IEntityTypeConfiguration<Parent>
    {
        public void Configure(EntityTypeBuilder<Parent> entity)
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
                .HasOne(e => e.Info)
                .WithOne(i => i.Parent)
                .HasForeignKey<Parent>(e => e.InfoId)
                .OnDelete(DeleteBehavior.Cascade);

            entity
                .HasMany(e => e.Students)
                .WithOne(ps => ps.Parent)
                .HasForeignKey(ps => ps.ParentId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
