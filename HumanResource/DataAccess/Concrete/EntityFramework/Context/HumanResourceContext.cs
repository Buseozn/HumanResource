using System;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework.Context
{
    public class HumanResourceContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=localhost;user=SA;password=reallyStrongPwd123;database=HumanResource;TrustServerCertificate=true;Integrated Security=false;");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Project> Projects { get; set; }

    }
}

