using System.Diagnostics.CodeAnalysis;

namespace AutonomousCarsCommunication.Domain.Entities
{
    [ExcludeFromCodeCoverage]
    public struct Position
    {
        public float X { get; set; }
        public float Y { get; set; }

        public override string ToString()
        {
            return $"X:{X} Y:{Y}";
        }
    }
}