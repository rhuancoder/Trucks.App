using Trucks.Crosscutting.ViewModels;

namespace Trucks.Domain.Contracts.Services
{
    public interface ITruckService
    {
        Task<IList<TruckViewModel>> GetAllAsync();

        Task<TruckViewModelDetails> GetDetailsAsync(int id);

        Task<TruckViewModel> GetAsync(int id);

        Task CreateAsync(TruckViewModel truckViewModel);

        Task UpdateAsync(int id, TruckViewModel truckViewModel);

        Task DeleteAsync(int id);
    }
}