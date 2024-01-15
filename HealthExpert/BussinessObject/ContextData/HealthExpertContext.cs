using BussinessObject.Model;
using BussinessObject.Model.Authen;
using BussinessObject.Model.FileCourse;
using BussinessObject.Model.FilePayment;
using BussinessObject.Model.FilePost;
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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfiguration configuration = builder.Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Business> Businesss { get; set; }
        public virtual DbSet<BMI> BMIs { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<CourseContent> CourseContents { get; set; }
        public virtual DbSet<Enrollment> Enrollments { get; set; }
        public virtual DbSet<Payment> Payment { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<PostComment> PostComments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Role>().HasData(
                new Role { roleId = 1, roleName = "Administration" },
                new Role { roleId = 2, roleName = "Enterprise" },
                new Role { roleId = 3, roleName = "Customer" }
                );

            modelBuilder.Entity<User>().HasData(
                new User {userId = Guid.NewGuid(),
                    userName = "admin",
                    password = "123123Aa!",
                    email = "admin@gmail.com",
                    firstName = "ADMIN",
                    lastName = "01",
                    gender = true,
                    phone = "012345678",
                    birthDate = "01/01/1999",
                    avatar = null,
                    wallpaper = null,
                    isActive = true,
                    roleId = 1 }
                );

            modelBuilder.Entity<CourseContent>().HasNoKey();
        }
    }
}
