
using Pharm.Application.DTOs.OrderDetails;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pharm.Application.Interface
{
    public  interface IOrderDetailServiceAsync 
    {

        Task<OrderDetailDTO> CreateAsync(OrderDetailForCreationDTO orderForCreationDTO);

        Task<IReadOnlyList<OrderDetailDTO>> GetAllOrderAsync();

        Task<OrderDetailDTO> GetOrderAsync(int Id);

        Task DeleteAsync(int Id);
    }
}
