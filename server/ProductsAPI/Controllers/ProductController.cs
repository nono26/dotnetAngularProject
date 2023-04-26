using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Products.Domain.Contracts;
using Products.Domain.Dtos;
using Products.Domain.Entities;

namespace ProductsAPI.Controllers;

[Route("Product")]
[ApiController]
public class ProductController : ApiControllerBase
{
    private IProductsHandler _handler;

    public ProductController(IProductsHandler handler)
    {
        _handler = handler;
    }

    [HttpGet]
    [Route("All")]
    public async Task<ActionResult<IEnumerable<ProductDto>>> GetProducts()
    {
        var productsItem = await _handler.GetProducts();
        return Ok(productsItem);
    }

    [HttpGet]
    [Route("{id}")]
    public async Task<ActionResult<IEnumerable<ProductDto>>> GetProduct(int id)
    {
        var productsItem = await _handler.GetProduct(id);
        if (productsItem is NullProductDto)
            return NotFound();
        return Ok(productsItem);
    }

}
