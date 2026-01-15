using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolManagementSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Data.Data.Configurations
{
    public class GradeBookConfiguration : IEntityTypeConfiguration<GradeBook>
    {
        public void Configure(EntityTypeBuilder<GradeBook> builder)
        {
            builder
                .HasKey(gb => gb.Id);

            builder
                .HasOne(gb => gb.Student)
                .WithOne(s => s.GradeBooks)
                .HasForeignKey<GradeBook>(gb => gb.StudentId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
