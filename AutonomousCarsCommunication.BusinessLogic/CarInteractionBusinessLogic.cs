﻿using System.Diagnostics.CodeAnalysis;
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
        private readonly ILocationService locationService;

        public CarInteractionBusinessLogic(
            ICarRepository carRepository,
            IEventRepository eventRepository,
            IAuthorizationService authorizationService,
            ILocationService locationService)
        {
            this.carRepository = carRepository;
            this.eventRepository = eventRepository;
            this.authorizationService = authorizationService;
            this.locationService = locationService;

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

        public Car GetClosestCar()
        {
            var currentUserCar = authorizationService.GetCurrentUserCar();

            var allCars = carRepository.GetAll();
            var carsAndDistances = allCars
                .Where(x => x.Id != currentUserCar.Id)
                .Select(x => new {Car = x, Distance = locationService.GetDistanceBetweenCars(currentUserCar, x)})
                .OrderBy(x => x.Distance)
                .ToList();

            return carsAndDistances.First().Car;
        }

        public float GetDistanceToCar(Car car)
        {
            var currentUserCar = authorizationService.GetCurrentUserCar();

            return locationService.GetDistanceBetweenCars(currentUserCar, car);
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
            var car1 = new Car
            {
                ManufacturerName = "VW",
                Model = "Polo",
                SpeedInKmH = 90,
                Position = new Position { X = 10, Y = 10 }
            };

            var car2 = new Car
            {
                ManufacturerName = "BMW",
                Model = "E 46",
                SpeedInKmH = 230,
                Position = new Position { X = 100, Y = 100 }
            };

            carRepository.Add(car1);
            carRepository.Add(car2);
        }

        #endregion

    }
}