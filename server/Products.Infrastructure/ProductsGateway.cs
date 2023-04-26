using Products.Domain.Contracts;
using Products.Domain.Dtos;
using Products.Domain.Entities;

namespace Products.Infrastructure;

public class ProductsGateway : IProductsGateway
{
    private ProductDb _context;
    public ProductsGateway(ProductDb context)
    {
        _context = context;

        var productsItem = new List<ProductItem>{
            new ProductItem(1,"Apple",10, 15),
            new ProductItem(2,"Lemon",20,30)
        };
        _context.AddRange(productsItem);
        _context.SaveChanges();
    }
    public async Task<IEnumerable<ProductsDto>> GetProductsItems()
    {
        var data = _context.Products.OrderBy(p => p.name);
        var ProductList = new List<ProductsDto>();
        foreach (ProductItem item in data)
        {
            ProductList.Add(new ProductsDto(item.name, item.price, item.priceVAT));
        }
        return ProductList;
    }
}
