using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UserService.Models;

namespace UserService.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions options) :
            base(options)
        {

        }
        public DbSet<User> User { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            List<IdentityRole> roles = new List<IdentityRole>
            {
                new IdentityRole
                {
                    Name = "Admin",
                    NormalizedName="ADMIN"
                },
                 new IdentityRole
                {
                    Name = "Customer",
                    NormalizedName="CUSTOMER"
                },
                  new IdentityRole
                {
                    Name = "Driver",
                    NormalizedName="DRIVER"
                }
            };

            builder.Entity<IdentityRole>().HasData(roles);

        }
    }
}
