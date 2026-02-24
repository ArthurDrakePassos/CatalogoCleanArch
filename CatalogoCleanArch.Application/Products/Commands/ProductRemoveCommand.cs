using CatalogoCleanArch.Domain.Entities;
using MediatR;

namespace CatalogoCleanArch.Application.Products.Commands
{
    public class ProductRemoveCommand : IRequest<Product>
    {
        public ProductRemoveCommand(int productId)
        {
            ProductId = productId;
        }

        public int ProductId { get; set; }
    }
}
