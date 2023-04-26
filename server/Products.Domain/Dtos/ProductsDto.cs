using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Products.Domain.Dtos;

public record ProductsDto(string name, int price, int priceVAT);

