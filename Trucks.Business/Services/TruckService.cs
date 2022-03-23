using AutoMapper;
using Trucks.Crosscutting.ViewModels;
using Trucks.Domain.Contracts.Repositories;
using Trucks.Domain.Contracts.Services;
using Trucks.Domain.Entities;
using Trucks.Domain.Enums;

namespace Trucks.Business.Services
{
    public class TruckService : ITruckService
    {
        private readonly ITruckRepository _truckRepository;
        private readonly IMapper _mapper;

        public TruckService(ITruckRepository truckRepository, IMapper mapper)
        {
            _truckRepository = truckRepository;
            _mapper = mapper;
        }

        public async Task<IList<TruckViewModel>> GetAllAsync()
        {
            var trucks = await _truckRepository.GetAllAsync();

            return _mapper.Map<IList<TruckViewModel>>(trucks);
        }

        public async Task CreateAsync(TruckViewModel truckViewModel)
        {
            var truck = _mapper.Map<Truck>(truckViewModel);
                
            await _truckRepository.InsertAsync(truck);
        }
    }
}