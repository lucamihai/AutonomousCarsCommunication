using System.Diagnostics.CodeAnalysis;

namespace AutonomousCarsCommunication.DataAccess.Entities
{
    [ExcludeFromCodeCoverage]
    public class Car
    {
        public int Id { get; set; }
        public int ManufacturerId { get; set; }
        public string Model { get; set; }

        public float SpeedInKmH { get; set; }
        public Position Position { get; set; }
    }
}