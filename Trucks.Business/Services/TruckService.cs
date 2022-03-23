using AutoMapper;
using Trucks.Crosscutting.ViewModels;
using Trucks.Domain.Contracts.Services;
using Trucks.Domain.Entities;
using Trucks.Domain.Enums;

namespace Trucks.Business.Services
{
    public class TruckService : ITruckService
    {
        private readonly IMapper _mapper;

        public TruckService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public List<TruckViewModel> GetAll()
        {
            var trucks = new List<Truck>();
            var truck = new Truck(1, "Xpto", "blue", 2019, 2022, TruckModelEnum.FM);

            trucks.Add(truck);

            return _mapper.Map<List<TruckViewModel>>(trucks);
        }
    }
}