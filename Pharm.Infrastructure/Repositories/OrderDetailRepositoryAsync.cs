using Pharm.Domain.Models;
using Pharm.Infrastructure.Context;
using Pharm.Infrastructure.Interface;

namespace Pharm.Infrastructure.Repositories
{
    public class OrderDetailRepositoryAsync : GenericRepositoriesAsync<OrderDatail>, IOrderDetailRepositoryAsync
    {
        private readonly ApplicationDbContext _orderDetail;

        public OrderDetailRepositoryAsync(ApplicationDbContext context) : base(context)
        {
            _orderDetail = context;
        }
    }
}
