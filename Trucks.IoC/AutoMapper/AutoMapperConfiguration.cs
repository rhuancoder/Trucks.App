using AutoMapper;
using Trucks.Crosscutting.ViewModels;
using Trucks.Domain.Entities;

namespace Trucks.IoC.AutoMapper;

public class AutoMapperConfiguration : Profile
{
    public AutoMapperConfiguration()
    {
        CreateMap<Truck, TruckViewModel>().ReverseMap();
        CreateMap<TruckModel, TruckModelViewModel>().ReverseMap();
    }
}