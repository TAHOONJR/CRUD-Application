using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class AppDbContext : IdentityDbContext<IdentityUser> //DbContext is a class that is used to connect to the database
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Items> Items { get; set; } //to call the Items model
        //public DbSet<Users> Users { get; set; } //to call the Users model

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole()
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Admin",
                NormalizedName = "admin",
                ConcurrencyStamp = Guid.NewGuid().ToString(),
            },
            new IdentityRole()
            {
                Id = Guid.NewGuid().ToString(),
                Name = "User",
                NormalizedName = "user",
                ConcurrencyStamp = Guid.NewGuid().ToString(),
            });

            base.OnModelCreating(modelBuilder);
        }
    }


}



