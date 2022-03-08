using AutonomousCarsCommunication.DataAccess.Contracts;
using AutonomousCarsCommunication.DataAccess.Entities;
using AutonomousCarsCommunication.Repositories.Contracts;
using AutonomousCarsCommunication.Repositories.Contracts.Mappers;
using Event = AutonomousCarsCommunication.Domain.Entities.Event;

namespace AutonomousCarsCommunication.Repositories
{
    public class EventRepository : IEventRepository
    {
        private readonly IDataContext dataContext;
        private readonly IEventMapper eventMapper;

        public EventRepository(IDataContext dataContext, IEventMapper eventMapper)
        {
            this.dataContext = dataContext;
            this.eventMapper = eventMapper;
        }

        public Event GetById(int id)
        {
            if (id < 1)
            {
                throw new ArgumentException("Id should be at least 1");
            }

            var dataAccessEvent = dataContext.Events.FirstOrDefault(x => x.Id == id);

            if (dataAccessEvent == null)
            {
                throw new InvalidOperationException($"There is no event with id: {id}");
            }

            return eventMapper.GetDomainEvent(dataAccessEvent);
        }

        public List<Event> GetAll()
        {
            return dataContext.Events
                .Select(eventMapper.GetDomainEvent)
                .ToList();
        }

        public Event Add(Event evnt)
        {
            if (evnt == null)
            {
                throw new ArgumentNullException(nameof(evnt));
            }

            ValidateOrThrow(evnt);

            var dataAccessEvent = eventMapper.GetDataAccessEvent(evnt);
            dataAccessEvent.Id = 0;
            var addedEvent = dataContext.Events.Add(dataAccessEvent);
            dataContext.SaveChanges();

            return eventMapper.GetDomainEvent(addedEvent.Entity);
        }

        public Event Edit(Event evnt)
        {
            if (evnt == null)
            {
                throw new ArgumentNullException(nameof(evnt));
            }

            ValidateOrThrow(evnt);

            if (evnt.Id < 1)
            {
                throw new ArgumentException("Id should be at least 1");
            }

            var existingEvent = dataContext.Events.FirstOrDefault(x => x.Id == evnt.Id);

            if (existingEvent == null)
            {
                throw new InvalidOperationException($"There is no event with id: {evnt.Id}");
            }
            
            existingEvent.Details = evnt.Details;
            existingEvent.CarEvents.Clear();

            foreach (var involvedCarId in evnt.InvolvedCars)
            {
                existingEvent.CarEvents.Add(new CarEvent{CarId = involvedCarId});
            }

            dataContext.SaveChanges();

            return eventMapper.GetDomainEvent(existingEvent);
        }

        public void Delete(int id)
        {
            if (id < 1)
            {
                throw new ArgumentException("Id should be at least 1");
            }

            var dataAccessEvent = dataContext.Events.FirstOrDefault(x => x.Id == id);

            if (dataAccessEvent == null)
            {
                throw new InvalidOperationException($"There is no event with id: {id}");
            }

            dataContext.Events.Remove(dataAccessEvent);
            dataContext.SaveChanges();
        }

        // TODO: Could extract this into a separate service
        private static void ValidateOrThrow(Event evnt)
        {
            if (string.IsNullOrWhiteSpace(evnt.Details))
            {
                throw new ArgumentException("Event Details should be not empty");
            }

            if (evnt.InvolvedCars == null)
            {
                throw new ArgumentException("Event InvolvedCars cannot be null");
            }
        }
    }
}