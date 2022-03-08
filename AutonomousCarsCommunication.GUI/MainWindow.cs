using System.Diagnostics.CodeAnalysis;
using AutonomousCarsCommunication.BusinessLogic.Contracts;
using AutonomousCarsCommunication.DI;
using AutonomousCarsCommunication.Domain.Entities;
using AutonomousCarsCommunication.GUI.UserControls;
using Microsoft.Extensions.DependencyInjection;

namespace AutonomousCarsCommunication.GUI
{
    [ExcludeFromCodeCoverage]
    public partial class MainWindow : Form
    {
        private readonly ICarInteractionBusinessLogic carInteractionBusinessLogic;

        private Dictionary<int, Car> carsById;
        private Car currentUserCar;
        private Car selectedCar;

        public MainWindow()
        {
            InitializeComponent();

            var serviceProvider = DependencyResolver.GetServices().BuildServiceProvider();
            carInteractionBusinessLogic = serviceProvider.GetRequiredService<ICarInteractionBusinessLogic>();

            RefreshCarCollection();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            RefreshCarCollection();
        }

        private void RefreshCarCollection()
        {
            var allCars = carInteractionBusinessLogic.GetAllCars();
            carsById = allCars.ToDictionary(x => x.Id);

            for (var index = 0; index < allCars.Count; index++)
            {
                var car = allCars[index];
                var carPreviewUserControl = new CarPreviewUserControl(car);
                carPreviewUserControl.Location = new Point(0, carPreviewUserControl.Size.Height * index);
                panelAllCars.Controls.Add(carPreviewUserControl);
            }
        }
    }
}