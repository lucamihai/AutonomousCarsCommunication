using AutonomousCarsCommunication.Domain.Entities;
using AutonomousCarsCommunication.Repositories.Contracts.Mappers;

namespace AutonomousCarsCommunication.Repositories.Mappers
{
    public class EventMapper : IEventMapper
    {
        public Event GetDomainEvent(DataAccess.Entities.Event dataAccessEvent)
        {
            throw new NotImplementedException();
        }

        public DataAccess.Entities.Event GetDataAccessEvent(Event domainEvent)
        {
            throw new NotImplementedException();
        }
    }
}