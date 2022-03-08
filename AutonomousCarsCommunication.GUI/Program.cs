using System.Diagnostics.CodeAnalysis;

namespace AutonomousCarsCommunication.GUI
{
    [ExcludeFromCodeCoverage]
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new MainWindow());
        }
    }
}