namespace ED_MVC.Services;
using ED_MVC.Domain;

public interface IProductService
{
    public Task<Product?> GetProductByIdAsync(int id);
    public Task<List<Product>> GetProductsAsync();
    public Task<bool> AddProductAsync(Product product);
    public Task<bool> DeleteProductAsync(int id);
}
