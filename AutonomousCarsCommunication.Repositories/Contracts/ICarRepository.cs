using AutonomousCarsCommunication.Domain.Entities;

namespace AutonomousCarsCommunication.Repositories.Contracts
{
    public interface ICarRepository
    {
        public Car GetById(int id);
        public List<Car> GetAll();

        public Car Add(Car car);
        public Car Edit(Car car);
        public void Delete(int id);
    }
}