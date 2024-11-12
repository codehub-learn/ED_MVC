using ED_MVC.Domain;
using ED_MVC.Models;
using ED_MVC.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

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

        [Route("{controller}/category/{id}")]
        public async Task<IActionResult> Category([FromRoute] int id)
        { 
            ProductCategoryViewModel viewModel = new() { CategoryId = id };
            return View(viewModel); //Products/Category
        }

        [Route("{controller}/addproduct")]
        public async Task<IActionResult> AddProduct()
        {
            var categories = await categoryService.GetCategoriesAsync();
            var categoriesItems = categories
                .Select(c => new SelectListItem(c.Name, c.Id.ToString()))
                .ToList();

            return View(new AddProductViewModel() { Categories = categoriesItems });
        }

        [HttpPost, Route("{controller}/addproduct")]
        public async Task<IActionResult> AddProduct(Product product)
        {
            await service.AddProductAsync(product);
            return RedirectToAction("Details", new {id = product.Id});
        }

        [Route("{controller}/delete/{id}")]
        public async Task<IActionResult> DeleteProduct([FromRoute] int id)
        {
            await service.DeleteProductAsync(id);
            return RedirectToAction("Index");
        }

    }
}
