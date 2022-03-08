using System.Diagnostics.CodeAnalysis;

namespace AutonomousCarsCommunication.Tests.Common
{
    [ExcludeFromCodeCoverage]
    public static class MockValues
    {
        public const int CarId1 = 1;
        public const int CarId2 = 2;

        public const int CarManufacturerId1 = 1;
        public const int CarManufacturerId2 = 2;

        public const string CarModel1 = "CarModel1";
        public const string CarModel2 = "CarModel2";

        public const float CarSpeedInKmH1 = 100;
        public const float CarSpeedInKmH2 = 130;

        public const float CarPositionX1 = 2;
        public const float CarPositionY1 = 3;
        public const float CarPositionX2 = 20;
        public const float CarPositionY2 = 30;

        public const float DistanceBetweenCar1AndCar2 = 32.449961f;
    }
}