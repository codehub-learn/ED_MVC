using ED_MVC.Services;
using Microsoft.AspNetCore.Mvc;
using ED_MVC.Domain;

namespace ED_MVC.Components
{
    public class ProductComponent (ICategoryService service) : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(int CategoryId)
        {
            var category = await service.GetCategoryByIdAsync(CategoryId);
            if (category == null) return View(new List<Product>());

            return View(category.Products);
        }
    }
}
