using ED_MVC.Models;
using ED_MVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace ED_MVC.Controllers
{
    public class ProductsController(IProductService service) : Controller //site/products
    {
        public IActionResult Index()
        {
            return View();
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
