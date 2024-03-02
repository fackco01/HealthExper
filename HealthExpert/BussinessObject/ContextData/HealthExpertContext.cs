using BussinessObject.Model;
using BussinessObject.Model.Authen;
using BussinessObject.Model.ModelCourse;
using BussinessObject.Model.ModelUser;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObject.ContextData
{
    public class HealthExpertContext : DbContext
    {
        public HealthExpertContext()
        {
        }

        public virtual DbSet<Account> accounts { get; set; }
        public virtual DbSet<Avatar> avatars { get; set; }
        public virtual DbSet<Photo> photos { get; set; }
        public virtual DbSet<Accomplishment> accomplishments { get; set; }
        public virtual DbSet<BMI> bmis { get; set; }
        public virtual DbSet<Role> roles { get; set; }
        public virtual DbSet<Course> courses { get; set; }
        public virtual DbSet<Enrollment> enrollments { get; set; }
        public virtual DbSet<Feedback> feedbacks { get; set; }
        public virtual DbSet<CourseAdmin> courseAdmins { get; set; }
        public virtual DbSet<CourseManagement> courseManagements { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfiguration configuration = builder.Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CourseAdmin>().HasKey(CourseAdmin => new { CourseAdmin.accountId, CourseAdmin.courseId });
            modelBuilder.Entity<Enrollment>().HasKey(Enrollment => new { Enrollment.accountId, Enrollment.courseId });
            modelBuilder.Entity<Feedback>().HasKey(Feedback => new { Feedback.accountId, Feedback.courseId });
            modelBuilder.Entity<CourseManagement>().HasKey(CourseManagement => new { CourseManagement.courseManagerId, CourseManagement.courseId });
            modelBuilder.Entity<Course_CourseManager_Mapping>().HasKey(Course_CourseManager_Mapping => new { Course_CourseManager_Mapping.courseId, Course_CourseManager_Mapping.courseManagerId });

            modelBuilder.Entity<Role>().HasData(
                new Role { roleId = 1, roleName = "Administration" },
                new Role { roleId = 2, roleName = "CourseAdmin" },
                new Role { roleId = 3, roleName = "CourseManager" },
                new Role { roleId = 4, roleName = "Learner" }
                );

            modelBuilder.Entity<Account>().HasData(
                new Account
                {
                    accountId = Guid.NewGuid(),
                    userName = "admin",
                    password = "123123Aa!",
                    email = "admin@gmail.com",
                    fullName = "Administrator",
                    gender = true,
                    phone = "012345678",
                    birthDate = "01/01/1999",
                    isActive = true,
                    roleId = 1
                }
                );
        }
    }
}
