using CatalogoCleanArch.Domain.Entities;
using MediatR;

namespace CatalogoCleanArch.Application.Products.Queries
{
    public class GetProductByIdQuery : IRequest<Product>
    {
        public GetProductByIdQuery(int productId)
        {
            ProductId = productId;
        }

        public int ProductId { get; set; }
    }
}
