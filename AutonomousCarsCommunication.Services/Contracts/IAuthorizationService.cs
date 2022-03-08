using AutonomousCarsCommunication.Domain.Entities;

namespace AutonomousCarsCommunication.Services.Contracts
{
    public interface IAuthorizationService
    {
        Car GetCurrentUserCar();
    }
}