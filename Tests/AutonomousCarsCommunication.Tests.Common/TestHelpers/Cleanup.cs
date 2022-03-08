using System.Diagnostics.CodeAnalysis;

namespace AutonomousCarsCommunication.Tests.Common.TestHelpers
{
    [ExcludeFromCodeCoverage]
    public static class Cleanup
    {
        public static void CleanupInMemoryDataContent(InMemoryDataContext inMemoryDataContext)
        {
            inMemoryDataContext.Database.EnsureDeleted();
        }
    }
}