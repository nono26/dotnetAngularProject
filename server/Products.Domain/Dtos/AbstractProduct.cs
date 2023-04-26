

using System.Runtime;
namespace Products.Domain.Dtos;

public abstract class AbstractProduct
{
    public abstract string Name { get; set; }
    public abstract int Price { get; set; }
}
