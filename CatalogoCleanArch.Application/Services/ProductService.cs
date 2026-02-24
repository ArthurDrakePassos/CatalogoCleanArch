using AutoMapper;
using CatalogoCleanArch.Application.DTOs;
using CatalogoCleanArch.Application.Interfaces;
using CatalogoCleanArch.Application.Products.Commands;
using CatalogoCleanArch.Application.Products.Queries;
using MediatR;

namespace CatalogoCleanArch.Application.Services
{
    public class ProductService : IProductService
    {
        private IMapper _mapper;
        private IMediator _mediator;
        public ProductService(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProductDTO>> GetProducts()
        {
            var productsQuery = new GetProductsQuery();

            if (productsQuery is null)
                throw new Exception("Entity could not be loaded");

            var result = await _mediator.Send(productsQuery);
            return _mapper.Map<IEnumerable<ProductDTO>>(result);
        }

        public async Task<ProductDTO> GetProductById(int id)
        {
            var productQuery = new GetProductByIdQuery(id);

            if (productQuery is null)
                throw new Exception("Entity could not be loaded");

            var result = await _mediator.Send(productQuery);
            return _mapper.Map<ProductDTO>(result);
        }

        public async Task Add(ProductDTO productDTO)
        {
            var productCreateCommand = _mapper.Map<ProductCreateCommand>(productDTO);
            await _mediator.Send(productCreateCommand);
        }

        public async Task Update(ProductDTO productDTO)
        {
            var productUpdateCommand = _mapper.Map<ProductUpdateCommand>(productDTO);
            await _mediator.Send(productUpdateCommand);
        }

        public async Task Delete(int id)
        {
            var productRemoveCommand = new ProductRemoveCommand(id);

            if(productRemoveCommand is null)
                throw new Exception("Entity could not be loaded");

            await _mediator.Send(productRemoveCommand);
        }
    }
}
