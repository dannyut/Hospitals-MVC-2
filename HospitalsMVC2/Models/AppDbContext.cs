using Microsoft.EntityFrameworkCore;

namespace HospitalsMVC2.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Hospital> Hospitals { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed data
            modelBuilder.Entity<Hospital>().HasData(new Hospital
            {
                HospitalId = 1,
                Name = "UT Southwestern Medical Center",
                Address = "Dallas, TX",
                Email = "UTSMC@test.com",
                Phone = "(123) 123-4567"
            });
            modelBuilder.Entity<Hospital>().HasData(new Hospital
            {
                HospitalId = 2,
                Name = "Baylor University Medical Center",
                Address = "Dallas, TX",
                Email = "BUMC@test.com",
                Phone = "(111) 111-1111"
            });
            modelBuilder.Entity<Hospital>().HasData(new Hospital
            {
                HospitalId = 3,
                Name = "Medical City Dallas",
                Address = "Dallas, TX",
                Email = "MCD@test.com",
                Phone = "(222) 222-2222"
            });

        }

    }

}
