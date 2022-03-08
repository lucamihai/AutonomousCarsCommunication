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
    public class EventRepositoryTests
    {
        private EventRepository eventRepository;
        private InMemoryDataContext inMemoryDataContext;
        private Mock<IDataContext> dataContextMock;
        private Mock<IEventMapper> eventMapperMock;

        private Event domainEventFromMapper;
        private DataAccess.Entities.Event dataAccessEventFromMapper;

        [TestInitialize]
        public void Setup()
        {
            dataContextMock = new Mock<IDataContext>();
            eventMapperMock = new Mock<IEventMapper>();

            eventRepository = new EventRepository(dataContextMock.Object, eventMapperMock.Object);

            SetupDataContextMock();
            SetupEventMapperMock();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestThatWhenIdIsLessThanOneGetByIdThrowsArgumentException()
        {
            eventRepository.GetById(0);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestThatWhenEventDoesNotExistGetByIdThrowsInvalidOperationException()
        {
            var totallyNotExistingId = inMemoryDataContext.Events.Select(x => x.Id).Sum();

            eventRepository.GetById(totallyNotExistingId);
        }

        [TestMethod]
        public void TestThatGetByIdMakesExpectedCalls()
        {
            eventRepository.GetById(1);

            dataContextMock.Verify(x => x.Events, Times.Once);
            eventMapperMock.Verify(x => x.GetDomainEvent(It.IsAny<DataAccess.Entities.Event>()), Times.Once);
        }

        [TestMethod]
        public void TestThatGetAllEventsMakesExpectedCalls()
        {
            eventRepository.GetAll();

            var eventCount = inMemoryDataContext.Events.Count();
            dataContextMock.Verify(x => x.Events, Times.Once);
            eventMapperMock.Verify(x => x.GetDomainEvent(It.IsAny<DataAccess.Entities.Event>()), Times.Exactly(eventCount));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestThatWhenEventIsNullAddThrowsArgumentNullException()
        {
            eventRepository.Add(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestThatWhenEventIsNotValidAddThrowsArgumentException()
        {
            var evnt = MockDomainEntities.Event2;
            evnt.Details = "";

            eventRepository.Add(evnt);
        }

        [TestMethod]
        public void TestThatAddMakesExpectedCalls()
        {
            var evnt = MockDomainEntities.Event2;

            eventRepository.Add(evnt);

            eventMapperMock.Verify(x => x.GetDataAccessEvent(evnt), Times.Once);
            dataContextMock.Verify(x => x.Events, Times.Once);
            eventMapperMock.Verify(x => x.GetDomainEvent(It.IsAny<DataAccess.Entities.Event>()), Times.Once);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestThatWhenEventIsNullEditThrowsArgumentNullException()
        {
            eventRepository.Edit(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestThatWhenEventIsNotValidEditThrowsArgumentException()
        {
            var evnt = MockDomainEntities.Event2;
            evnt.Details = "";

            eventRepository.Edit(evnt);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestThatWhenEventIdIsLessThanOneEditThrowsArgumentException()
        {
            var evnt = MockDomainEntities.Event2;
            evnt.Id = 0;

            eventRepository.Edit(evnt);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestThatWhenEventDoesNotExistEditThrowsInvalidOperationException()
        {
            var totallyNotExistingId = inMemoryDataContext.Events.Select(x => x.Id).Sum();
            var evnt = MockDomainEntities.Event2;
            evnt.Id = totallyNotExistingId;

            eventRepository.Edit(evnt);
        }

        [TestMethod]
        public void TestThatEditMakesExpectedCalls()
        {
            var evnt = MockDomainEntities.Event2;

            eventRepository.Edit(evnt);
            
            dataContextMock.Verify(x => x.Events, Times.Once);
            eventMapperMock.Verify(x => x.GetDomainEvent(It.IsAny<DataAccess.Entities.Event>()), Times.Once);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestThatWhenIdIsLessThanOneDeleteThrowsArgumentException()
        {
            eventRepository.Delete(0);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestThatWhenEventDoesNotExistDeleteThrowsInvalidOperationException()
        {
            var totallyNotExistingId = inMemoryDataContext.Events.Select(x => x.Id).Sum();

            eventRepository.Delete(totallyNotExistingId);
        }

        [TestMethod]
        public void TestThatDeleteMakesExpectedCalls()
        {
            eventRepository.Delete(1);

            dataContextMock.Verify(x => x.Events, Times.Exactly(2));
        }

        [TestCleanup]
        public void Cleanup()
        {
            Tests.Common.TestHelpers.Cleanup.CleanupInMemoryDataContent(inMemoryDataContext);
        }

        private void SetupDataContextMock()
        {
            inMemoryDataContext = Tests.Common.TestHelpers.Setup.GetInMemoryDataContext();
            inMemoryDataContext.AddRange(MockDataAccessEntities.GetEventList());
            inMemoryDataContext.SaveChanges();

            dataContextMock
                .Setup(x => x.Events)
                .Returns(inMemoryDataContext.Events);
        }

        private void SetupEventMapperMock()
        {
            domainEventFromMapper = MockDomainEntities.Event1;
            eventMapperMock
                .Setup(x => x.GetDomainEvent(It.IsAny<DataAccess.Entities.Event>()))
                .Returns(domainEventFromMapper);

            dataAccessEventFromMapper = MockDataAccessEntities.Event1;
            eventMapperMock
                .Setup(x => x.GetDataAccessEvent(It.IsAny<Event>()))
                .Returns(dataAccessEventFromMapper);
        }
    }
}