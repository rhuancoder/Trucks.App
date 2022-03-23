namespace Trucks.Domain.Entities
{
    public class TruckModel
    {
        public TruckModel(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string? Name { get; set; }

        public ICollection<Truck>? Trucks { get; private set; }
    }
}