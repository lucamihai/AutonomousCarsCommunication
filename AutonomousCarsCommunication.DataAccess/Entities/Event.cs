using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace AutonomousCarsCommunication.DataAccess.Entities
{
    [ExcludeFromCodeCoverage]
    public class Event
    {
        public Event()
        {
            CarEvents = new HashSet<CarEvent>();
        }

        [Key]
        public int Id { get; set; }
        public string Details { get; set; }

        public virtual ICollection<CarEvent> CarEvents { get; set; }
    }
}