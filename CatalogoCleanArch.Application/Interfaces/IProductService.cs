using CatalogoCleanArch.Application.DTOs;

namespace CatalogoCleanArch.Application.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDTO>> GetProducts();
        Task<ProductDTO> GetProductById(int id);
        Task<ProductDTO> GetProductCategory(int id);
        Task Add(ProductDTO productDTO);
        Task Delete(int id);
        Task Update(ProductDTO productDTO);
    }
}
