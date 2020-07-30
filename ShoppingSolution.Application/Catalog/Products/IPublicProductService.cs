using ShoppingSolution.Application.Catalog.Products.Dtos;
using ShoppingSolution.Application.Catalog.Products.Dtos.Public;
using ShoppingSolution.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSolution.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        Task<PagedResult<ProductViewModel>> GetAllByCategoryId(GetProductPagingRequest request);
    }
}
