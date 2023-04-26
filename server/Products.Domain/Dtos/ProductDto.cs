namespace Products.Domain.Dtos;

public class ProductDto : AbstractProduct
{
    public override string Name { get; set; }
    public override int Price { get; set; }

    public ProductDto(string name, int price)
    {
        Name = name;
        Price = price;
    }
}

