using System.ComponentModel;

namespace Trucks.Crosscutting.ViewModels
{
    public class TruckViewModel
    {
        public int Id { get; set; }

        [DisplayName("Truck Model")]
        public int IdTruckModel { get; set; }

        [DisplayName("Name")]
        public string? Name { get; set; }

        [DisplayName("Color")]
        public string? Color { get; set; }

        [DisplayName("Manufacture Year")]
        public int ManufactureYear { get; set; }

        [DisplayName("Model Year")]
        public int ModelYear { get; set; }

        [DisplayName("Truck Model")]
        public TruckModelViewModel? TruckModel { get; set; }
    }
}