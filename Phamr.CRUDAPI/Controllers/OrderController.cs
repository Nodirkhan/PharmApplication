using Microsoft.AspNetCore.Mvc;
using Pharm.Application.DTOs.Orders;
using Pharm.Application.Interface;
using System.Threading.Tasks;

namespace Phamr.CRUDAPI.Controllers
{
    [Route("api/order")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderServiceAsync _orderService;

        public OrderController(IOrderServiceAsync order)
        {
            _orderService = order;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            return Ok(await _orderService.GetAllOrderAsync());
        }
        [HttpGet("id:int")]
        public async Task<IActionResult> GetAsync([FromQuery] int Id)
        {
            return Ok(await _orderService.GetOrderAsync(Id));
        }
        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] OrderForCreationDTO order)
        {
            return Ok(await _orderService.CreateAsync(order));
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteAsync([FromQuery] int Id)
        {
            await _orderService.DeleteAsync(Id);
            return Ok(200);
        }
        
    }
}
