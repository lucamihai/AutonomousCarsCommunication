using System.Diagnostics.CodeAnalysis;
using AutonomousCarsCommunication.BusinessLogic.Contracts;
using AutonomousCarsCommunication.DI;
using Microsoft.Extensions.DependencyInjection;

namespace AutonomousCarsCommunication.GUI
{
    [ExcludeFromCodeCoverage]
    public partial class MainWindow : Form
    {
        private readonly ICarInteractionBusinessLogic carInteractionBusinessLogic;

        public MainWindow()
        {
            InitializeComponent();

            var serviceProvider = DependencyResolver.GetServices().BuildServiceProvider();
            carInteractionBusinessLogic = serviceProvider.GetRequiredService<ICarInteractionBusinessLogic>();
        }
    }
}