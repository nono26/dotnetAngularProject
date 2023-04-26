using Products.Domain.Dtos;
using Products.Domain.Entities;

namespace Products.Domain.Contracts;
public interface IProductsHandler
{
    Task<IEnumerable<ProductsDto>> GetProductItems();
}
