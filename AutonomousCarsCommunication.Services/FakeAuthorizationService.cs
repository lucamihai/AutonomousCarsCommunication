using System.Diagnostics.CodeAnalysis;
using AutonomousCarsCommunication.Domain.Entities;
using AutonomousCarsCommunication.Repositories.Contracts;
using AutonomousCarsCommunication.Services.Contracts;

namespace AutonomousCarsCommunication.Services
{
    public class FakeAuthorizationService : IAuthorizationService
    {
        private readonly ICarRepository carRepository;

        public FakeAuthorizationService(ICarRepository carRepository)
        {
            this.carRepository = carRepository;
        }

        public Car GetCurrentUserCar()
        {
            return carRepository.GetAll().First();
        }
    }
}