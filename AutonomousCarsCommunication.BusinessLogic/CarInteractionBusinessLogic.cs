using System.Diagnostics.CodeAnalysis;
using AutonomousCarsCommunication.BusinessLogic.Contracts;
using AutonomousCarsCommunication.Domain.Entities;
using AutonomousCarsCommunication.Repositories.Contracts;
using AutonomousCarsCommunication.Services.Contracts;

namespace AutonomousCarsCommunication.BusinessLogic
{
    public class CarInteractionBusinessLogic : ICarInteractionBusinessLogic
    {
        private readonly ICarRepository carRepository;
        private readonly IEventRepository eventRepository;
        private readonly IAuthorizationService authorizationService;

        public CarInteractionBusinessLogic(
            ICarRepository carRepository,
            IEventRepository eventRepository,
            IAuthorizationService authorizationService)
        {
            this.carRepository = carRepository;
            this.eventRepository = eventRepository;
            this.authorizationService = authorizationService;

            // TODO: Call responsible only for adding initial data, since in memory database is being used. In a normal scenario, this wouldn't exist.
            AddInitialData();
        }

        public List<Car> GetAllCars()
        {
            return carRepository.GetAll();
        }

        public Car GetMyCar()
        {
            return authorizationService.GetCurrentUserCar();
        }

        public List<Event> GetCarEvents(Car car)
        {
            var allEvents = eventRepository.GetAll();

            return allEvents
                .Where(x => x.InvolvedCars.Contains(car.Id))
                .ToList();
        }

        public void SendMessageToCar(Car car, string message)
        {
            var currentUserCar = authorizationService.GetCurrentUserCar();
            var evnt = new Event
            {
                Details = $"Car {currentUserCar.Id} sent the following message to car {car.Id}: {message}",
                InvolvedCars = new List<int> { currentUserCar.Id, car.Id }
            };

            eventRepository.Add(evnt);
        }

        public void SetCurrentSpeed(float kmH)
        {
            var currentUserCar = authorizationService.GetCurrentUserCar();
            currentUserCar.SpeedInKmH = kmH;

            carRepository.Edit(currentUserCar);
        }

        #region Code responsible only for adding initial data. In a normal scenario, this wouldn't exist.
        
        [ExcludeFromCodeCoverage]
        private void AddInitialData()
        {
            AddInitialCars();
            AddInitialEvents();
        }

        [ExcludeFromCodeCoverage]
        private void AddInitialCars()
        {
            var car1 = new Car
            {
                ManufacturerName = "VW",
                Model = "Polo",
                ImagePath = "VW-Polo.jpg",
                SpeedInKmH = 90,
                Position = new Position { X = 10, Y = 10 }
            };

            var car2 = new Car
            {
                ManufacturerName = "BMW",
                Model = "E 46",
                ImagePath = "BMW-Pan.jpeg",
                SpeedInKmH = 230,
                Position = new Position { X = 100, Y = 100 }
            };

            var car3 = new Car
            {
                ManufacturerName = "Tesla",
                Model = "Model S",
                ImagePath = "Tesla-ModelS.PNG",
                SpeedInKmH = 220,
                Position = new Position { X = 200, Y = 210 }
            };

            var car4 = new Car
            {
                ManufacturerName = "Dacia",
                Model = "Sandero Stepway",
                ImagePath = "Dacia-SanderoStepway.PNG",
                SpeedInKmH = 110,
                Position = new Position { X = 61, Y = 62 }
            };

            carRepository.Add(car1);
            carRepository.Add(car2);
            carRepository.Add(car3);
            carRepository.Add(car4);
        }

        [ExcludeFromCodeCoverage]
        private void AddInitialEvents()
        {
            var event1 = new Event
            {
                Details = "Driver got pulled over. Luckily he was innocent *innocent emoji*.",
                InvolvedCars = new List<int> { 1 }
            };

            var event2 = new Event
            {
                Details = "Car ran out of blinker fluid",
                InvolvedCars = new List<int> { 2 }
            };

            var event3 = new Event
            {
                Details = "Driver kept ignoring 'Check Engine' light until their engine got rekt.",
                InvolvedCars = new List<int> { 2 }
            };

            var event4 = new Event
            {
                Details = "Car ran out of fuel. How can you even mess this up?",
                InvolvedCars = new List<int> { 2 }
            };

            var event5 = new Event
            {
                Details = "Car's battery drained out. Shocking (well not anymore).",
                InvolvedCars = new List<int> { 3 }
            };

            var event6 = new Event
            {
                Details = "What? Why is there a Dacia right next to a Tesla?",
                InvolvedCars = new List<int> { 4 }
            };

            eventRepository.Add(event1);
            eventRepository.Add(event2);
            eventRepository.Add(event3);
            eventRepository.Add(event4);
            eventRepository.Add(event5);
            eventRepository.Add(event6);
        }

        #endregion

    }
}