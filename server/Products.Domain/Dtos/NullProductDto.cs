using System.Globalization;
using System;
namespace Products.Domain.Dtos;

public class NullProductDto : AbstractProduct
{
    public override string Name { get; set; }
    public override int Price { get; set; }
}

