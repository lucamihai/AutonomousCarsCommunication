using AutonomousCarsCommunication.BusinessLogic.Contracts;
using AutonomousCarsCommunication.Domain.Entities;

namespace AutonomousCarsCommunication.BusinessLogic
{
    public class CarInteractionBusinessLogic : ICarInteractionBusinessLogic
    {
        public List<Car> GetAllCars()
        {
            throw new NotImplementedException();
        }

        public Car GetClosestCar()
        {
            throw new NotImplementedException();
        }

        public float GetDistanceToCar(Car car)
        {
            throw new NotImplementedException();
        }

        public void SendMessageToCar(Car car, string message)
        {
            throw new NotImplementedException();
        }

        public void SetCurrentSpeed(float kmH)
        {
            throw new NotImplementedException();
        }
    }
}