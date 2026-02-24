using CatalogoCleanArch.Application.DTOs;
using CatalogoCleanArch.Domain.Entities;

namespace CatalogoCleanArch.Application.Interfaces
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryDTO>> GetCategories();
        Task<CategoryDTO> GetCategoryById(int id);
        Task Add(CategoryDTO categoryDTO);
        Task Update(CategoryDTO categoryDTO);
        Task Delete(int id);

    }
}
