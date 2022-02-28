using DataAccessLayer.EntityMappers;
using DataAccessLayer.Models;
using DataAccessLayer.SeedData;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.ApplicationDbContext
{
    public partial class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Person> persons { get; set; }
        public DbSet<Client> clients{ get; set; }
        public DbSet<Account> account { get; set; }
        public DbSet<Movement> movements { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PersonMap());
            modelBuilder.ApplyConfiguration(new ClientMap());
            modelBuilder.ApplyConfiguration(new AccountMap());
            modelBuilder.ApplyConfiguration(new MovementMap());
            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();
        }
    }
}
