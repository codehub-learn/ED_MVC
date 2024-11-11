namespace ED_MVC.Services;
using ED_MVC.Domain;

public interface IProductService
{
    public Task<Product?> GetProductByIdAsync(int id);
    public Task<List<Product>> GetProductsAsync();
}
