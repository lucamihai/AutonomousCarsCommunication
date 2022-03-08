using System.Diagnostics.CodeAnalysis;
using AutonomousCarsCommunication.Domain.Entities;

namespace AutonomousCarsCommunication.Tests.Common
{
    [ExcludeFromCodeCoverage]
    public static class MockDomainEntities
    {
        public static List<Car> GetCarList()
        {
            return new List<Car>
            {
                Car1,
                Car2,
                Car3
            };
        }

        public static Car Car1 => new Car
        {
            Id = MockValues.CarId1,
            ManufacturerId = MockValues.CarManufacturerId1,
            Model = MockValues.CarModel1,
            Position = new Position { X = MockValues.CarPositionX1, Y = MockValues.CarPositionY1 },
            SpeedInKmH = MockValues.CarSpeedInKmH1
        };

        public static Car Car2 => new Car
        {
            Id = MockValues.CarId2,
            ManufacturerId = MockValues.CarManufacturerId2,
            Model = MockValues.CarModel2,
            Position = new Position { X = MockValues.CarPositionX2, Y = MockValues.CarPositionY2 },
            SpeedInKmH = MockValues.CarSpeedInKmH2
        };

        public static Car Car3 => new Car
        {
            Id = MockValues.CarId3,
            ManufacturerId = MockValues.CarManufacturerId3,
            Model = MockValues.CarModel3,
            Position = new Position { X = MockValues.CarPositionX3, Y = MockValues.CarPositionY3 },
            SpeedInKmH = MockValues.CarSpeedInKmH3
        };
    }
}