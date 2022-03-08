using System.Diagnostics.CodeAnalysis;
using System.Text;
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

        private List<Car> cars;
        private Dictionary<int, Car> carsById;
        private Car currentUserCar;
        private Car selectedCar;

        public MainWindow()
        {
            InitializeComponent();

            var serviceProvider = DependencyResolver.GetServices().BuildServiceProvider();
            carInteractionBusinessLogic = serviceProvider.GetRequiredService<ICarInteractionBusinessLogic>();
            locationService = serviceProvider.GetRequiredService<ILocationService>();

            RefreshDisplayData();
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
            cars = carInteractionBusinessLogic.GetAllCars();
            carsById = cars.ToDictionary(x => x.Id);

            panelAllCars.Controls.Clear();
            for (var index = 0; index < cars.Count; index++)
            {
                var car = cars[index];
                var carPreviewUserControl = new CarPreviewUserControl(car, OnCarPreviewUserControlClick);
                carPreviewUserControl.Location = new Point(0, carPreviewUserControl.Size.Height * index);
                panelAllCars.Controls.Add(carPreviewUserControl);
            }

            if (selectedCar != null)
            {
                var selectedCarExists = carsById.TryGetValue(selectedCar.Id, out var newSelectedCar);
                selectedCar = (selectedCarExists
                    ? newSelectedCar
                    : cars.Skip(1).First())!;
            }
            else
            {
                selectedCar = cars.Skip(1).First();
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
                ? "Distance: N/A"
                : $"Distance: {locationService.GetDistanceBetweenCars(selectedCar, currentUserCar)}";

            var carEvents = carInteractionBusinessLogic.GetCarEvents(selectedCar);
            textBoxSelectedCarEvents.Text = GetEventsString(carEvents);
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

            numericUpDownMyCarSpeed.Value = (decimal)currentUserCar.SpeedInKmH;

            var carEvents = carInteractionBusinessLogic.GetCarEvents(currentUserCar);
            textBoxMyCarEvents.Text = GetEventsString(carEvents);
        }

        private void OnCarPreviewUserControlClick(Car car)
        {
            selectedCar = car;
            RefreshDisplayData();
        }

        private void buttonSelectClosestCar_Click(object sender, EventArgs e)
        {
            selectedCar = locationService.GetClosestCar(currentUserCar, cars);
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

        private string GetEventsString(List<Event> events)
        {
            var stringBuilder = new StringBuilder();
            for (var index = 0; index < events.Count; index++)
            {
                var carEvent = events[index];
                stringBuilder.AppendLine($"Event {index + 1}: {carEvent.Details}");
                stringBuilder.AppendLine();
            }

            return stringBuilder.ToString();
        }
    }
}