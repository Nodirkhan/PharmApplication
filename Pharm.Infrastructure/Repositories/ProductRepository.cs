using Microsoft.EntityFrameworkCore;
using Pharm.Domain.Models;
using Pharm.Infrastructure.Context;
using Pharm.Infrastructure.Interface;
using System.Linq;
using System.Threading.Tasks;

namespace Pharm.Infrastructure.Repositories
{
    public class ProductRepository : GenericRepositoriesAsync<Product>,IProductRepository
    {
        //private readonly DbSet<Product> _products;
        public ProductRepository(ApplicationDbContext context) : base(context)
        {
            //_products = context.Products;
        }

       /* public override async Task<Product> CreateAsync(Product entity)
        {
            _products.Include(item => item.Categories).Include(item => item.Supplier);
            await SaveChangesAsync();
            return entity;
        }*/
        /*public async Task<Product> CreateProductAsync(Product entity)
        {
            _products.Include(item => item.Categories).Include(item => item.Supplier);
            await _products.AddAsync(entity);
            await SaveChangesAsync();
            return entity;
        }*/
    }
}
