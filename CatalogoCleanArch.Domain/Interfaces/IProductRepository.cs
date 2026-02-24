using CatalogoCleanArch.Domain.Entities;

namespace CatalogoCleanArch.Domain.Interfaces
{
    public interface IProductRepository
    {
        Task<Product> GetByIdAsync(int? id);
        Task<IEnumerable<Product>> GetProductsAsync();
        Task<Product> GetProductCategoryAsync(int? id);
        Task<Product> CreateAsync(Product product);
        Task<Product> UpdateAsync(Product product);
        Task<Product> DeleteAsync(Product product);
    }
}
