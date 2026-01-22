using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolManagementSystem.Data.Data.Common;

public static class InfoModelBuilder
{
    public static void Configure<TOwner>(
        OwnedNavigationBuilder<TOwner, Info> entity)  
        where TOwner : class
    {

        entity
            .Property(i => i.Address)
              .HasMaxLength(300);


        entity
            .OwnsMany(i => i.PhoneNumbers, pn => {
            pn
              .HasKey("Id");

            pn
              .WithOwner()
              .HasForeignKey("OwnerId");

            pn
              .Property(p => p.Number)
              .HasMaxLength(30)
              .IsRequired(true);

            });


        entity
            .OwnsMany(i => i.Emails, em => {
            em
              .HasKey("Id");

            em
              .WithOwner()
              .HasForeignKey("OwnerId");

            em
              .Property(e => e.Email)
              .HasMaxLength(150)
              .IsRequired(true);
        });
    }
}
