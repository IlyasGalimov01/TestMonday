using Domain.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class Context : IdentityDbContext<UserI, IdentityRole<int>, int>
    {
        public DbSet<UserI> Users { get; set; }
        public DbSet<Student> Students { get; set; }
        
        public Context(DbContextOptions<Context> options) : base(options) {}
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Student>().HasData(
                new Student { Id = 1, Firstname = "Ilyas", Lastname = "Galimov", Description = "Ученик группы C# 16", Phone = 0990969480}
            );
        }
    }
}