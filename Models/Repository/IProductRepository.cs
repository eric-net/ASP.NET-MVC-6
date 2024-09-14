using DemoAPI.Models.Data;

namespace DemoAPI.Models.Repository
{
    public interface IProductRepository
    {
        Task<Product> CreateProductAsync(Product product);
        Task<bool> DeleteProductAsync(Product product);
        Product GetProductById(int id);
        IEnumerable<Product> GetProducts();
        Task<bool> UpdateProductAsync(Product product);
    }
}
