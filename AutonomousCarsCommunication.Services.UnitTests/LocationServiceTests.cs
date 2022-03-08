using System.Diagnostics.CodeAnalysis;
using System.Linq;
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

        [TestMethod]
        public void TestThatGetClosestCarReturnsExpectedCar()
        {
            var car = MockDomainEntities.Car1;
            var allCars = MockDomainEntities.GetCarList();

            var closestCar = locationService.GetClosestCar(car, allCars);

            var allCarsExceptCurrentUserCar = allCars.Where(x => x.Id != car.Id).ToList();
            var expectedCar = allCarsExceptCurrentUserCar.First();
            Assert.AreEqual(expectedCar, closestCar);
        }
    }
}