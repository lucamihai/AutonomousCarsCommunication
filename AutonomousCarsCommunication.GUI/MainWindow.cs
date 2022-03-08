using System.Diagnostics.CodeAnalysis;
using AutonomousCarsCommunication.BusinessLogic.Contracts;
using AutonomousCarsCommunication.DI;
using AutonomousCarsCommunication.Domain.Entities;
using AutonomousCarsCommunication.GUI.UserControls;
using AutonomousCarsCommunication.Services.Contracts;
using Microsoft.Extensions.DependencyInjection;

namespace AutonomousCarsCommunication.GUI
{
    [ExcludeFromCodeCoverage]
    public partial class MainWindow : Form
    {
        private readonly ICarInteractionBusinessLogic carInteractionBusinessLogic;
        private readonly ILocationService locationService;

        private Dictionary<int, Car> carsById;
        private Car currentUserCar;
        private Car selectedCar;

        public MainWindow()
        {
            InitializeComponent();

            var serviceProvider = DependencyResolver.GetServices().BuildServiceProvider();
            carInteractionBusinessLogic = serviceProvider.GetRequiredService<ICarInteractionBusinessLogic>();
            locationService = serviceProvider.GetRequiredService<ILocationService>();

            RefreshCarCollection();
            UpdateAreaMyCar();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            RefreshDisplayData();
        }

        private void RefreshDisplayData()
        {
            RefreshCarCollection();
            UpdateAreaMyCar();
            UpdateAreaSelectedCar();
        }

        private void RefreshCarCollection()
        {
            var allCars = carInteractionBusinessLogic.GetAllCars();
            carsById = allCars.ToDictionary(x => x.Id);

            panelAllCars.Controls.Clear();
            for (var index = 0; index < allCars.Count; index++)
            {
                var car = allCars[index];
                var carPreviewUserControl = new CarPreviewUserControl(car, OnCarPreviewUserControlClick);
                carPreviewUserControl.Location = new Point(0, carPreviewUserControl.Size.Height * index);
                panelAllCars.Controls.Add(carPreviewUserControl);
            }

            if (selectedCar != null)
            {
                var selectedCarExists = carsById.TryGetValue(selectedCar.Id, out var newSelectedCar);
                selectedCar = (selectedCarExists
                    ? newSelectedCar
                    : null)!;
            }
        }

        private void UpdateAreaSelectedCar()
        {
            labelSelectedCarManufacturer.Text = selectedCar?.ManufacturerName;
            labelSelectedCarModel.Text = selectedCar?.Model;
            labelSelectedCarSpeed.Text = $"Speed: {selectedCar?.SpeedInKmH} km/h";
            labelSelectedCarPosition.Text = $"Position: ({selectedCar?.Position.X}, {selectedCar?.Position.Y})";

            var imageFilePath = $"CarImages\\{selectedCar?.ImagePath}";
            if (File.Exists(imageFilePath))
            {
                pictureBoxSelectedCar.BackgroundImage = Image.FromFile(imageFilePath);
            }

            labelDistanceFromSelectedCarToMyCar.Text = selectedCar.Id == currentUserCar.Id
                ? "N/A"
                : locationService.GetDistanceBetweenCars(selectedCar, currentUserCar).ToString();
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

        private void OnCarPreviewUserControlClick(Car car)
        {
            selectedCar = car;
            RefreshDisplayData();
        }

        private void buttonSelectClosestCar_Click(object sender, EventArgs e)
        {
            selectedCar = carInteractionBusinessLogic.GetClosestCar();
            RefreshDisplayData();
        }

        private void buttonSendMessage_Click(object sender, EventArgs e)
        {

        }

        private void buttonSetMyCarSpeed_Click(object sender, EventArgs e)
        {
            var speed = (float)numericUpDownMyCarSpeed.Value;
            carInteractionBusinessLogic.SetCurrentSpeed(speed);

            RefreshDisplayData();
        }
    }
}