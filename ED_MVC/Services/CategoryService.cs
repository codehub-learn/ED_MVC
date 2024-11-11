using ED_MVC.Domain;
using Microsoft.EntityFrameworkCore;

namespace ED_MVC.Services
{
    public class CategoryService(ChocoContext context) : ICategoryService
    {
        public async Task<Category?> GetCategoryByIdAsync(int id)
        {
            return await context.Categories
                .Include(c => c.Products)
                .Where(c => c.Id == id)
                .SingleOrDefaultAsync();
        }

        public async Task<List<Category>> GetCategoriesAsync()
        {
            return await context.Categories.ToListAsync();
        }
    }
}
