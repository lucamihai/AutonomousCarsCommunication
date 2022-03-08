using System.Diagnostics.CodeAnalysis;
using AutonomousCarsCommunication.DataAccess.Contracts;
using AutonomousCarsCommunication.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace AutonomousCarsCommunication.Tests.Common.TestHelpers
{
    [ExcludeFromCodeCoverage]
    public class InMemoryDataContext : DbContext, IDataContext
    {
        public InMemoryDataContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Event> Events { get; set; }

        public async Task<int> SaveChangesAsync()
        {
            return await base.SaveChangesAsync();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            CreateCarEventModel(modelBuilder);
        }

        private static void CreateCarEventModel(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CarEvent>()
                .HasKey(ed => new { ed.CarId, ed.EventId });

            modelBuilder.Entity<CarEvent>()
                .HasOne(ed => ed.Car)
                .WithMany(e => e.CarEvents)
                .HasForeignKey(ed => ed.CarId);

            modelBuilder.Entity<CarEvent>()
                .HasOne(ed => ed.Event)
                .WithMany(e => e.CarEvents)
                .HasForeignKey(ed => ed.EventId);
        }
    }
}