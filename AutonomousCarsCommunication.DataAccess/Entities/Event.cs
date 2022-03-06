using System.Diagnostics.CodeAnalysis;

namespace AutonomousCarsCommunication.DataAccess.Entities
{
    [ExcludeFromCodeCoverage]
    public class Event
    {
        public EventType EventType { get; set; }
        public string Details { get; set; }
        public List<int> InvolvedCars { get; set; }

        public Event()
        {
            Details = string.Empty;
            InvolvedCars = new List<int>();
        }
    }
}