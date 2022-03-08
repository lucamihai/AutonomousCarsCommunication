using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using AutonomousCarsCommunication.Domain.Entities;
using AutonomousCarsCommunication.Repositories.Contracts;
using AutonomousCarsCommunication.Tests.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace AutonomousCarsCommunication.Services.UnitTests
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public class FakeAuthorizationServiceTests
    {
        private FakeAuthorizationService fakeAuthorizationService;
        private Mock<ICarRepository> carRepositoryMock;

        private List<Car> carsFromRepository;

        [TestInitialize]
        public void Setup()
        {
            carRepositoryMock = new Mock<ICarRepository>();

            fakeAuthorizationService = new FakeAuthorizationService(carRepositoryMock.Object);

            SetupCarRepositoryMock();
        }

        [TestMethod]
        public void TestThatGetCurrentUserCarCallsCarRepositoryGetAll()
        {
            fakeAuthorizationService.GetCurrentUserCar();

            carRepositoryMock.Verify(x => x.GetAll(), Times.Once);
        }

        [TestMethod]
        public void TestThatGetCurrentUserCarReturnsFirstCarFromRepository()
        {
            var car = fakeAuthorizationService.GetCurrentUserCar();

            Assert.AreEqual(carsFromRepository.First(), car);
        }

        private void SetupCarRepositoryMock()
        {
            carsFromRepository = MockDomainEntities.GetCarList();
            carRepositoryMock
                .Setup(x => x.GetAll())
                .Returns(carsFromRepository);
        }
    }
}