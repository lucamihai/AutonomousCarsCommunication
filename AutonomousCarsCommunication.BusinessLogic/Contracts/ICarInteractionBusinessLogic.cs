using AutonomousCarsCommunication.Domain.Entities;

namespace AutonomousCarsCommunication.BusinessLogic.Contracts
{
    public interface ICarInteractionBusinessLogic
    {
        List<Car> GetAllCars();
        Car GetMyCar();
        Car GetClosestCar();
        float GetDistanceToCar(Car car);
        void SendMessageToCar(Car car, string message);
        void SetCurrentSpeed(float kmH);
    }
}