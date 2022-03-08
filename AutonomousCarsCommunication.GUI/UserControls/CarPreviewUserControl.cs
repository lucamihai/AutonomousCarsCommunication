using System.Diagnostics.CodeAnalysis;
using AutonomousCarsCommunication.Domain.Entities;

namespace AutonomousCarsCommunication.GUI.UserControls
{
    [ExcludeFromCodeCoverage]
    public partial class CarPreviewUserControl : UserControl
    {
        public CarPreviewUserControl(Car car)
        {
            InitializeComponent();
            
            labelCarManufacturer.Text = car.ManufacturerName;
            labelCarModel.Text = car.Model;
            var imageFilePath = $"CarImages\\{car.ImagePath}";
            if (File.Exists(imageFilePath))
            {
                pictureBoxPreviewCar.BackgroundImage = Image.FromFile(imageFilePath);
            }
        }
    }
}
