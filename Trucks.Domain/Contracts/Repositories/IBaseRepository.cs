using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trucks.Domain.Contracts.Repositories
{
    public interface IBaseRepository<T> where T : class
    {
        Task<T> FindByIdAsync(int id);

        Task<IList<T>> GetAllAsync();

        Task<T> InsertAsync(T entity);

        Task<T> UpdateAsync(T entity);

        Task<int> DeleteAsync(T entity);
    }
}
