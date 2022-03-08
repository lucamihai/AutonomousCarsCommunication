using AutonomousCarsCommunication.DataAccess.Contracts;
using AutonomousCarsCommunication.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace AutonomousCarsCommunication.DataAccess
{
    public class DataContext : DbContext, IDataContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Event> Events { get; set; }
    }
}