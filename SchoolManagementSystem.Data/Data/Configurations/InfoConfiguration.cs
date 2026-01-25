using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolManagementSystem.Data.Data.Common;

public class InfoConfiguration : IEntityTypeConfiguration<Info>
{
    public void Configure(EntityTypeBuilder<Info> entity)
    {
        entity
            .HasKey(e => e.Id);

        entity
            .HasOne(e => e.Address)
            .WithOne(a => a.Info)
            .HasForeignKey<Address>(a => a.InfoId)
            .OnDelete(DeleteBehavior.Cascade);

        entity
            .HasMany(e => e.PhoneNumbers)
            .WithOne(p => p.Info)
            .HasForeignKey(p => p.InfoId)
            .OnDelete(DeleteBehavior.Cascade);

        entity
            .HasMany(e => e.Emails)
            .WithOne(em => em.Info)
            .HasForeignKey(em => em.InfoId)
            .OnDelete(DeleteBehavior.Cascade);

        entity
            .HasOne(e => e.Student)
            .WithOne(s => s.Info)
            .HasForeignKey<Info>(e => e.StudentId)
            .OnDelete(DeleteBehavior.Cascade);

        entity
            .HasOne(e => e.Staff)
            .WithOne(s => s.Info)
            .HasForeignKey<Info>(e => e.StaffId)
            .OnDelete(DeleteBehavior.Cascade);

        entity
            .HasOne(e => e.School)
            .WithOne(s => s.Info)
            .HasForeignKey<Info>(e => e.SchoolId)
            .OnDelete(DeleteBehavior.Cascade);

        entity
            .HasOne(e => e.Parent)
            .WithOne(p => p.Info)
            .HasForeignKey<Info>(e => e.PerentId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
