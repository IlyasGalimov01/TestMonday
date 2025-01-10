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
    }
}