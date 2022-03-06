using AutonomousCarsCommunication.Domain.Entities;

namespace AutonomousCarsCommunication.Repositories.Contracts.Mappers
{
    public interface IEventMapper
    {
        Event GetDomainEvent(DataAccess.Entities.Event dataAccessEvent);
        DataAccess.Entities.Event GetDataAccessEvent(Event domainEvent);
    }
}