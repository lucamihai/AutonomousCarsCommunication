using System.Diagnostics.CodeAnalysis;
using AutonomousCarsCommunication.Tests.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutonomousCarsCommunication.Services.UnitTests
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public class LocationServiceTests
    {
        private LocationService locationService;

        [TestInitialize]
        public void Setup()
        {
            locationService = new LocationService();
        }

        [TestMethod]
        public void TestThatGetDistanceBetweenCarsReturnsExpectedDistance()
        {
            var car1 = MockDomainEntities.Car1;
            var car2 = MockDomainEntities.Car2;

            var distance = locationService.GetDistanceBetweenCars(car1, car2);

            Assert.AreEqual(MockValues.DistanceBetweenCar1AndCar2, distance);
        }
    }
}