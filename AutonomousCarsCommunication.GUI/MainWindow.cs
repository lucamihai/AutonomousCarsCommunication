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
            UpdateAreaMyCar();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            RefreshCarCollection();
            UpdateAreaMyCar();
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

        private void UpdateAreaSelectedCar()
        {
            labelSelectedCarManufacturer.Text = selectedCar.ManufacturerName;
            labelSelectedCarModel.Text = selectedCar.Model;
            labelSelectedCarSpeed.Text = $"Speed: {selectedCar.SpeedInKmH} km/h";
            labelSelectedCarPosition.Text = $"Position: ({selectedCar.Position.X}, {selectedCar.Position.Y})";

            var imageFilePath = $"CarImages\\{selectedCar.ImagePath}";
            if (File.Exists(imageFilePath))
            {
                pictureBoxMyCar.BackgroundImage = Image.FromFile(imageFilePath);
            }
        }

        private void UpdateAreaMyCar()
        {
            currentUserCar = carInteractionBusinessLogic.GetMyCar();

            labelMyCarManufacturer.Text = currentUserCar.ManufacturerName;
            labelMyCarModel.Text = currentUserCar.Model;
            labelMyCarSpeed.Text = $"Speed: {currentUserCar.SpeedInKmH} km/h";
            labelMyCarPosition.Text = $"Position: ({currentUserCar.Position.X}, {currentUserCar.Position.Y})";

            var imageFilePath = $"CarImages\\{currentUserCar.ImagePath}";
            if (File.Exists(imageFilePath))
            {
                pictureBoxMyCar.BackgroundImage = Image.FromFile(imageFilePath);
            }
        }
    }
}