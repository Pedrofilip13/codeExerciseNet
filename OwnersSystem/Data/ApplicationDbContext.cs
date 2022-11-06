using Microsoft.EntityFrameworkCore;
using OwnersSystem.Models;

namespace OwnersSystem.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Owner> Owners { get; set; }

        public DbSet<Vehicle> Vehicles { get; set; }

        public DbSet<Claim> Claims { get; set; }


    }
}
