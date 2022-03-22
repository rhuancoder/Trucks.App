using System.ComponentModel;

namespace Trucks.Web.Models
{
    public class TruckViewModel
    {
        public int Id { get; set; }

        [DisplayName("Description")]
        public string Description { get; set; }

        [DisplayName("Truck Model")]
        public string TruckModel { get; set; }

        [DisplayName("Manufacture Year")]
        public int ManufactureYear { get; set; }

        [DisplayName("Model Year")]
        public int ModelYear { get; set; }
    }
}