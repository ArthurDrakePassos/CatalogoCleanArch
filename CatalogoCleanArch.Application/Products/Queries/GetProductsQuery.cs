using CatalogoCleanArch.Domain.Entities;
using MediatR;

namespace CatalogoCleanArch.Application.Products.Queries
{
    public class GetProductsQuery : IRequest<IEnumerable<Product>>
    {
    }
}
