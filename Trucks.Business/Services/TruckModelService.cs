using AutoMapper;
using Trucks.Crosscutting.ViewModels;
using Trucks.Domain.Contracts.Repositories;
using Trucks.Domain.Contracts.Services;

namespace Trucks.Business.Services
{
    public class TruckModelService : ITruckModelService
    {
        private readonly ITruckModelRepository _truckModelRepository;
        private readonly IMapper _mapper;

        public TruckModelService(ITruckModelRepository truckModelRepository, IMapper mapper)
        {
            _truckModelRepository = truckModelRepository;
            _mapper = mapper;
        }

        public async Task<IList<TruckModelViewModel>> GetAllAsync()
        {
            var truckModels = await _truckModelRepository.GetAllAsync();

            return _mapper.Map<IList<TruckModelViewModel>>(truckModels);
        }
    }
}