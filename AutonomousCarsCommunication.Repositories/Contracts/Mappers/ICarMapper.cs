using AutonomousCarsCommunication.Domain.Entities;

namespace AutonomousCarsCommunication.Repositories.Contracts.Mappers
{
    public interface ICarMapper
    {
        Car GetDomainCar(DataAccess.Entities.Car dataAccessCar);
        DataAccess.Entities.Car GetDataAccessCar(Car domainCar);
    }
}