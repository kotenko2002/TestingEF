using Microsoft.EntityFrameworkCore;
using TestingEF.DAL.Entities;

namespace TestingEF.DAL
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<WorkDay> WorkDays { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> opt) : base(opt)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cinema>()
                .HasOne(c => c.Company)
                .WithMany(co => co.Cinemas)
                .HasForeignKey(c => c.CompanyId)
                .OnDelete(DeleteBehavior.NoAction); // or .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<User>()
                .HasOne(u => u.Company)
                .WithMany(co => co.Users)
                .HasForeignKey(u => u.CompanyId)
                .OnDelete(DeleteBehavior.NoAction); // or .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<WorkDay>()
                .HasOne(wd => wd.Cinema)
                .WithMany(c => c.WorkDays)
                .HasForeignKey(wd => wd.CinemaId)
                .OnDelete(DeleteBehavior.NoAction); // or .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<WorkDay>()
                .HasOne(wd => wd.User)
                .WithMany(u => u.WorkDays)
                .HasForeignKey(wd => wd.UserId)
                .OnDelete(DeleteBehavior.NoAction); // or .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
