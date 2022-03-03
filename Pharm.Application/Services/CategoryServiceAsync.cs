using AutoMapper;
using Pharm.Application.DTOs.Categories;
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
    public class CategoryServiceAsync : ICategoryServiceAsync
    {
        private readonly IMapper _mapper;
        private readonly ICategoryRepositoryAsync _categoryRepository;

        public CategoryServiceAsync(ICategoryRepositoryAsync categoryRepository, IMapper mapper)
        {
            _mapper = mapper;
            _categoryRepository = categoryRepository;
        }

        public async Task<CategoryDTO> CreateCategoryAsync(CategoryForCreationDTO categoryForCreationDTO)
        {
            var category = _mapper.Map<Category>(categoryForCreationDTO);
            await _categoryRepository.CreateAsync(category);
            return _mapper.Map<CategoryDTO>(category);
        }

        public async Task DeleteProductAsync(int Id)
        {
            await _categoryRepository.DeleteAsync(Id);
        }

        public async Task<IReadOnlyList<CategoryDTO>> GetAllCategoryAsync()
        {
            return _mapper.Map<IReadOnlyList<CategoryDTO>>(await _categoryRepository.GetAllAsync());
        }

        public async Task<CategoryDTO> GetCategoryAsync(int Id)
        {
            return _mapper.Map<CategoryDTO>(await _categoryRepository.GetByIdAsync(cateory => cateory.Id == Id, new List<string>()));
        }
    }
}
