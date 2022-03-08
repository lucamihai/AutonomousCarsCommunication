﻿using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace AutonomousCarsCommunication.DataAccess.Entities
{
    [ExcludeFromCodeCoverage]
    public class Car
    {
        public Car()
        {
            CarEvents = new HashSet<CarEvent>();
        }

        [Key]
        public int Id { get; set; }
        public int ManufacturerId { get; set; }
        public string Model { get; set; }

        public float SpeedInKmH { get; set; }
        public Position Position { get; set; }

        public virtual ICollection<CarEvent> CarEvents { get; set; }
    }
}