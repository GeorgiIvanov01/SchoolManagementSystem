using Microsoft.EntityFrameworkCore;
using SchoolManagementSystem.Data.Data.Common;
using SchoolManagementSystem.Data.Data.Configurations;
using SchoolManagementSystem.Data.Data.Models;

namespace SchoolManagementSystem.Data.Data
{
    public class SchoolManagementSystemDbContext : DbContext
    {
        public SchoolManagementSystemDbContext()
        {

        }

        public SchoolManagementSystemDbContext(DbContextOptions options) 
            : base(options) 
        {

        }

        public virtual DbSet<School> Schools { get; set; } = null!;
        public virtual DbSet<Class> Classes { get; set; } = null!;
        public virtual DbSet<Student> Students { get; set; } = null!;
        public virtual DbSet<Staff> Staff { get; set; } = null!;
        public virtual DbSet<Parent> Parents { get; set; } = null!;
        public virtual DbSet<Subject> Subjects { get; set; } = null!;
        public virtual DbSet<StaffRoleAssignment> StaffRoleAssignments { get; set; } = null!;
        public virtual DbSet<Info> Infos { get; set; } = null!;



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AbsenceConfiguration());
            modelBuilder.ApplyConfiguration(new ClassConfiguration());
            modelBuilder.ApplyConfiguration(new DailyProgramConfiguration());
            modelBuilder.ApplyConfiguration(new ExamConfiguration());
            modelBuilder.ApplyConfiguration(new GradeConfiguration());
            modelBuilder.ApplyConfiguration(new InfoConfiguration());
            modelBuilder.ApplyConfiguration(new ParentConfiguration());
            modelBuilder.ApplyConfiguration(new ParentStudentConfiguration());
            modelBuilder.ApplyConfiguration(new SchoolConfiguration());
            modelBuilder.ApplyConfiguration(new StaffConfiguration());
            modelBuilder.ApplyConfiguration(new StaffRoleAssignmentConfiguration());
            modelBuilder.ApplyConfiguration(new StaffSubjectConfiguration());
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfiguration(new SubjectConfiguration());
            modelBuilder.ApplyConfiguration(new SubjectDailyProgramConfiguration());
        }
    }
}
