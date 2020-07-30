using ShoppingSolution.Application.Catalog.Products.Dtos;
using ShoppingSolution.Application.Catalog.Products.Dtos.Public;
using ShoppingSolution.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSolution.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        PagedResult<ProductViewModel> GetAllByCategoryId(GetProductPagingRequest request);
    }
}
