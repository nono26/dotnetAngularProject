using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ProductsAPI.Controllers;

[Route("Product")]
[ApiController]
public class ProductController : ApiControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetProduct()
    {
        return NotFound();
    }

}
