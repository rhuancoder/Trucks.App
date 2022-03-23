using Trucks.Crosscutting.ViewModels;

namespace Trucks.Domain.Contracts.Services
{
    public interface ITruckService
    {
        List<TruckViewModel> GetAll();
    }
}