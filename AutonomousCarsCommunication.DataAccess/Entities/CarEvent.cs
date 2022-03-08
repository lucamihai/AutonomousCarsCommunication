using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace AutonomousCarsCommunication.DataAccess.Entities
{
    [ExcludeFromCodeCoverage]
    public class CarEvent
    {
        public int CarId { get; set; }
        [ForeignKey("CarId")]
        public virtual Car Car { get; set; }

        public int EventId { get; set; }
        [ForeignKey("DisciplineId")]
        public virtual Event Event { get; set; }
    }
}