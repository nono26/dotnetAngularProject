using Products.Domain.Contracts;
using Products.Domain.Dtos;
using Products.Domain.Entities;

namespace Products.Infrastructure;

public class ProductsGateway : IProductsGateway
{
    private ProductDb _context;
    private NullProductDto? NotFound = new NullProductDto { Name = "Not Found", Price = -1 };
    public ProductsGateway(ProductDb context)
    {
        _context = context;

        if (_context.Products.Find(1) == null)
        {
            var productsItem = new List<ProductItem>{
            new ProductItem(1,"Apple",10, 15,true),
            new ProductItem(2,"Lemon",20,30,true)
            };
            _context.Products.AddRange(productsItem);
            _context.SaveChanges();
        }


    }

    public async Task<AbstractProduct> GetProductDto(int id)
    {
        var product = await _context.Products.FindAsync(id);
        if (product == null)
            return NotFound;
        return new ProductDto(product.name, product.price);
    }

    public async Task<IEnumerable<ProductDto>> GetProductsDto()
    {
        var data = _context.Products.OrderBy(p => p.name);
        var ProductList = new List<ProductDto>();
        foreach (ProductItem item in data)
        {
            ProductList.Add(new ProductDto(item.name, item.price));
        }
        return ProductList;
    }
}
