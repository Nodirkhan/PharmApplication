using Pharm.Application.DTOs.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharm.Application.Interface
{
    public interface ICategoryServiceAsync 
    {
        Task<CategoryDTO> GetCategoryAsync(int Id);

        Task<CategoryDTO> CreateCategoryAsync(CategoryForCreationDTO categoryForCreationDTO);

        Task<IReadOnlyList<CategoryDTO>> GetAllCategoryAsync();
        
        Task DeleteProductAsync(int Id);
    }
}
