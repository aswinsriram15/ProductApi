using System.Collections.Generic;
using System.Threading.Tasks;
using ProductApi.Models;


namespace ProductAPI.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllProductsAsync();
        Task<Product> GetProductByIdAsync(int id);
        Task<Product> AddProductAsync(Product product);
        Task<Product> UpdateProductAsync(Product product);
        Task<bool> DeleteProductAsync(int id);
        Task<Product> DecrementStockAsync(int id, int amount);
        Task<Product> AddToStockAsync(int id, int amount);
    }
}
