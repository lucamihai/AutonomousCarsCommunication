using System;
using System.Diagnostics.CodeAnalysis;
using AutonomousCarsCommunication.Repositories.Mappers;
using AutonomousCarsCommunication.Tests.Common;
using KellermanSoftware.CompareNetObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutonomousCarsCommunication.Repositories.UnitTests.MappersTests
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public class CarMapperTests
    {
        private CarMapper carMapper;

        private CompareLogic compareLogic;

        [TestInitialize]
        public void Setup()
        {
            carMapper = new CarMapper();

            compareLogic = new CompareLogic();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestThatWhenCarIsNullGetDomainCarThrowsArgumentNullException()
        {
            carMapper.GetDomainCar(null);
        }

        [TestMethod]
        public void TestThatGetDomainCarReturnsExpectedCar()
        {
            var dataAccessCar = MockDataAccessEntities.Car1;

            var domainCar = carMapper.GetDomainCar(dataAccessCar);

            var expectedCar = MockDomainEntities.Car1;
            Assert.IsTrue(compareLogic.Compare(expectedCar, domainCar).AreEqual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestThatWhenCarIsNullGetDataAccessCarThrowsArgumentNullException()
        {
            carMapper.GetDataAccessCar(null);
        }

        [TestMethod]
        public void TestThatGetDataAccessCarReturnsExpectedCar()
        {
            var domainCar = MockDomainEntities.Car1;

            var dataAccessCar = carMapper.GetDataAccessCar(domainCar);

            var expectedCar = MockDataAccessEntities.Car1;
            Assert.IsTrue(compareLogic.Compare(expectedCar, dataAccessCar).AreEqual);
        }
    }
}