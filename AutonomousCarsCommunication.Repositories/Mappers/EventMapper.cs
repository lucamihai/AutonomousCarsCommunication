using AutonomousCarsCommunication.DataAccess.Entities;
using AutonomousCarsCommunication.Repositories.Contracts.Mappers;
using Event = AutonomousCarsCommunication.Domain.Entities.Event;

namespace AutonomousCarsCommunication.Repositories.Mappers
{
    public class EventMapper : IEventMapper
    {
        public Event GetDomainEvent(DataAccess.Entities.Event dataAccessEvent)
        {
            if (dataAccessEvent == null)
            {
                throw new ArgumentNullException(nameof(dataAccessEvent));
            }

            return new Event
            {
                Id = dataAccessEvent.Id,
                Details = dataAccessEvent.Details,
                InvolvedCars = dataAccessEvent.CarEvents.Select(x => x.CarId).ToList()
            };
        }

        public DataAccess.Entities.Event GetDataAccessEvent(Event domainEvent)
        {
            if (domainEvent == null)
            {
                throw new ArgumentNullException(nameof(domainEvent));
            }

            return new DataAccess.Entities.Event
            {
                Id = domainEvent.Id,
                Details = domainEvent.Details,
                CarEvents = domainEvent.InvolvedCars.Select(x => new CarEvent{CarId = x}).ToList()
            };
        }
    }
}