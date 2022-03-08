using AutonomousCarsCommunication.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace AutonomousCarsCommunication.DataAccess.Contracts
{
    public interface IDataContext
    {
        DbSet<Car> Cars { get; set; }
        DbSet<Event> Events { get; set; }

        int SaveChanges();
    }
}