using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Products.Domain.Contracts;
using Products.Domain.Dtos;
using Products.Domain.Entities;

namespace ProductsAPI.Controllers;

[Route("Products")]
[ApiController]
public class ProductController : ApiControllerBase
{
    private IProductsHandler _handler;

    public ProductController(IProductsHandler handler)
    {
        _handler = handler;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<ProductsDto>>> GetProducts()
    {
        var productsItem = await _handler.GetProductItems();
        return Ok(productsItem);
    }

}
