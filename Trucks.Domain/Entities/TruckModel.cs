namespace Trucks.Domain.Entities
{
    public class TruckModel
    {
        public TruckModel(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; private set; }
        public string Name { get; private set; }

        public ICollection<Truck>? Trucks { get; private set; }
    }
}