using AutonomousCarsCommunication.Domain.Entities;
using AutonomousCarsCommunication.Services.Contracts;

namespace AutonomousCarsCommunication.Services
{
    public class LocationService : ILocationService
    {
        public float GetDistanceBetweenCars(Car car1, Car car2)
        {
            var sum = Math.Pow(car2.Position.X - car1.Position.X, 2) + Math.Pow(car2.Position.Y - car1.Position.Y, 2);

            return (float)Math.Sqrt(sum);
        }

        public Car GetClosestCar(Car car, List<Car> cars)
        {
            var carsAndDistances = cars
                .Where(x => x.Id != car.Id)
                .Select(x => new { Car = x, Distance = GetDistanceBetweenCars(car, x) })
                .OrderBy(x => x.Distance)
                .ToList();

            return carsAndDistances.First().Car;
        }
    }
}