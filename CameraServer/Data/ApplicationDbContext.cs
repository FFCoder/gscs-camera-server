using System;
using System.Collections.Generic;
using System.Text;
using CameraServer.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CameraServer.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<CameraModel> CameraModels { get; set; }
        public DbSet<Camera> Cameras { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<School> Schools { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=camera_data.db");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            
            builder.Entity<School>().HasData(new School {SchoolId = 1, Name = "Test School 1"});
            builder.Entity<School>().HasData(new School {SchoolId = 2, Name = "Test School 2"});
            base.OnModelCreating(builder);
        }
    }
}