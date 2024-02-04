using Microsoft.EntityFrameworkCore;
using TestingEF.DAL.Entities;

namespace TestingEF.DAL
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<User> Users { get; set; }
        //public DbSet<WorkDay> WorkDays { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> opt) : base(opt)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cinema>()
               .HasOne(c => c.Company)
               .WithMany(co => co.Cinemas)
               .HasForeignKey(c => c.CompanyId);

            modelBuilder.Entity<User>()
                .HasOne(u => u.Company)
                .WithMany(co => co.Users)
                .HasForeignKey(u => u.CompanyId);

            //modelBuilder.Entity<Cinema>()
            //    .HasMany(c => c.WorkDays)
            //    .WithOne(wd => wd.Cinema)
            //    .HasForeignKey(wd => wd.CinemaId);

            //modelBuilder.Entity<User>()
            //    .HasMany(u => u.WorkDays)
            //    .WithOne(wd => wd.User)
            //    .HasForeignKey(wd => wd.UserId);
        }
    }
}
