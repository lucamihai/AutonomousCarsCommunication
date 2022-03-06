using AutonomousCarsCommunication.Domain.Entities;
using AutonomousCarsCommunication.Repositories.Contracts.Mappers;

namespace AutonomousCarsCommunication.Repositories.Mappers
{
    public class CarMapper : ICarMapper
    {
        public Car GetDomainCar(DataAccess.Entities.Car dataAccessCar)
        {
            throw new NotImplementedException();
        }

        public DataAccess.Entities.Car GetDataAccessCar(Car domainCar)
        {
            throw new NotImplementedException();
        }
    }
}