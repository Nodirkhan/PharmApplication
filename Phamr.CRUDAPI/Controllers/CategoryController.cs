using Microsoft.AspNetCore.Mvc;
using Pharm.Application.DTOs.Categories;
using Pharm.Application.Interface;
using System.Threading.Tasks;

namespace Phamr.CRUDAPI.Controllers
{
    [Route("api/category")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryServiceAsync _categoryService;

        public CategoryController(ICategoryServiceAsync service) 
        {
            _categoryService = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCategory()
        {
            return Ok(await _categoryService.GetAllCategoryAsync());
        }
        [HttpGet("Id:int")]
        public async Task<IActionResult> GetCategory([FromQuery] int Id)
        {
            return Ok(await _categoryService.GetCategoryAsync(Id));
        }
        [HttpPost("Id:int/category")]
        public async Task<IActionResult> CreateCategory([FromBody] CategoryForCreationDTO category)
        {
            return Created(" ", await _categoryService.CreateCategoryAsync(category));
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteCategoryAsync(int Id)
        {
            await _categoryService.DeleteProductAsync(Id);
            return StatusCode(200);
        }
    }
}
