using Pharm.Application.DTOs.Orders;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pharm.Application.Interface
{
    public interface IOrderServiceAsync
    {
        Task<OrderDTO> CreateAsync(OrderForCreationDTO orderForCreationDTO);
        
        Task<IReadOnlyList<OrderDTO>> GetAllOrderAsync();
       
        Task<OrderDTO> GetOrderAsync(int Id);
       
        Task DeleteAsync(int Id);
    }
}
