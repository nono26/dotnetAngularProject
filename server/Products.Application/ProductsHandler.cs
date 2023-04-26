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

    public async Task<AbstractProduct> GetProduct(int id)
    {
        return await _gateway.GetProductDto(id);
    }

    public async Task<IEnumerable<ProductDto>> GetProducts()
    {
        return await _gateway.GetProductsDto();
    }
}
