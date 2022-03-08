using System.Diagnostics.CodeAnalysis;
using AutonomousCarsCommunication.Domain.Entities;

namespace AutonomousCarsCommunication.GUI.UserControls
{
    [ExcludeFromCodeCoverage]
    public partial class CarPreviewUserControl : UserControl
    {
        public CarPreviewUserControl(Car car, Action<Car> onClick)
        {
            InitializeComponent();

            labelCarManufacturer.Text = car.ManufacturerName;
            labelCarModel.Text = car.Model;
            var imageFilePath = $"CarImages\\{car.ImagePath}";
            if (File.Exists(imageFilePath))
            {
                pictureBoxPreviewCar.BackgroundImage = Image.FromFile(imageFilePath);
            }

            this.Click += delegate (object sender, EventArgs args) { onClick(car); };
            labelCarManufacturer.Click += delegate (object sender, EventArgs args) { onClick(car); };
            labelCarModel.Click += delegate (object sender, EventArgs args) { onClick(car); };
            pictureBoxPreviewCar.Click += delegate (object sender, EventArgs args) { onClick(car); };
        }
    }
}
