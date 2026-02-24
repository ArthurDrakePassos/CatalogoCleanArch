using AutoMapper;
using CatalogoCleanArch.Application.DTOs;
using CatalogoCleanArch.Application.Interfaces;
using CatalogoCleanArch.Domain.Entities;
using CatalogoCleanArch.Domain.Interfaces;

namespace CatalogoCleanArch.Application.Services
{
    public class ProductService : IProductService
    {
        private IMapper _mapper;
        private IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProductDTO>> GetProducts()
        {
            var productsEntity = await _productRepository.GetProductsAsync();
            return _mapper.Map<IEnumerable<ProductDTO>>(productsEntity);
        }

        public async Task<ProductDTO> GetProductById(int id)
        {
            var productEntity = await _productRepository.GetByIdAsync(id);
            return _mapper.Map<ProductDTO>(productEntity);
        }

        public async Task<ProductDTO> GetProductCategory(int id)
        {
            var productEntity = await _productRepository.GetProductCategoryAsync(id);
            return _mapper.Map<ProductDTO>(productEntity);
        }

        public async Task Add(ProductDTO productDTO)
        {
            var productEntity = _mapper.Map<ProductDTO, Product>(productDTO);
            await _productRepository.CreateAsync(productEntity);
        }

        public async Task Update(ProductDTO productDTO)
        {
            var productEntity = _mapper.Map<ProductDTO, Product>(productDTO);
            await _productRepository.UpdateAsync(productEntity);
        }

        public async Task Delete(int id)
        {
            var productEntity = await _productRepository.GetByIdAsync(id);
            await _productRepository.DeleteAsync(productEntity);
        }
    }
}
