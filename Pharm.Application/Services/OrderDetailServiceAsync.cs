using AutoMapper;
using Pharm.Application.DTOs.OrderDetails;
using Pharm.Application.Interface;
using Pharm.Domain.Models;
using Pharm.Infrastructure.Interface;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pharm.Application.Services
{
    public class OrderDetailServiceAsync : IOrderDetailServiceAsync
    {
        private IOrderDetailRepositoryAsync _orderDetailRepository;
        private readonly IMapper _mapper;

        public OrderDetailServiceAsync(IOrderDetailRepositoryAsync orderDetail, IMapper mapper)
        {
            _orderDetailRepository = orderDetail;
            _mapper = mapper;
        }
        public async Task<OrderDetailDTO> CreateAsync(OrderDetailForCreationDTO orderdetailForCreationDTO)
        {
            return _mapper.Map<OrderDetailDTO>(await _orderDetailRepository.CreateAsync(_mapper.Map<OrderDatail>(orderdetailForCreationDTO)));
        }

        public async Task DeleteAsync(int Id)
        {
            await _orderDetailRepository.DeleteAsync(Id);

        }

        public async Task<IReadOnlyList<OrderDetailDTO>> GetAllOrderAsync()
        {
            return _mapper.Map<IReadOnlyList<OrderDetailDTO>>(await _orderDetailRepository.GetAllAsync());
        }

        public async Task<OrderDetailDTO> GetOrderAsync(int Id)
        {
            return _mapper.Map<OrderDetailDTO>(await _orderDetailRepository.GetByIdAsync(order => order.Id == Id, new List<string>() { "OrderDatails" }));
        }
    }
}
