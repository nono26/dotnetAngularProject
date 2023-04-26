using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Products.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Products.Infrastructure;
public class ProductDb : DbContext
{
    public ProductDb(DbContextOptions<ProductDb> options)
        : base(options)
    {
    }

    public DbSet<ProductItem> Products => Set<ProductItem>();
}