using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Trucks.Crosscutting.ViewModels
{
    public class TruckModelViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The field '{0}' is required.")]
        [DisplayName("Model")]
        public string? Name { get; set; }
    }
}