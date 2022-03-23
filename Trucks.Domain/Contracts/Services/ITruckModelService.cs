using Trucks.Crosscutting.ViewModels;

namespace Trucks.Domain.Contracts.Services
{
    public interface ITruckModelService
    {
        Task<IList<TruckModelViewModel>> GetAllAsync();
    }
}