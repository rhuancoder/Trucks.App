using Trucks.Crosscutting.ViewModels;

namespace Trucks.Domain.Contracts.Services
{
    public interface ITruckService
    {
        Task<IList<TruckViewModel>> GetAllAsync();

        Task CreateAsync(TruckViewModel truckViewModel);
    }
}