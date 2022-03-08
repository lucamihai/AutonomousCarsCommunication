using System;
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

        private List<Car> allCars;
        private Car currentUserCar;

        [TestInitialize]
        public void Setup()
        {
            carRepositoryMock = new Mock<ICarRepository>();
            eventRepositoryMock = new Mock<IEventRepository>();
            authorizationServiceMock = new Mock<IAuthorizationService>();

            carInteractionBusinessLogic = new CarInteractionBusinessLogic(
                carRepositoryMock.Object,
                eventRepositoryMock.Object,
                authorizationServiceMock.Object);

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
        public void TestThatGetMyCarCallsAuthorizationServiceGetCurrentUserCar()
        {
            carInteractionBusinessLogic.GetMyCar();

            authorizationServiceMock.Verify(x => x.GetCurrentUserCar(), Times.Once);
        }

        [TestMethod]
        public void TestThatSendMessageToCarMakesExpectedCalls()
        {
            var car = MockDomainEntities.Car3;
            const string message = "Hello there";

            carInteractionBusinessLogic.SendMessageToCar(car, message);

            Func<Event, bool> isExpectedEvent = evnt =>
                evnt.Details.Contains(message)
                && evnt.InvolvedCars.Count == 2
                && evnt.InvolvedCars[0] == currentUserCar.Id
                && evnt.InvolvedCars[1] == car.Id;
            authorizationServiceMock.Verify(x => x.GetCurrentUserCar(), Times.Once);
            eventRepositoryMock.Verify(x => x.Add(It.Is<Event>(e => isExpectedEvent(e))));
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