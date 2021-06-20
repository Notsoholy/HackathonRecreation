using Application.Interfaces;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.DbContexts
{
    public class RecreationDbContext : DbContext, IRecreationDbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<UserMessage> UserMessages { get; set; }
        public DbSet<AdditionalService> AdditionalServices { get; set; }
        public DbSet<Disease> Diseases { get; set; }
        public DbSet<HealingMethod> HealingMethods { get; set; }
        public DbSet<RecreationObject> RecreationObjects { get; set; }
        public DbSet<Location> Locations { get; set; }

        public RecreationDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("recreation_service");

            modelBuilder.Entity<RecreationObject>().OwnsOne(x => x.Contacts);
        }
    }
}
