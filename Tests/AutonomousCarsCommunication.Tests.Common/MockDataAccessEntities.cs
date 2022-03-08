using System.Diagnostics.CodeAnalysis;
using AutonomousCarsCommunication.DataAccess.Entities;

namespace AutonomousCarsCommunication.Tests.Common
{
    [ExcludeFromCodeCoverage]
    public static class MockDataAccessEntities
    {
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
    }
}