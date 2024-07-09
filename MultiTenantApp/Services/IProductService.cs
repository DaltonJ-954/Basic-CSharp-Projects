using MultiTenantApp.Models;
using MultiTenantApp.Services.DTOs;

namespace MultiTenantApp.Services
{
    public interface IProductService
    {
        IEnumerable<Product> GetAllProducts();
        Product CreateProduct(CreateProductRequest request);
        bool DeletProduct(int id);
    }
}
