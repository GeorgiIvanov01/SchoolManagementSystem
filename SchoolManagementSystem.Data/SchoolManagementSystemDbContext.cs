using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SchoolManagementSystem.Data.Models;

namespace SchoolManagementSystem.Data
{
    public class SchoolManagementSystemDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        public SchoolManagementSystemDbContext(DbContextOptions<SchoolManagementSystemDbContext> options)
            : base(options)
        {
        }
    }
}
