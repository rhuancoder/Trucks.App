using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Trucks.Crosscutting.ViewModels
{
    public class TruckViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The field '{0}' is required.")]
        [DisplayName("Truck Model")]
        public int IdTruckModel { get; set; }

        [Required(ErrorMessage = "The field '{0}' is required.")]
        [DisplayName("Name")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "The field '{0}' is required.")]
        [DisplayName("Color")]
        public string? Color { get; set; }

        [Required(ErrorMessage = "The field '{0}' is required.")]
        [DisplayName("Manufacture Year")]
        public int ManufactureYear { get; set; }

        [Required(ErrorMessage = "The field '{0}' is required.")]
        [DisplayName("Model Year")]
        public int ModelYear { get; set; }

        [NotMapped]
        [DisplayName("Truck Model")]
        public TruckModelViewModel? TruckModel { get; set; }
    }
}