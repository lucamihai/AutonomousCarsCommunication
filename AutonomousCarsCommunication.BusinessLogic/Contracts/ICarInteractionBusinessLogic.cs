using AutonomousCarsCommunication.Domain.Entities;

namespace AutonomousCarsCommunication.BusinessLogic.Contracts
{
    public interface ICarInteractionBusinessLogic
    {
        List<Car> GetAllCars();
        Car GetMyCar();
        void SendMessageToCar(Car car, string message);
        void SetCurrentSpeed(float kmH);
    }
}