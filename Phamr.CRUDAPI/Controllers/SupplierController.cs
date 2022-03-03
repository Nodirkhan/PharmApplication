using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pharm.Application.DTOs.Suppliers;
using Pharm.Application.Interface;
using System.Threading.Tasks;

namespace Phamr.CRUDAPI.Controllers
{
    [Route("api/supplier")]
    [ApiController]
    public class SupplierController : ControllerBase
    {
        private readonly ISupplierServiceAsync _supplierService;

        public SupplierController(ISupplierServiceAsync supplierService)
        {
            _supplierService = supplierService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllSupplierAsync()
        {
            return Ok(await _supplierService.GetAllSupplierAsync());
        }
        [HttpGet("id:int")]
        public async Task<IActionResult> GetSupplierAsync([FromQuery] int Id)
        {
            return Ok(await _supplierService.GetSupplierAsync(Id));
        }
        [HttpPost("int:Id/Supplier")]
        public async Task<IActionResult> CreateSupllierAsync([FromBody] SupplierForCreationDTO supplier)
        {
            return Created(" " , await _supplierService.CreateSupplierAsync(supplier));
        }
        [HttpDelete("int:Id/Supplier")]
        public async Task<IActionResult> DeleteSupplierAsync([FromQuery] int Id)
        {
            await _supplierService.DeleteSupplierAsync(Id);
            return Ok();
        }
    
    
    
    }

}
