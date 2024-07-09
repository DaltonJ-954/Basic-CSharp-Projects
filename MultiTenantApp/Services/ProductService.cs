using MultiTenantApp.Models;
using MultiTenantApp.Services.DTOs;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace MultiTenantApp.Services
{
    
    public class ProductService : IProductService
    {
        private readonly TenantDbContext _context;

        public ProductService(TenantDbContext context)
        {
            _context = context;
        }

        public Product CreateProduct(CreateProductRequest request)
        {
            var product = new Product()
            {
                Name = request.Name
            };

            _context.Add(product);
            _context.SaveChanges();

            return product;
        }

        public bool DeletProduct(int id)
        {
            var product = _context.Products.Where(x => x.Id == id).FirstOrDefault();

            if (product == null)
            {
                _context.Remove(product);
                _context.SaveChanges(); 
                return false;
            }
            return false;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            var products = _context.Products.ToList();
            return products;
        }
    }
}
