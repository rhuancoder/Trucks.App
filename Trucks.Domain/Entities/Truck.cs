using Trucks.Domain.Enums;

namespace Trucks.Domain.Entities
{
    public class Truck
    {
        public Truck()
        {
        }

        public Truck(int id, string name, string color, int manufactureYear, int modelYear, TruckModelEnum truckModel)
        {
            Id = id;
            IdTruckModel = (int)truckModel;
            Name = name;
            Color = color;
            ManufactureYear = manufactureYear;
            ModelYear = modelYear;
        }

        public int Id { get; private set; }
        public int IdTruckModel { get; private set; }
        public string? Name { get; private set; }
        public string? Color { get; private set; }
        public int ManufactureYear { get; private set; }
        public int ModelYear { get; private set; }

        public TruckModel? TruckModel { get; private set; }
    }
}