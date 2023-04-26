using Products.Domain.Dtos;
using Products.Domain.Entities;

namespace Products.Domain.Contracts;
public interface IProductsHandler
{
    Task<IEnumerable<ProductDto>> GetProducts();
    Task<AbstractProduct> GetProduct(int id);
}
