using System.Diagnostics.CodeAnalysis;

namespace AutonomousCarsCommunication.Domain.Entities
{
    [ExcludeFromCodeCoverage]
    public class Car
    {
        public int Id { get; set; }
        public string ManufacturerName { get; set; }
        public string Model { get; set; }
        public string ImagePath { get; set; }

        public float SpeedInKmH { get; set; }
        public Position Position { get; set; }
    }
}