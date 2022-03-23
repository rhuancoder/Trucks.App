using Trucks.Domain.Entities;

namespace Trucks.Domain.Contracts.Repositories
{
    public interface ITruckRepository
    {
        Task<List<Truck>> GetAll();
    }
}