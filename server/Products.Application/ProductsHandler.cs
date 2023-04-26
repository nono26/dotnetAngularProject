using Products.Domain.Contracts;
using Products.Domain.Dtos;
using Products.Domain.Entities;

namespace Products.Application;

public class ProductsHandler : IProductsHandler
{
    private IProductsGateway _gateway;

    public ProductsHandler(IProductsGateway gateway)
    {
        _gateway = gateway;
    }
    public async Task<IEnumerable<ProductsDto>> GetProductItems()
    {
        return await _gateway.GetProductsItems();
    }
}
