using AutonomousCarsCommunication.Domain.Entities;

namespace AutonomousCarsCommunication.Services.Contracts
{
    public interface ILocationService
    {
        float GetDistanceBetweenCars(Car car1, Car car2);
    }
}