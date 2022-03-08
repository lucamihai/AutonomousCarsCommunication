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
    public class EventMapperTests
    {
        private EventMapper eventMapper;

        private CompareLogic compareLogic;

        [TestInitialize]
        public void Setup()
        {
            eventMapper = new EventMapper();

            compareLogic = new CompareLogic();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestThatWhenEventIsNullGetDomainEventThrowsArgumentNullException()
        {
            eventMapper.GetDomainEvent(null);
        }

        [TestMethod]
        public void TestThatGetDomainEventReturnsExpectedEvent()
        {
            var dataAccessEvent = MockDataAccessEntities.Event1;

            var domainEvent = eventMapper.GetDomainEvent(dataAccessEvent);

            var expectedEvent = MockDomainEntities.Event1;
            Assert.IsTrue(compareLogic.Compare(expectedEvent, domainEvent).AreEqual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestThatWhenEventIsNullGetDataAccessEventThrowsArgumentNullException()
        {
            eventMapper.GetDataAccessEvent(null);
        }

        [TestMethod]
        public void TestThatGetDataAccessEventReturnsExpectedEvent()
        {
            var domainEvent = MockDomainEntities.Event1;

            var dataAccessEvent = eventMapper.GetDataAccessEvent(domainEvent);

            var expectedEvent = MockDataAccessEntities.Event1;
            Assert.IsTrue(compareLogic.Compare(expectedEvent, dataAccessEvent).AreEqual);
        }
    }
}