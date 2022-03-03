

using Microsoft.EntityFrameworkCore;
using Pharm.Domain.Models;
using Pharm.Infrastructure.Context;
using Pharm.Infrastructure.Interface;

namespace Pharm.Infrastructure.Repositories
{
    public class SupplierRepositoryAsync : GenericRepositoriesAsync<Supplier>, ISupplierRepositoryAsync
    {
        private readonly DbSet<Supplier> _suppliers;

        public SupplierRepositoryAsync(ApplicationDbContext context) : base(context)
        {
            _suppliers = context.Suppliers;
        }
    }
}
