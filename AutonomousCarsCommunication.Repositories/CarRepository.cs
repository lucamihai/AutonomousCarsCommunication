using AutonomousCarsCommunication.DataAccess.Contracts;
using AutonomousCarsCommunication.DataAccess.Entities;
using AutonomousCarsCommunication.Repositories.Contracts;
using AutonomousCarsCommunication.Repositories.Contracts.Mappers;
using Car = AutonomousCarsCommunication.Domain.Entities.Car;

namespace AutonomousCarsCommunication.Repositories
{
    public class CarRepository : ICarRepository
    {
        private readonly IDataContext dataContext;
        private readonly ICarMapper carMapper;

        public CarRepository(IDataContext dataContext, ICarMapper carMapper)
        {
            this.dataContext = dataContext;
            this.carMapper = carMapper;
        }

        public Car GetById(int id)
        {
            if (id < 1)
            {
                throw new ArgumentException("Id should be at least 1");
            }

            var dataAccessCar = dataContext.Cars.FirstOrDefault(x => x.Id == id);

            if (dataAccessCar == null)
            {
                throw new InvalidOperationException($"There is no car with id: {id}");
            }

            return carMapper.GetDomainCar(dataAccessCar);
        }

        public List<Car> GetAll()
        {
            return dataContext.Cars
                .Select(carMapper.GetDomainCar)
                .ToList();
        }

        public Car Add(Car car)
        {
            if (car == null)
            {
                throw new ArgumentNullException(nameof(car));
            }

            ValidateOrThrow(car);

            var dataAccessCar = carMapper.GetDataAccessCar(car);
            dataAccessCar.Id = 0;
            var addedCar = dataContext.Cars.Add(dataAccessCar);
            dataContext.SaveChanges();

            return carMapper.GetDomainCar(addedCar.Entity);
        }

        public Car Edit(Car car)
        {
            if (car == null)
            {
                throw new ArgumentNullException(nameof(car));
            }

            ValidateOrThrow(car);

            if (car.Id < 1)
            {
                throw new ArgumentException("Id should be at least 1");
            }

            var existingCar = dataContext.Cars.FirstOrDefault(x => x.Id == car.Id);

            if (existingCar == null)
            {
                throw new InvalidOperationException($"There is no car with id: {car.Id}");
            }

            existingCar.ManufacturerId = car.ManufacturerId;
            existingCar.Model = car.Model;
            existingCar.Position = new Position { X = car.Position.X, Y = car.Position.Y };
            existingCar.SpeedInKmH = car.SpeedInKmH;

            dataContext.SaveChanges();

            return carMapper.GetDomainCar(existingCar);
        }

        public void Delete(int id)
        {
            if (id < 1)
            {
                throw new ArgumentException("Id should be at least 1");
            }

            var dataAccessCar = dataContext.Cars.FirstOrDefault(x => x.Id == id);

            if (dataAccessCar == null)
            {
                throw new InvalidOperationException($"There is no car with id: {id}");
            }

            dataContext.Cars.Remove(dataAccessCar);
            dataContext.SaveChanges();
        }

        // TODO: Could extract this into a separate service
        private void ValidateOrThrow(Car car)
        {
            if (car.ManufacturerId < 1)
            {
                throw new ArgumentException("Car ManufacturerId should be at least 1");
            }

            if (string.IsNullOrWhiteSpace(car.Model))
            {
                throw new ArgumentException("Car Model should be not empty");
            }

            if (car.SpeedInKmH > 250)
            {
                throw new ArgumentException("Slow down cowboi");
            }

            if (car.SpeedInKmH < -150)
            {
                throw new ArgumentException("Can you even reverse at that speed?");
            }
        }
    }
}