﻿using ED_MVC.Domain;
using Microsoft.EntityFrameworkCore;

namespace ED_MVC.Services
{
    public class ProductService(ChocoContext context) : IProductService
    {
        public async Task<Product?> GetProductByIdAsync(int id)
        {
            return await context.Products
                .Include(p => p.Category)
                .Where(p => p.Id == id)
                .SingleOrDefaultAsync();
        }

        public async Task<List<Product>> GetProductsAsync()
        {
            return await context.Products.ToListAsync();
        }
    }
}