using AutonomousCarsCommunication.Domain.Entities;
using AutonomousCarsCommunication.Repositories.Contracts.Mappers;

namespace AutonomousCarsCommunication.Repositories.Mappers
{
    public class CarMapper : ICarMapper
    {
        public Car GetDomainCar(DataAccess.Entities.Car car)
        {
            if (car == null)
            {
                throw new ArgumentNullException(nameof(car));
            }

            return new Car
            {
                Id = car.Id,
                ManufacturerName = car.ManufacturerName,
                Model = car.Model,
                Position = new Position { X = car.Position.X, Y = car.Position.Y },
                SpeedInKmH = car.SpeedInKmH
            };
        }

        public DataAccess.Entities.Car GetDataAccessCar(Car car)
        {
            if (car == null)
            {
                throw new ArgumentNullException(nameof(car));
            }

            return new DataAccess.Entities.Car
            {
                Id = car.Id,
                ManufacturerName = car.ManufacturerName,
                Model = car.Model,
                Position = new DataAccess.Entities.Position { X = car.Position.X, Y = car.Position.Y },
                SpeedInKmH = car.SpeedInKmH
            };
        }
    }
}