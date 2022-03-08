using System.Diagnostics.CodeAnalysis;

namespace AutonomousCarsCommunication.Domain.Entities
{
    [ExcludeFromCodeCoverage]
    public class Event
    {
        public int Id { get; set; }
        public string Details { get; set; }
        public List<int> InvolvedCars { get; set; }

        public Event()
        {
            InvolvedCars = new List<int>();
        }
    }
}