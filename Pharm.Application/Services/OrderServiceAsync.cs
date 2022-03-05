using AutoMapper;
using Pharm.Application.DTOs.Orders;
using Pharm.Application.Interface;
using Pharm.Domain.Models;
using Pharm.Infrastructure.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharm.Application.Services
{
    public class OrderServiceAsync : IOrderServiceAsync
    {
        private readonly IMapper _mapper;
        private readonly IOrderRepositoryAsync _orderRepostory;

        public OrderServiceAsync(IOrderRepositoryAsync order,IMapper mapper)
        {
            _mapper = mapper;
            _orderRepostory = order;
        }
        public async Task<OrderDTO> CreateAsync(OrderForCreationDTO orderForCreationDTO)
        {
            return _mapper.Map<OrderDTO>(await _orderRepostory.CreateAsync(_mapper.Map<Order>(orderForCreationDTO)));
        }

        public async Task DeleteAsync(int Id)
        {
            await _orderRepostory.DeleteAsync(Id);
        }

        public async Task<IReadOnlyList<OrderDTO>> GetAllOrderAsync()
        {
            return _mapper.Map<IReadOnlyList<OrderDTO>>(await _orderRepostory.GetAllAsync());
        }


        public async Task<OrderDTO> GetOrderAsync(int Id)
        {
            return _mapper.Map<OrderDTO>(await _orderRepostory.GetByIdAsync(order => order.Id == Id, new List<string>() { "OrderDatails"}));

        }
    }
}
