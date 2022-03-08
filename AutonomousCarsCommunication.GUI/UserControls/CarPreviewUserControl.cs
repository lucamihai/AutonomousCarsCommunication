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

            // TODO: Add car images
            labelCarManufacturer.Text = car.ManufacturerName;
            labelCarModel.Text = car.Model;
        }
    }
}
