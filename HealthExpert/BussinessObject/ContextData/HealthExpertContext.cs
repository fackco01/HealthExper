using BussinessObject.Model;
using BussinessObject.Model.Authen;
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Role>().HasData(
                new Role { roleId = 1, roleName = "Administration" },
                new Role { roleId = 2, roleName = "Enterprise" },
                new Role { roleId = 3, roleName = "Customer" }
                );

            modelBuilder.Entity<User>().HasData(
                new User {userId = Guid.NewGuid(), userName = "admin", password = "123123Aa!", email = "admin@gmail.com", firstName = "ADMIN", lastName = "01", gender = true, phone = "012345678", roleId = 1 }
                );
        }
    }
}
