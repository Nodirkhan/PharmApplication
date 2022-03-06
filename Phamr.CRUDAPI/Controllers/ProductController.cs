using Microsoft.AspNetCore.Mvc;
using Pharm.Application.DTOs;
using Pharm.Application.Interface;
using System.Threading.Tasks;

namespace Phamr.CRUDAPI.Controllers
{
    [Route("api/product")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService service)
        {
            _productService = service;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            return Ok(await _productService.GetAllProductAsync());
        }
        [HttpGet("id:int")]
        public async Task<IActionResult> GetProduct([FromQuery] int Id)
        {
            return Ok(await _productService.GetProductAsync(Id));
        }
        [HttpPost("Id:int/product")]
        public async Task<IActionResult> PostProduct([FromBody] ProductForCreationDTO productDto)
        {
            return Created(" ", await _productService.CreateProductAsync(productDto));
        }
        [HttpDelete("id:int")]
        public async Task<IActionResult> DeleteProduct(int Id)
        {
            await _productService.DeleteProductAsync(Id);
            return StatusCode(200);
        }
    }
}
