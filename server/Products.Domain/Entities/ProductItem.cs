using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Products.Domain.Entities;

public record ProductItem(string name, int price, int priceVAT);

