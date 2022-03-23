using Microsoft.EntityFrameworkCore;
using Trucks.Domain.Contracts.Repositories;
using Trucks.Domain.Entities;
using Trucks.Repository.Contexts;

namespace Trucks.Repository.Repositories
{
    public class TruckRepository : ITruckRepository
    {
        private readonly TrucksDBContext _context;

        public TruckRepository(TrucksDBContext context)
        {
            _context = context;
        }

        public async Task<List<Truck>> GetAll()
        {
            return await _context.Trucks
                .Include(x => x.TruckModel)
                .AsNoTracking()
                .ToListAsync();
        }
    }
}