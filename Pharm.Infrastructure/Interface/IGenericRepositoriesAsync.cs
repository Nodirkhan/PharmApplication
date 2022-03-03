using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Pharm.Infrastructure.Interface
{
    public interface IGenericRepositoriesAsync<T> where T : class
    {
        Task<IReadOnlyList<T>> GetAllAsync();

        Task<T> GetByIdAsync(Expression<Func<T, bool>> expression, IList<string> includes);

        Task<T> CreateAsync(T entity);

        Task DeleteAsync(int Id);

        Task UpdateAsync(T entity);

        Task<IReadOnlyList<T>> GetPageListAsync(int page, int pageSize);

    }
}
