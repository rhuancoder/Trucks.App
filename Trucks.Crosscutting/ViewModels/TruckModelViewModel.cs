using System.ComponentModel;

namespace Trucks.Crosscutting.ViewModels
{
    public class TruckModelViewModel
    {
        public int Id { get; set; }

        [DisplayName("Model")]
        public string? Name { get; set; }
    }
}