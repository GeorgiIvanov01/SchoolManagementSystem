using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace SchoolManagementSystem.Data
{
    public class SchoolManagementSystemDbContext : IdentityDbContext
    {
        public SchoolManagementSystemDbContext(DbContextOptions<SchoolManagementSystemDbContext> options)
            : base(options)
        {
        }
    }
}
