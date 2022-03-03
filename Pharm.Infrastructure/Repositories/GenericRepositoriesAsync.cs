using Microsoft.EntityFrameworkCore;
using Pharm.Infrastructure.Context;
using Pharm.Infrastructure.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Pharm.Infrastructure.Repositories
{
    public class GenericRepositoriesAsync<T> : IGenericRepositoriesAsync<T> where T : class
    {
        private readonly ApplicationDbContext _context;

        public GenericRepositoriesAsync(ApplicationDbContext context)
        {
            _context = context;
        }
        
        public virtual async Task<T> CreateAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await SaveChangesAsync();
            return entity;
        }

        public virtual async Task DeleteAsync(int Id)
        {
            var entity = await _context.Set<T>().FindAsync(Id);
             _context.Set<T>().Remove(entity);
            await SaveChangesAsync();
        }

        public virtual async Task<IReadOnlyList<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public virtual async Task<T> GetByIdAsync(Expression<Func<T, bool>> expression, IList<string> includes)
        {
            IQueryable<T> entities = _context.Set<T>();
            foreach(var include in includes )
            {
                entities = entities.Include(include);
            }
            return await entities.FirstOrDefaultAsync(expression);
        }

        public virtual async Task<IReadOnlyList<T>> GetPageListAsync(int page, int pageSize)
        {
            return await _context.Set<T>()
                .Skip((page -1)* pageSize)
                .Take(pageSize)
                .ToListAsync();
        }

        public virtual async Task UpdateAsync(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await SaveChangesAsync();
        }
        public virtual async Task<bool> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync()>=0;
        }

        
    }
}
