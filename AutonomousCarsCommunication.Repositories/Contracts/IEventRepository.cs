using AutonomousCarsCommunication.Domain.Entities;

namespace AutonomousCarsCommunication.Repositories.Contracts
{
    public interface IEventRepository
    {
        public Event GetById(int id);
        public List<Event> GetAll();

        public Event Add(Event evnt);
        public Event Edit(Event evnt);
        public void Delete(int id);
    }
}