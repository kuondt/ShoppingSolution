using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSolution.Application.Catalog.Products.Dtos
{
    public class ProductCreateRequest
    {
        public string Name { get; set; }

        public decimal Price { get; set; }
    }
}
