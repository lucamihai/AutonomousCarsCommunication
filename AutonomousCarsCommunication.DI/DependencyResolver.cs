using System.Diagnostics.CodeAnalysis;
using AutonomousCarsCommunication.BusinessLogic;
using AutonomousCarsCommunication.BusinessLogic.Contracts;
using AutonomousCarsCommunication.DataAccess;
using AutonomousCarsCommunication.DataAccess.Contracts;
using AutonomousCarsCommunication.Repositories;
using AutonomousCarsCommunication.Repositories.Contracts;
using AutonomousCarsCommunication.Repositories.Contracts.Mappers;
using AutonomousCarsCommunication.Repositories.Mappers;
using AutonomousCarsCommunication.Services;
using AutonomousCarsCommunication.Services.Contracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace AutonomousCarsCommunication.DI
{
    [ExcludeFromCodeCoverage]
    public static class DependencyResolver
    {
        public static ServiceCollection GetServices()
        {
            var services = new ServiceCollection();

            services.AddScoped<ICarInteractionBusinessLogic, CarInteractionBusinessLogic>();

            services.AddScoped<ICarMapper, CarMapper>();
            services.AddScoped<IEventMapper, EventMapper>();

            services.AddScoped<ICarRepository, CarRepository>();
            services.AddScoped<IEventRepository, EventRepository>();

            services.AddScoped<IDataContext, DataContext>();
            services.AddDbContext<IDataContext, DataContext>((serviceProvider, options) =>
            {
                options.UseInMemoryDatabase("AutonomousCarsCommunication");
            });

            services.AddScoped<IAuthorizationService, FakeAuthorizationService>();
            services.AddScoped<ILocationService, LocationService>();

            return services;
        }
    }
}