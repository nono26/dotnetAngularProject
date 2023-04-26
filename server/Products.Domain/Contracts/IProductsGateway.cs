using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Products.Domain.Dtos;
using Products.Domain.Entities;

namespace Products.Domain.Contracts;

public interface IProductsGateway
{
    Task<IEnumerable<ProductsDto>> GetProductsItems();
}
