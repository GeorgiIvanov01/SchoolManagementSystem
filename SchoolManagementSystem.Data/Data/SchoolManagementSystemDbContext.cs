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
        public virtual DbSet<Grade> Grades { get; set; } = null!;
        public virtual DbSet<Attendance> Attendances { get; set; } = null!;
        public  DbSet<ParentStudent> ParentStudents { get; set; } = null!;
        public  DbSet<StudentClass> StudentClasses { get; set; } = null!;
        public  DbSet<StaffRoleAssignment> StaffRoleAssignments { get; set; } = null!;


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new SchoolConfiguration());
            modelBuilder.ApplyConfiguration(new ClassConfiguration());
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfiguration(new StaffConfiguration());
            modelBuilder.ApplyConfiguration(new ParentConfiguration());
            modelBuilder.ApplyConfiguration(new SubjectConfiguration());
            modelBuilder.ApplyConfiguration(new GradeConfiguration());
            modelBuilder.ApplyConfiguration(new AttendanceConfiguration());
            modelBuilder.ApplyConfiguration(new ParentStudentConfiguration());
            modelBuilder.ApplyConfiguration(new StudentClassConfiguration());
            modelBuilder.ApplyConfiguration(new StaffRoleAssignmentConfiguration());
        }
    }
}
