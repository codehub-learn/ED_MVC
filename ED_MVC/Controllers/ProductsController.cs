using ED_MVC.Domain;
using ED_MVC.Models;
using ED_MVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace ED_MVC.Controllers
{
    public class ProductsController(IProductService service, ICategoryService categoryService) : Controller //site/products
    {
        public async Task<IActionResult> Index()
        {
            List<Category> categories = await categoryService.GetCategoriesAsync();
            ProductIndexViewModel viewModel = new ProductIndexViewModel()
            {
                Categories = categories,
                CountOfProducts = 2
            };

            return View(viewModel);
        }

        [Route("{controller}/{id}")]
        public async Task<IActionResult> Details([FromRoute] int id)
        {
            var product = await service.GetProductByIdAsync(id);
            if (product == null) return NotFound();

            var viewModel = new ProductDetailsViewModel() { Product = product };
            return View(viewModel);
        }
    }
}
