using Microsoft.EntityFrameworkCore;
using Pharm.Domain.Models;
using Pharm.Infrastructure.Context;
using Pharm.Infrastructure.Interface;


namespace Pharm.Infrastructure.Repositories
{
    public class CategoryRepositoryAsync : GenericRepositoriesAsync<Category>, ICategoryRepositoryAsync
    {
        private readonly DbSet<Category> _categories;

        public CategoryRepositoryAsync(ApplicationDbContext context) : base(context)
        {
            _categories = context.Categories;
        }
    }
}
