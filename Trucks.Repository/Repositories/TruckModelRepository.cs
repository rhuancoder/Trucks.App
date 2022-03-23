using Microsoft.EntityFrameworkCore;
using Trucks.Domain.Contracts.Repositories;
using Trucks.Domain.Entities;
using Trucks.Repository.Contexts;

namespace Trucks.Repository.Repositories
{
    public class TruckModelRepository : BaseRepository<TruckModel>, ITruckModelRepository
    {
        public TruckModelRepository(TrucksDBContext context) : base(context)
        {
        }
    }
}