using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore;

namespace AutonomousCarsCommunication.Tests.Common.TestHelpers
{
    [ExcludeFromCodeCoverage]
    public static class Setup
    {
        public static InMemoryDataContext GetInMemoryDataContext()
        {
            var options = new DbContextOptionsBuilder<InMemoryDataContext>()
                .UseInMemoryDatabase("inMemoryDb")
                .LogTo(x => Debug.WriteLine(x))
                .EnableDetailedErrors()
                .EnableSensitiveDataLogging()
                .Options;

            return new InMemoryDataContext(options);
        }
    }
}