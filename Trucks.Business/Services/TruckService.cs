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

        public async Task<TruckViewModelDetails> GetDetailsAsync(int id)
        {
            var truck = await _truckRepository.FindByIdAsync(id);

            return _mapper.Map<TruckViewModelDetails>(truck);
        }

        public async Task<TruckViewModel> GetAsync(int id)
        {
            var truck = await _truckRepository.FindByIdAsync(id);

            return _mapper.Map<TruckViewModel>(truck);
        }

        public async Task CreateAsync(TruckViewModel truckViewModel)
        {
            var truck = _mapper.Map<Truck>(truckViewModel);

            if(truck.IsValid())
                await _truckRepository.InsertAsync(truck);
        }

        public async Task UpdateAsync(int id, TruckViewModel truckViewModel)
        {
            var truck = await _truckRepository.FindByIdAsync(id);

            var truckUpdated = _mapper.Map(truckViewModel, truck);

            truckUpdated.SetUpdatedDate();

            if (truckUpdated.IsValid())
                await _truckRepository.UpdateAsync(truckUpdated);
        }

        public async Task DeleteAsync(int id)
        {
            var truck = await _truckRepository.FindByIdAsync(id);

            await _truckRepository.DeleteAsync(truck);
        }
    }
}