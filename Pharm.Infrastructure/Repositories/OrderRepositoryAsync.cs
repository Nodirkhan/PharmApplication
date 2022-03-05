using Microsoft.EntityFrameworkCore;
using Pharm.Domain.Models;
using Pharm.Infrastructure.Context;
using Pharm.Infrastructure.Interface;

namespace Pharm.Infrastructure.Repositories
{
    public class OrderRepositoryAsync : GenericRepositoriesAsync<Order>, IOrderRepositoryAsync
    {
        private readonly DbSet<Order> _order;

        public OrderRepositoryAsync(ApplicationDbContext context) : base(context)
        {
            _order = context.Orders;
        }
    }
}
