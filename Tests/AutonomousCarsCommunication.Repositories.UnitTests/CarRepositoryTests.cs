using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using AutonomousCarsCommunication.DataAccess.Contracts;
using AutonomousCarsCommunication.Domain.Entities;
using AutonomousCarsCommunication.Repositories.Contracts.Mappers;
using AutonomousCarsCommunication.Tests.Common;
using AutonomousCarsCommunication.Tests.Common.TestHelpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace AutonomousCarsCommunication.Repositories.UnitTests
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public class CarRepositoryTests
    {
        private CarRepository carRepository;
        private InMemoryDataContext inMemoryDataContext;
        private Mock<IDataContext> dataContextMock;
        private Mock<ICarMapper> carMapperMock;

        private Car domainCarFromMapper;
        private DataAccess.Entities.Car dataAccessCarFromMapper;

        [TestInitialize]
        public void Setup()
        {
            dataContextMock = new Mock<IDataContext>();
            carMapperMock = new Mock<ICarMapper>();

            carRepository = new CarRepository(dataContextMock.Object, carMapperMock.Object);

            SetupDataContextMock();
            SetupCarMapperMock();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestThatWhenIdIsLessThanOneGetByIdThrowsArgumentException()
        {
            carRepository.GetById(0);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestThatWhenCarDoesNotExistGetByIdThrowsInvalidOperationException()
        {
            var totallyNotExistingId = inMemoryDataContext.Cars.Select(x => x.Id).Sum();

            carRepository.GetById(totallyNotExistingId);
        }

        [TestMethod]
        public void TestThatGetByIdMakesExpectedCalls()
        {
            carRepository.GetById(1);

            dataContextMock.Verify(x => x.Cars, Times.Once);
            carMapperMock.Verify(x => x.GetDomainCar(It.IsAny<DataAccess.Entities.Car>()), Times.Once);
        }

        [TestMethod]
        public void TestThatGetAllCarsMakesExpectedCalls()
        {
            carRepository.GetAll();

            var carCount = inMemoryDataContext.Cars.Count();
            dataContextMock.Verify(x => x.Cars, Times.Once);
            carMapperMock.Verify(x => x.GetDomainCar(It.IsAny<DataAccess.Entities.Car>()), Times.Exactly(carCount));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestThatWhenCarIsNullAddThrowsArgumentNullException()
        {
            carRepository.Add(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestThatWhenCarIsNotValidAddThrowsArgumentException()
        {
            var car = MockDomainEntities.Car2;
            car.SpeedInKmH = 9999;

            carRepository.Add(car);
        }

        [TestMethod]
        public void TestThatAddMakesExpectedCalls()
        {
            var car = MockDomainEntities.Car2;

            carRepository.Add(car);

            carMapperMock.Verify(x => x.GetDataAccessCar(car), Times.Once);
            dataContextMock.Verify(x => x.Cars, Times.Once);
            carMapperMock.Verify(x => x.GetDomainCar(It.IsAny<DataAccess.Entities.Car>()), Times.Once);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestThatWhenCarIsNullEditThrowsArgumentNullException()
        {
            carRepository.Edit(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestThatWhenCarIsNotValidEditThrowsArgumentException()
        {
            var car = MockDomainEntities.Car2;
            car.SpeedInKmH = 9999;

            carRepository.Edit(car);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestThatWhenCarIdIsLessThanOneEditThrowsArgumentException()
        {
            var car = MockDomainEntities.Car2;
            car.Id = 0;

            carRepository.Edit(car);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestThatWhenCarDoesNotExistEditThrowsInvalidOperationException()
        {
            var totallyNotExistingId = inMemoryDataContext.Cars.Select(x => x.Id).Sum();
            var car = MockDomainEntities.Car2;
            car.Id = totallyNotExistingId;

            carRepository.Edit(car);
        }

        [TestMethod]
        public void TestThatEditMakesExpectedCalls()
        {
            var car = MockDomainEntities.Car2;

            carRepository.Edit(car);
            
            dataContextMock.Verify(x => x.Cars, Times.Once);
            carMapperMock.Verify(x => x.GetDomainCar(It.IsAny<DataAccess.Entities.Car>()), Times.Once);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestThatWhenIdIsLessThanOneDeleteThrowsArgumentException()
        {
            carRepository.Delete(0);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestThatWhenCarDoesNotExistDeleteThrowsInvalidOperationException()
        {
            var totallyNotExistingId = inMemoryDataContext.Cars.Select(x => x.Id).Sum();

            carRepository.Delete(totallyNotExistingId);
        }

        [TestMethod]
        public void TestThatDeleteMakesExpectedCalls()
        {
            carRepository.Delete(1);

            dataContextMock.Verify(x => x.Cars, Times.Exactly(2));
        }

        [TestCleanup]
        public void Cleanup()
        {
            Tests.Common.TestHelpers.Cleanup.CleanupInMemoryDataContent(inMemoryDataContext);
        }

        private void SetupDataContextMock()
        {
            inMemoryDataContext = Tests.Common.TestHelpers.Setup.GetInMemoryDataContext();
            inMemoryDataContext.AddRange(MockDataAccessEntities.GetCarList());
            inMemoryDataContext.SaveChanges();

            dataContextMock
                .Setup(x => x.Cars)
                .Returns(inMemoryDataContext.Cars);
        }

        private void SetupCarMapperMock()
        {
            domainCarFromMapper = MockDomainEntities.Car1;
            carMapperMock
                .Setup(x => x.GetDomainCar(It.IsAny<DataAccess.Entities.Car>()))
                .Returns(domainCarFromMapper);

            dataAccessCarFromMapper = MockDataAccessEntities.Car1;
            carMapperMock
                .Setup(x => x.GetDataAccessCar(It.IsAny<Car>()))
                .Returns(dataAccessCarFromMapper);
        }
    }
}