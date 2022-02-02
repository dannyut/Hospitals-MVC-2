using Microsoft.EntityFrameworkCore;

namespace HospitalsMVC2.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Hospital> Hospitals { get; set; }

    }

}
