using System.Diagnostics.CodeAnalysis;

namespace AutonomousCarsCommunication.Tests.Common
{
    [ExcludeFromCodeCoverage]
    public static class MockValues
    {
        public const int CarId1 = 1;
        public const int CarId2 = 2;
        public const int CarId3 = 3;

        public const string CarManufacturerName1 = "CarManufacturerName1";
        public const string CarManufacturerName2 = "CarManufacturerName2";
        public const string CarManufacturerName3 = "CarManufacturerName3";

        public const string CarModel1 = "CarModel1";
        public const string CarModel2 = "CarModel2";
        public const string CarModel3 = "CarModel3";

        public const float CarSpeedInKmH1 = 100;
        public const float CarSpeedInKmH2 = 130;
        public const float CarSpeedInKmH3 = 131;

        public const float CarPositionX1 = 2;
        public const float CarPositionY1 = 3;
        public const float CarPositionX2 = 20;
        public const float CarPositionY2 = 30;
        public const float CarPositionX3 = 100;
        public const float CarPositionY3 = 101;

        public const float DistanceBetweenCar1AndCar2 = 32.449961f;


        public const int EventId1 = 1;
        public const int EventId2 = 2;
        public const int EventId3 = 3;

        public const string EventDetails1 = "Car ran out of gas. Silly driver.";
        public const string EventDetails2 = "Car's exhaust turned into a smoke grenade. Change the oil already ffs";
        public const string EventDetails3 = "Driver tried to insert gas into their electric car. Shocking.";
    }
}