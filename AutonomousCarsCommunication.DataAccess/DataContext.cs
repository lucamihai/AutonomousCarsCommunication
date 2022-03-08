using System.Diagnostics.CodeAnalysis;
using AutonomousCarsCommunication.DataAccess.Contracts;
using AutonomousCarsCommunication.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace AutonomousCarsCommunication.DataAccess
{
    [ExcludeFromCodeCoverage]
    public class DataContext : DbContext, IDataContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Event> Events { get; set; }

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