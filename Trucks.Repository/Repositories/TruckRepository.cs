using Microsoft.EntityFrameworkCore;
using Trucks.Domain.Contracts.Repositories;
using Trucks.Domain.Entities;
using Trucks.Repository.Contexts;

namespace Trucks.Repository.Repositories
{
    public class TruckRepository : BaseRepository<Truck>, ITruckRepository
    {

        public TruckRepository(TrucksDBContext context) : base(context)
        {
        }

        public new async Task<IList<Truck>> GetAllAsync() => await _context.Trucks.Include(x => x.TruckModel).AsNoTracking().ToListAsync();
    }
}