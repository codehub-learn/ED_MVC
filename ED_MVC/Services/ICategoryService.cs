namespace ED_MVC.Services;
using ED_MVC.Domain;

public interface ICategoryService
{
    public Task<Category?> GetCategoryByIdAsync (int id);
    public Task<List<Category>> GetCategoriesAsync();
}
