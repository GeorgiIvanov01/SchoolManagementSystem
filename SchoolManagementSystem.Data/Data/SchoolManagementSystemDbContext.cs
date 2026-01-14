using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using SchoolManagementSystem.Data.Models;
using SchoolManagementSystem.Data.Models.Common;
using SchoolManagementSystem.Data.Data.Configurations;

namespace SchoolManagementSystem.Data.Data
{
    public class SchoolManagementSystemDbContext : IdentityDbContext<ApplicationUser, IdentityRole<int>, int>
    {
        public SchoolManagementSystemDbContext()
        {

        }

        public SchoolManagementSystemDbContext(DbContextOptions<SchoolManagementSystemDbContext> options)
            : base(options)
        {
        }

        public DbSet<School> Schools { get; set; } = null!;
        public DbSet<PhoneNumber> PhoneNumbers { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder
                .ApplyConfiguration(new SchoolConfiguration());

            builder
                .ApplyConfiguration(new PhoneNumberConfiguration());
        }
    }
}
