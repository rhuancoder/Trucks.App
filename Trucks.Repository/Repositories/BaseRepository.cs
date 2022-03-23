using Microsoft.EntityFrameworkCore;
using Trucks.Domain.Contracts.Repositories;
using Trucks.Repository.Contexts;

namespace Trucks.Repository.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected readonly TrucksDBContext _context;

        public BaseRepository(TrucksDBContext context)
        {
            _context = context;
        }

        public async Task<T> FindByIdAsync(int id) => await _context.Set<T>().FindAsync(id);

        public async Task<IList<T>> GetAllAsync() => await _context.Set<T>().AsNoTracking().ToListAsync();

        public async Task<T> InsertAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();

            return entity;
        }

        public async Task<T> UpdateAsync(T entity)
        {
            _context.Set<T>().Update(entity);
            await _context.SaveChangesAsync();

            return entity;
        }

        public async Task<int> DeleteAsync(T entity)
        {
            _context.Set<T>().Remove(entity);
            return await _context.SaveChangesAsync();
        }
    }
}