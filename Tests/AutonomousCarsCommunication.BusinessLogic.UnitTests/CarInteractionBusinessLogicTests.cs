using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using AutonomousCarsCommunication.Domain.Entities;
using AutonomousCarsCommunication.Repositories.Contracts;
using AutonomousCarsCommunication.Services.Contracts;
using AutonomousCarsCommunication.Tests.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace AutonomousCarsCommunication.BusinessLogic.UnitTests
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public class CarInteractionBusinessLogicTests
    {
        private CarInteractionBusinessLogic carInteractionBusinessLogic;
        private Mock<ICarRepository> carRepositoryMock;
        private Mock<IEventRepository> eventRepositoryMock;
        private Mock<IAuthorizationService> authorizationServiceMock;
        private Mock<ILocationService> locationServiceMock;

        private List<Car> allCars;
        private Car currentUserCar;

        [TestInitialize]
        public void Setup()
        {
            carRepositoryMock = new Mock<ICarRepository>();
            eventRepositoryMock = new Mock<IEventRepository>();
            authorizationServiceMock = new Mock<IAuthorizationService>();
            locationServiceMock = new Mock<ILocationService>();

            carInteractionBusinessLogic = new CarInteractionBusinessLogic(
                carRepositoryMock.Object,
                eventRepositoryMock.Object,
                authorizationServiceMock.Object,
                locationServiceMock.Object);

            SetupCarRepositoryMock();
            SetupAuthorizationServiceMock();
        }

        [TestMethod]
        public void TestThatGetAllCarsCallsCarRepositoryGetAll()
        {
            carInteractionBusinessLogic.GetAllCars();

            carRepositoryMock.Verify(x => x.GetAll(), Times.Once);
        }

        [TestMethod]
        public void TestThatGetClosestCarMakesExpectedCalls()
        {
            carInteractionBusinessLogic.GetClosestCar();

            var allCarsExceptCurrentUserCar = allCars.Where(x => x.Id != currentUserCar.Id).ToList();
            authorizationServiceMock.Verify(x => x.GetCurrentUserCar(), Times.Once);
            carRepositoryMock.Verify(x => x.GetAll(), Times.Once);
            locationServiceMock.Verify(x => x.GetDistanceBetweenCars(currentUserCar, It.IsAny<Car>()), Times.Exactly(allCarsExceptCurrentUserCar.Count));
            foreach (var existingCar in allCarsExceptCurrentUserCar)
            {
                locationServiceMock.Verify(x => x.GetDistanceBetweenCars(currentUserCar, existingCar), Times.Once);
            }
        }

        [TestMethod]
        public void TestThatGetClosestCarReturnsExpectedCar()
        {
            locationServiceMock
                .SetupSequence(x => x.GetDistanceBetweenCars(currentUserCar, It.IsAny<Car>()))
                .Returns(50)
                .Returns(10);

            var closestCar = carInteractionBusinessLogic.GetClosestCar();

            var allCarsExceptCurrentUserCar = allCars.Where(x => x.Id != currentUserCar.Id).ToList();
            var expectedCar = allCarsExceptCurrentUserCar.Last();
            Assert.AreEqual(expectedCar, closestCar);
        }

        [TestMethod]
        public void TestThatGetDistanceToCarMakesExpectedCalls()
        {
            var car = MockDomainEntities.Car1;

            carInteractionBusinessLogic.GetDistanceToCar(car);

            authorizationServiceMock.Verify(x => x.GetCurrentUserCar(), Times.Once);
            locationServiceMock.Verify(x => x.GetDistanceBetweenCars(currentUserCar, car), Times.Once);
        }

        [TestMethod]
        public void TestThatSetCurrentSpeedMakesExpectedCalls()
        {
            const float speed = 80;
            var speedBeforeCall = currentUserCar.SpeedInKmH;

            carInteractionBusinessLogic.SetCurrentSpeed(speed);

            authorizationServiceMock.Verify(x => x.GetCurrentUserCar(), Times.Once);
            carRepositoryMock.Verify(x => x.Edit(It.Is<Car>(c => c == currentUserCar && c.SpeedInKmH == speed)), Times.Once);
            Assert.AreNotEqual(speedBeforeCall, speed);
        }

        private void SetupCarRepositoryMock()
        {
            allCars = MockDomainEntities.GetCarList();
            carRepositoryMock
                .Setup(x => x.GetAll())
                .Returns(allCars);
        }

        private void SetupAuthorizationServiceMock()
        {
            currentUserCar = MockDomainEntities.Car1;
            authorizationServiceMock
                .Setup(x => x.GetCurrentUserCar())
                .Returns(currentUserCar);
        }
    }
}